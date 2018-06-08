using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaTeXTableGenerator.View;
using LaTeXTableGenerator.Model;
using System.Windows.Forms;
using System.Drawing;

namespace LaTeXTableGenerator
{
    class Presenter
    {
        IMainView mainView;
        ITableCustomizationView tableCustomizationView;
        Table table;
        Generator generator;

        public Presenter(IMainView mainView,Table table, Generator generator, ITableCustomizationView tableCustomizationView)
        {
            this.mainView = mainView;
            this.table = table;
            this.tableCustomizationView = tableCustomizationView;
            this.generator = generator;


            //Delegates
            mainView.CreateTableButtonClickEvent += ShowTableCustomizationForm;
            tableCustomizationView.CancelButtonClickEvent += ShowMainView;
            tableCustomizationView.CancelButtonClickEvent += TableDestruction;
            tableCustomizationView.MergeButtonClickEvent += MergeCells;
            tableCustomizationView.SplitButtonClickEvent += SplitCells;
            tableCustomizationView.GenerateButtonClickEvent += GeneateLatexTableText;

        }


        //Methods
        //===============================================================================================

        //Method resposible for generating appropriate table of buttons
        public void CreateTableCellButtons(int verticalStartPosiotion,int horizontalStartPosiotion,
            int numberOfRows, int numberOfColumns)
        {
            int localVerticalPositon = verticalStartPosiotion;
            int localHorizontalPosition;
            int labelCounter = 1;

            table.NumberOfColumns = numberOfColumns;
            table.NumberOfRows = numberOfRows;

            for (int i = 0; i < numberOfRows; i++)
            {
                localHorizontalPosition = horizontalStartPosiotion;
                for(int j=0; j < numberOfColumns; j++)
                {
                    TableCellButton tableCellButton = new TableCellButton(labelCounter,i+1,j+1);
                    tableCellButton.Left = localHorizontalPosition;
                    tableCellButton.Top = localVerticalPositon;
                    tableCellButton.Height = 35;                    
                    tableCellButton.Text = labelCounter.ToString();
                    tableCellButton.Click += new EventHandler(SelectingCell);
                    table.TableCellButtonList.Add(tableCellButton);
                    tableCustomizationView.ControllsAdd(tableCellButton);
                    labelCounter++;
                    localHorizontalPosition += 85;
                }
                localVerticalPositon += 37;
            }
        }

        //Method resposible for displaying table customization view with aprropriate table
        public void ShowTableCustomizationForm()
        {
            mainView.SetVisible = false;
            tableCustomizationView.SetVisible = true; 
            CreateTableCellButtons(Table.verticalStartPosiotion, Table.horizontalStartPosiotion, mainView.NumberOfRows, 
                mainView.NumberOfColumns);
        }

        //Deleting table on returning to main view
        public void TableDestruction()
        {
            foreach(TableCellButton tcb in table.TableCellButtonList)
                tableCustomizationView.ControllsRemove(tcb);
            tableCustomizationView.SelectedCells.Clear();
            table.TableCellButtonList.Clear();                
        }

        public void ShowMainView()
        {
            tableCustomizationView.SetVisible = false;
            mainView.SetVisible = true;
        }

        public void MergeCells()
        {
            sortList(tableCustomizationView.SelectedCells);
            if(MergedCellsValidation(tableCustomizationView.SelectedCells))
            {
                Random rnd = new Random();
                Color groupColor = TableCellButton.GetRandomColor(rnd);
                foreach (int i in tableCustomizationView.SelectedCells)
                {   
                    table.TableCellButtonList[i - 1].setBodyColor(groupColor);
                    table.TableCellButtonList[i - 1].deselectCell();
                    table.TableCellButtonList[i - 1].InsertMergedCells(tableCustomizationView.SelectedCells);
                    TableCellButton.ChangeState(table.TableCellButtonList[i - 1]);                    
                }
                tableCustomizationView.SelectedCells.Clear();
            }         
        }

        //Method resposible for inserting selected buttons indexes into list
        public void SelectingCell(object sender, EventArgs e)
        {
            TableCellButton selectedCellButton = (TableCellButton)sender;
            if (!selectedCellButton.IsChosen)
                tableCustomizationView.SelectedCells.Add(selectedCellButton.Index);
            else
                tableCustomizationView.SelectedCells.Remove(selectedCellButton.Index);
        }

        //List Bubble sort
        public void sortList(List<int> listToSort)
        {
            int length = listToSort.Count;
            int temp = listToSort[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                    if (listToSort[i] > listToSort[j])
                    {
                        temp = listToSort[i];
                        listToSort[i] = listToSort[j];
                        listToSort[j] = temp;
                    }
            }
        }

        public bool MergedCellsValidation(List<int> cellsToMerge)
        {
            //Single cell selected 
            if (cellsToMerge.Count == 1)
            {
                tableCustomizationView.SingleMergeErrorMessage();
                return false;
            }

            foreach(int i in cellsToMerge)
                if(table.TableCellButtonList[i - 1].MergedCellsIndexes.Count != 0)
                {
                    tableCustomizationView.WrongMergeErrorMessage();
                    return false;
                } 
                                
            int minX = table.TableCellButtonList[cellsToMerge[0]-1].RowNumber;
            int minY = table.TableCellButtonList[cellsToMerge[0]-1].ColumnNumber;
            int maxX = minX;
            int maxY = minY;
            int startCell;
            List<int> correctMerge = new List<int>();
            int diffX,diffY;            
            foreach (int i in cellsToMerge)
            {
                if (table.TableCellButtonList[i - 1].RowNumber > maxX)
                    maxX = table.TableCellButtonList[i - 1].RowNumber;
                else if (table.TableCellButtonList[i - 1].RowNumber < minX)
                    minX = table.TableCellButtonList[i - 1].RowNumber;
                if(table.TableCellButtonList[i - 1].ColumnNumber > maxY)
                    maxY = table.TableCellButtonList[i - 1].ColumnNumber;
                else if (table.TableCellButtonList[i - 1].ColumnNumber < minY)
                    minY = table.TableCellButtonList[i - 1].ColumnNumber;
            }
            diffX = maxX - minX;
            diffY = maxY - minY;
            startCell = (minX - 1) * table.NumberOfColumns + minY;

            for(int j = 0;j <= diffX;j++)
                for (int i = 0; i <= diffY; i++)
                    correctMerge.Add((startCell + i) + (j*table.NumberOfColumns));

            //checking if both lists have the same size
            if (cellsToMerge.Count != correctMerge.Count)
            {
                tableCustomizationView.WrongMergeErrorMessage();
                return false;
            }
               
            for(int i =0; i<correctMerge.Count; i++)
                if (correctMerge[i] != cellsToMerge[i])
                    return false;       
            return true;
        }

        public void SplitCells()
        {
            if (tableCustomizationView.SelectedCells.Count != 1)
                tableCustomizationView.MultipleSplitErrorMessage();
            else if((table.TableCellButtonList[tableCustomizationView.SelectedCells[0] - 1].MergedCellsIndexes.Count == 0))
                tableCustomizationView.MultipleSplitErrorMessage();
            else
            {
                List<int> cellsToSplit = new List<int>(table.TableCellButtonList[tableCustomizationView.SelectedCells[0] - 1].MergedCellsIndexes);

                foreach (int i in cellsToSplit)
                {
                    table.TableCellButtonList[i - 1].setBodyColor(Control.DefaultBackColor);
                    table.TableCellButtonList[i - 1].MergedCellsIndexes.Clear();
                }
                table.TableCellButtonList[tableCustomizationView.SelectedCells[0] - 1].deselectCell();
                TableCellButton.ChangeState(table.TableCellButtonList[tableCustomizationView.SelectedCells[0] - 1]);
                tableCustomizationView.SelectedCells.Clear();
            }
        }

        public void GeneateLatexTableText()
        {
            List<string> cline;
            generator.TextAlign('l', 4);
            for (int i = 0; i < table.NumberOfRows; i++)
            {
                generator.TableRowStructure.Add(generator.CreateOneRow(table.NumberOfColumns, i, table.TableCellButtonList));
                generator.TableColumnStructure.Add(generator.CreateOneRowColumnInfo(table.NumberOfColumns, table.NumberOfRows, i, table.TableCellButtonList));
            }
            cline = new List<string>(generator.GenerateCline(generator.TableRowStructure, generator.TableColumnStructure, table.NumberOfColumns));            
            generator.generateTableBodyString(generator.TableRowStructure, generator.TableColumnStructure,cline);
            
        }
    }
}
;
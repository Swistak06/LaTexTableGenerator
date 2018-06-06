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

        public Presenter(IMainView mainView,Table table, ITableCustomizationView tableCustomizationView)
        {
            this.mainView = mainView;
            this.table = table;
            this.tableCustomizationView = tableCustomizationView;


            //Delegates
            mainView.CreateTableButtonClickEvent += ShowTableCustomizationForm;
            tableCustomizationView.CancelButtonClickEvent += ShowMainView;
            tableCustomizationView.CancelButtonClickEvent += TableDestruction;
            tableCustomizationView.MergeButtonClickEvent += MergeCells;
        }


        //Methods
        public void CreateTableCellButtons(int verticalStartPosiotion,int horizontalStartPosiotion,
            int numberOfRows, int numberOfColumns)
        {
            int localVerticalPositon = verticalStartPosiotion;
            int localHorizontalPosition;
            int labelCounter = 1;
            for(int i = 0; i < numberOfRows; i++)
            {
                localHorizontalPosition = horizontalStartPosiotion;
                for(int j=0; j < numberOfColumns; j++)
                {
                    TableCellButton tableCellButton = new TableCellButton(labelCounter,i,j);
                    tableCellButton.Left = localHorizontalPosition;
                    tableCellButton.Top = localVerticalPositon;
                    tableCellButton.Height = 35;                    
                    tableCellButton.Text = labelCounter.ToString();
                    table.TableCellButtonList.Add(tableCellButton);
                    tableCustomizationView.ControllsAdd(tableCellButton);
                    labelCounter++;
                    localHorizontalPosition += 85;
                }
                localVerticalPositon += 37;
            }
        }

        public void ShowTableCustomizationForm()
        {
            mainView.SetVisible = false;
            tableCustomizationView.SetVisible = true; 
            CreateTableCellButtons(Table.verticalStartPosiotion, Table.horizontalStartPosiotion, mainView.NumberOfRows, 
                mainView.NumberOfColumns);
        }

        public void TableDestruction()
        {
            foreach(TableCellButton tcb in table.TableCellButtonList)
                tableCustomizationView.ControllsRemove(tcb);
            table.TableCellButtonList.Clear();
                
        }

        public void ShowMainView()
        {
            tableCustomizationView.SetVisible = false;
            mainView.SetVisible = true;
        }

        public void MergeCells()
        {
            //Creating list of all cells merged this time
            List<int> mergedCells = new List<int>();
            Random rnd = new Random();
            Color groupColor = TableCellButton.GetRandomColor(rnd); 
            
            
              
            //foreach (TableCellButton tcb in table.TableCellButtonList)
            //    if (tcb.IsChosen && tcb.MergedCellsIndexes.Count == 0)
            //        mergedCells.Add(tcb.Index);
            ////Inserting list of merged cells into every cell and changing its state
            //if(mergedCells.Count>1)
            //    foreach (int index in mergedCells)
            //        if (table.TableCellButtonList.ElementAt(index - 1).IsChosen)
            //        {
            //            table.TableCellButtonList.ElementAt(index - 1).BackColor = groupColor;
            //            table.TableCellButtonList.ElementAt(index - 1).MergedCellsIndexes = mergedCells;
            //            TableCellButton.ChangeState(table.TableCellButtonList.ElementAt(index - 1));
            //        }
        }
    }
}

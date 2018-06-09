using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LaTeXTableGenerator.Model
{
    class Generator
    {
        public List<List<int>> TableRowStructure { get; set; }
        public List<List<int>> TableColumnStructure { get; set; }

        public static Color GetRandomColor()
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return randomColor;
        }

        public Generator()
        {
            TableRowStructure = new List<List<int>>();
            TableColumnStructure = new List<List<int>>();
        }

        public string TextAlign(char align,int numberOfColumns)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\\begin{tabular}{");
            for (int i =0; i< numberOfColumns; i++)
            {
                if(i == 0)
                    sb.AppendFormat("|{0}|", align);
                else
                    sb.AppendFormat("{0}|", align);
            }
            sb.Append("}");
            sb.Append("\n \\hline \n");
            return sb.ToString();
        }

        public List<int> CreateOneRow(int numberOfColumns,int rowNumber, List<TableCellButton> tableList)
        {
            int rowRange;
            int toSkip;
            List<int> RowStructure = new List<int>();
            for(int i = rowNumber * numberOfColumns;i<numberOfColumns*(rowNumber+1);i++)
            {
                toSkip = 0;
                //If cell is not merged 
                if (tableList[i].MergedCellsIndexes.Count == 0)
                    RowStructure.Add(1);
                else
                {
                    rowRange = (tableList[i].RowNumber * numberOfColumns) - tableList[i].Index;
                    foreach (int c in tableList[i].MergedCellsIndexes)
                        if (c <= tableList[i].Index + rowRange & c > tableList[i].Index)
                            toSkip++;
                    RowStructure.Add(toSkip + 1);
                    i += toSkip;
                }
            }
            return RowStructure;
        }

        public List<int> CreateOneRowColumnInfo(int numberOfColumns,int numberOfRows, int rowNumber, List<TableCellButton> tableList)
        {
            int rowRange;
            int toSkip;
            int counter;
            int group;
            List<int> RowStructure = new List<int>();
            for (int i = rowNumber * numberOfColumns; i < numberOfColumns * (rowNumber + 1); i++)
            {
                toSkip = 0;
                counter = 0;
                group=1;
                //If cell is not merged 
                if (tableList[i].MergedCellsIndexes.Count == 0)
                    RowStructure.Add(1);
                else
                {                    
                    rowRange = (tableList[i].RowNumber * numberOfColumns) - tableList[i].Index;
                    counter = numberOfColumns - rowRange;
                    while(counter < numberOfColumns*numberOfRows)
                    {
                        if (tableList[i].Index > counter & tableList[i].MergedCellsIndexes.Contains(counter))
                        {
                            group = 0;
                            break;
                        }
                            
                        else if(tableList[i].Index == counter || (tableList[i].Index > counter & !tableList[i].MergedCellsIndexes.Contains(counter)))
                            counter += numberOfColumns;
                        else if(tableList[i].Index < counter & tableList[i].MergedCellsIndexes.Contains(counter))
                        {
                            group++;
                            counter += numberOfColumns;
                        }
                        else
                            break;
                    }
                    RowStructure.Add(group);
                    //Ignoring same group in same row
                    foreach (int c in tableList[i].MergedCellsIndexes)
                        if (c <= tableList[i].Index + rowRange & c > tableList[i].Index)
                            toSkip++;                    
                    i += toSkip;
                }
            }
            return RowStructure;
        }

        public string generateTableBodyString(List<List<int>> rowStructure, List<List<int>> columnStructure,List<string> clineText)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0;i<rowStructure.Count;i++)
            {
                for(int j = 0;j<rowStructure[i].Count;j++)
                {
                    if (rowStructure[i][j] == 1 & columnStructure[i][j] <= 1)
                        if(rowStructure[i].Count>1 & j != rowStructure[i].Count - 1)
                            if(columnStructure[i][j] == 1)
                                sb.Append("T & ");
                            else
                                sb.Append(" & ");
                        else
                            if (columnStructure[i][j] == 1)
                                sb.AppendFormat("T \\\\{0} \n", clineText[i]);
                            else
                                sb.AppendFormat(" \\\\{0} \n", clineText[i]);

                    if (rowStructure[i][j] > 1 & columnStructure[i][j] <= 1)
                        if (rowStructure[i].Count > 1 & j != rowStructure[i].Count - 1)
                            if(columnStructure[i][j] == 1 )
                                sb.AppendFormat("\\multicolumn{0}{1}{2}{3}{4} &", "{", rowStructure[i][j], "}", "{|c|}", "{T}");
                            else
                                sb.AppendFormat("\\multicolumn{0}{1}{2}{3}{4} &", "{", rowStructure[i][j], "}", "{|c|}", "{}");
                        else
                            if (columnStructure[i][j] == 1)
                                sb.AppendFormat("\\multicolumn{0}{1}{2}{3}{4} \\\\ {5}\n", "{", rowStructure[i][j], "}", "{|c|}", "{T}", clineText[i]);
                            else
                                sb.AppendFormat("\\multicolumn{0}{1}{2}{3}{4} \\\\ {5}\n", "{", rowStructure[i][j], "}", "{|c|}", "{}", clineText[i]);
                    if (rowStructure[i][j] == 1 & columnStructure[i][j] > 1)
                        if (rowStructure[i].Count > 1 & j != rowStructure[i].Count - 1)
                            sb.AppendFormat("\\multirow{0}{1}{2}{3}{4} &", "{", columnStructure[i][j], "}", "{*}", "{T}");
                        else
                            sb.AppendFormat("\\multirow{0}{1}{2}{3}{4} \\\\{5} \n", "{", columnStructure[i][j], "}", "{*}", "{T}", clineText[i]);
                    if (rowStructure[i][j] > 1 & columnStructure[i][j] > 1)
                        if (rowStructure[i].Count > 1 & j != rowStructure[i].Count - 1)
                            sb.AppendFormat("\\multicolumn{0}{1}{2}{3}{{\\multirow{4}{5}{6}{7}{8}}} &", "{", rowStructure[i][j], "}", "{|c|}", "{", columnStructure[i][j], "}", "{*}", "{T}");
                        else
                            sb.AppendFormat("\\multicolumn{0}{1}{2}{3}{{\\multirow{4}{5}{6}{7}{8}}} \\\\{9} \n", "{", rowStructure[i][j], "}", "{|c|}", "{", columnStructure[i][j], "}", "{*}", "{T}", clineText[i]);
                }
            }
            return sb.ToString();
        }
        
        public List<string> GenerateCline(List<List<int>> rowStructure, List<List<int>> columnStructure,int cloumnNumber)
        {
            List<List<int>> horizontalLines = new List<List<int>>();
            List<int> horizontalLinesRow = new List<int>();
            List<List<int>> cLines = new List<List<int>>();
            List<int> cLinesRow = new List<int>();
            List<string> clinesText = new List<string>();
                     

            //Creating matrix of 1 in table size
            for (int i = 0; i < rowStructure.Count; i++)
            {
                for (int j = 0; j < rowStructure[i].Count; j++)
                   for (int k = 0; k < rowStructure[i][j]; k++)
                            horizontalLinesRow.Add(1);

                horizontalLines.Add(horizontalLinesRow);
                horizontalLinesRow = new List<int>();
            }

            int currentCell;

            //inserting information which cells has bottom line
            for (int i = 0; i < rowStructure.Count; i++)
            {
                currentCell = 0;
                for (int j = 0; j < rowStructure[i].Count; j++)
                {
                    //if cell is of height 1
                    if(columnStructure[i][j] == 1)
                    {
                        for (int k = 0; k < rowStructure[i][j]; k++)
                        {
                            horizontalLines[i][currentCell] = 1;
                            currentCell++;
                        }                            
                    }
                    //if cell is higher than  1
                    else if(columnStructure[i][j]> 1)
                    {
                        for (int row = 0; row < columnStructure[i][j]-1; row++)
                        {
                            for (int column = currentCell; column < currentCell + rowStructure[i][j]; column++)
                                horizontalLines[i + row][column] = 0;
                        }
                        currentCell += rowStructure[i][j];
                    }
                    else if(columnStructure[i][j] == 0)
                    {
                        for (int k = 0; k < rowStructure[i][j]; k++)
                        {
                            currentCell++;
                        }
                    }
                }
            }

            int counter;

            //checking sizes of parts with or without bottom line
            for (int i = 0;i<horizontalLines.Count;i++)
            {
                counter = 0;
                for(int j = 0; j<horizontalLines[0].Count; j++)
                {
                    if (horizontalLines[i][j] == 1 & counter >= 0)
                        counter++;
                    else if (horizontalLines[i][j] == 0 & counter <= 0)
                        counter--;
                    else if(counter > 0 & horizontalLines[i][j] == 0)
                    {
                        cLinesRow.Add(counter);
                        counter = -1;
                    }
                    else if(counter < 0 & horizontalLines[i][j] == 1)
                    {
                        cLinesRow.Add(counter);
                        counter = 1;
                    }
                }
                cLinesRow.Add(counter);
                cLines.Add(cLinesRow);
                cLinesRow = new List<int>();
            }

            StringBuilder sb = new StringBuilder();
            int start;
            int stop;

            for (int i =0;i<cLines.Count;i++)
            {
                start = 1;
                stop = 1;
                for(int j = 0;j<cLines[i].Count;j++)
                {
                    if(cLines[i][j]>=1 )
                    {
                        stop += cLines[i][j]-1;
                        sb.AppendFormat(" \\cline{0}{1}-{2}{3}", "{", start, stop, "}");
                        start += cLines[i][j];
                    }
                    else if(cLines[i][j] < 0)
                    {
                        start += Math.Abs(cLines[i][j]);
                        stop = start;
                    }   
                }
                clinesText.Add(sb.ToString());
                sb.Clear();
            }

            return clinesText;
        }        
    }
}

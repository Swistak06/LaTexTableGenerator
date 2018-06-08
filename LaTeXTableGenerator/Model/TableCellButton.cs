using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LaTeXTableGenerator.Model
{
    public class TableCellButton : Button
    {
        public static void ChangeState(TableCellButton tcb)
        {
            tcb.IsChosen = !tcb.IsChosen;
            if (tcb.IsChosen)
            {
                tcb.selectCell();
            }
            else
            {
                tcb.deselectCell();
            }
        }

        public static Color GetRandomColor(Random rnd)
        {           
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return randomColor;
        }

        public int Index { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public bool IsChosen { get; set; }

        public List<int> MergedCellsIndexes { get; set; }

        public TableCellButton(int index,int rowNumber, int columnNumber)
        {
            Index = index;
            RowNumber = rowNumber;
            ColumnNumber = columnNumber;
            IsChosen = false;
            MergedCellsIndexes = new List<int>();
        }

        public void InsertMergedCells(List<int> mergedCells)
        {
            MergedCellsIndexes = mergedCells;
        }

        public void RemoveMergedCells()
        {
            MergedCellsIndexes.Clear();
        }
                
        public void setBodyColor(Color color)
        {
            BackColor = color;
        }

        public void deselectCell( )
        {
            FlatStyle = FlatStyle.Standard;
            FlatAppearance.BorderColor = System.Drawing.Color.Empty;
        }

        public void selectCell()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.Red;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ChangeState(this);
        }
    }
}

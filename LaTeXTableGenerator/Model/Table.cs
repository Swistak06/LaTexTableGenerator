using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeXTableGenerator.Model
{
    public class Table
    {
        
        public List<TableCellButton> TableCellButtonList { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfRows { get; set; }
        public char TextAlign { get; set; }

        public Table()
        {
            TableCellButtonList = new List<TableCellButton>();
        }

    }
}

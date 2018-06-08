using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeXTableGenerator.Model
{
    class LatexTable
    {
        public string TableBegin { get; set; }
        public string TabularBegin { get; set; }
        public string TableBody { get; set; }
        public string EndOfTable { get; set; }

        public LatexTable()
        {
            TableBegin = "\begin{table}\n";
            EndOfTable = " \\hline \n \\end{tabular}\n \\end{table}";
        }
    }
}

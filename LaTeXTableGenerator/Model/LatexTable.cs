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
            TableBegin = "\\begin{table}\n";
            EndOfTable = "\\end{tabular}\n \\end{table}";
        }

        public void SaveTableToFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}{2}{3}", TableBegin, TabularBegin, TableBody, EndOfTable);
            System.IO.File.WriteAllText(@"LaTeXTable.txt",sb.ToString());
        }
    }
}

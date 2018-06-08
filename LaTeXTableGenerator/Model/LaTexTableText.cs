using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeXTableGenerator.Model
{
    class LaTexTableText
    {
        public string TableBegin { get; set; }
        public string TabularBegin { get; set; }
        public string EndOfTable { get; set; }

        public LaTexTableText()
        {
            TableBegin = "\begin{table}\n";
            EndOfTable = " \\hline \n \\end{tabular}\n \\end{table}";
        }

        public void TextAlign(char align,int numberOfColumns)
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
            sb.Append("\n \\hline");
            TabularBegin = sb.ToString();
            Console.WriteLine(TabularBegin);
        }

    }
}

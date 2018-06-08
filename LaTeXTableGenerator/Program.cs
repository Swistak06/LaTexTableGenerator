﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaTeXTableGenerator.View;
using LaTeXTableGenerator.Model;

namespace LaTeXTableGenerator
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView mainView = new MainView();
            TableCustomizationView tableCustomizationView = new TableCustomizationView();
            Table table = new Table();
            LaTexTableText LatexTableText = new LaTexTableText();
            Presenter presenter = new Presenter(mainView,table, LatexTableText,tableCustomizationView);
            Application.Run(mainView);
        }
    }
}

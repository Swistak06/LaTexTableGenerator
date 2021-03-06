﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaTeXTableGenerator.Model;

namespace LaTeXTableGenerator.View
{
    interface ITableCustomizationView
    {
        bool SetVisible { get; set; }
        List<int> SelectedCells { get; set; }
        List<int> CurrentlyChosenButtons { get; set; }
        char TextAlign { get; set; }
        void PlaceFormInCenter();
        void ControllsAdd(TableCellButton tableCellButton);
        void ControllsRemove(TableCellButton tableCellButton);
        void WrongMergeErrorMessage();
        void SingleMergeErrorMessage();
        void MultipleSplitErrorMessage();

        event Action CancelButtonClickEvent;
        event Action MergeButtonClickEvent;
        event Action SplitButtonClickEvent;
        event Action GenerateButtonClickEvent;

    }
}

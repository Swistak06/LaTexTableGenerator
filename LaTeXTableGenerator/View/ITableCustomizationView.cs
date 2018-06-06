using System;
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

        List<int> CurrentlyChosenButtons { get; set; }
        void PlaceFormInCenter();
        void ControllsAdd(TableCellButton tableCellButton);
        void ControllsRemove(TableCellButton tableCellButton);

        event Action CancelButtonClickEvent;
        event Action MergeButtonClickEvent;

    }
}

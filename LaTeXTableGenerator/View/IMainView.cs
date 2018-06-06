using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeXTableGenerator.View
{
    interface IMainView
    {
        bool SetVisible { get; set; }
        int NumberOfColumns { get; set; }
        int NumberOfRows { get; set; }

        event Action CreateTableButtonClickEvent;
        void PlaceFormInCenter();

    }
}

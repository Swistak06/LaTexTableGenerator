using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaTeXTableGenerator.Model;

namespace LaTeXTableGenerator.View
{
    public partial class TableCustomizationView : Form, ITableCustomizationView
    {
        public TableCustomizationView()
        {
            InitializeComponent();
            currentlyChosenButtons = new List<int>();
            selectedCells = new List<int>();
        }

        private List<int> currentlyChosenButtons;
        private List<int> selectedCells;

        public bool SetVisible
        {
            get
            {
                return Visible;
            }

            set
            {
                Visible = value;
            }
        }

        public List<int> CurrentlyChosenButtons
        {
            get
            {
                return currentlyChosenButtons;
            }

            set
            {
                currentlyChosenButtons = value; 
            }
        }

        public List<int> SelectedCells
        {
            get
            {
                return selectedCells;
            }

            set
            {
                selectedCells = value;
            }
        }

        public event Action CancelButtonClickEvent;
        public event Action MergeButtonClickEvent;

        public void ControllsAdd(TableCellButton tableCellButton)
        {
            Controls.Add(tableCellButton);
        }

        public void PlaceFormInCenter()
        {
            CenterToScreen();
        }

        private void TableCustomizationView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(CancelButtonClickEvent != null)
            {
                CancelButtonClickEvent();
            }
        }

        public void ControllsRemove(TableCellButton tableCellButton)
        {
            Controls.Remove(tableCellButton);
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            if(MergeButtonClickEvent != null)
            {
                MergeButtonClickEvent();
            }
        }
    }
}

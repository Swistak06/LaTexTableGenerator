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
            textAlign = 'c';   
        }

        private List<int> currentlyChosenButtons;
        private List<int> selectedCells;
        private char textAlign;

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

        public char TextAlign
        {
            get
            {
                return textAlign;
            }

            set
            {
                textAlign = value;
            }
        }

        public event Action CancelButtonClickEvent;
        public event Action MergeButtonClickEvent;
        public event Action SplitButtonClickEvent;
        public event Action GenerateButtonClickEvent;

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

        public void ControllsRemove(TableCellButton tableCellButton)
        {
            Controls.Remove(tableCellButton);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (CancelButtonClickEvent != null)
                CancelButtonClickEvent();
        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            if(MergeButtonClickEvent != null)
                MergeButtonClickEvent();
        }

        private void SplitCellsButton_Click(object sender, EventArgs e)
        {
            if (SplitButtonClickEvent != null)
                SplitButtonClickEvent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (GenerateButtonClickEvent != null)
                GenerateButtonClickEvent();           
        }

        public void EnableButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Red;
            button.FlatAppearance.BorderSize = 2;
            TextAlign = button.Text[0];            
        }

        public void DisableButton(Button button)
        {
            button.FlatStyle = FlatStyle.Standard;
            button.FlatAppearance.BorderColor = System.Drawing.Color.Empty;
        }

        private void LeftAlignButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EnableButton(button);
            DisableButton(centerAlignButton);
            DisableButton(rightAlignButton);
        }

        private void CenterAlignButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EnableButton(button);
            DisableButton(leftAlignButton);
            DisableButton(rightAlignButton);
        }

        private void RightAlignButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EnableButton(button);
            DisableButton(centerAlignButton);
            DisableButton(leftAlignButton);
        }

        public void WrongMergeErrorMessage()
        {
            MessageBox.Show("Unable to merge cells!", "Warning!");
        }

        public void SingleMergeErrorMessage()
        {
            MessageBox.Show("Cannot merge single cell!", "Warning!");
        }

        public void MultipleSplitErrorMessage()
        {
            MessageBox.Show("Select single cell from group to split!", "Warning!");
        }
    }
}

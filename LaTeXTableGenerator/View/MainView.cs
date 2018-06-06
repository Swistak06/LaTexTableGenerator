using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTeXTableGenerator.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public int NumberOfColumns
        {
            get
            {
                return Convert.ToInt32(ColumnNumberInput.Value);
            }

            set
            {
                ColumnNumberInput.Value = value;
            }
        }

        public int NumberOfRows
        {
            get
            {
                return Convert.ToInt32(RowNumberInput.Value);
            }

            set
            {
                RowNumberInput.Value = value;
            }
        }

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

        public event Action CreateTableButtonClickEvent;


        public void PlaceFormInCenter()
        {
            CenterToScreen();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            if(CreateTableButton != null)
            {
                CreateTableButtonClickEvent();
            }
        }
    }
}

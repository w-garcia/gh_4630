using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_PegPuzzle
{
    public partial class MainControl : UserControl
    {

        #region Private

        PegPuzzle _pegPuzzle = null;

        private void OnClickGenerate(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(_nudNValue.Value);

            _pegPuzzle = new PegPuzzle(n);
            DisplayPuzzle(_pegPuzzle);
            
        }

        private void OnClickChooseStart(object sender, EventArgs e)
        {
   
        }

        private void OnClickSearch(object sender, EventArgs e)
        {
            DFS.Search(_pegPuzzle);
        }

        private void DisplayPuzzle(PegPuzzle pegPuzzle)
        {
            double rows = _pegPuzzle.NValue;
            double columns = (_pegPuzzle.NValue * 2) - 1;

            _tblPegBoard.RowCount = (int)rows;
            _tblPegBoard.ColumnCount = (int)columns;

            int centerColumn = Convert.ToInt32(Math.Ceiling(columns/2));

            for (int i = 1; i <= rows; i++)
            {
                // i will also denote how many pegs to place this level
                int pegsToPlace = i;

                if (i % 2 != 0) // add center peg
                {
                    PlacePeg(centerColumn, i);
                    pegsToPlace--;
                }

                int rightPegsToPlace = pegsToPlace / 2;
                int leftPegsToPlace = rightPegsToPlace;

                // add pegs to right side every 2 columns
                for (int j = centerColumn+1; j < columns; j+=2)
                {
                    if (rightPegsToPlace > 0)
                    {
                        PlacePeg(j, i);
                        rightPegsToPlace--;
                    }
                }

                // add pegs to left side every 2 columns
                for (int j = centerColumn-1; j > 0; j -= 2)
                {
                    if (leftPegsToPlace > 0)
                    {
                        PlacePeg(j, i);
                        leftPegsToPlace--;
                    }
                }
                    
            }


        }

        private void PlacePeg(int column, int row)
        {
            RoundButton pegButton = new RoundButton();
            pegButton.Height = 30;
            pegButton.Width = 30;
            pegButton.Click += OnClickPeg;

            pegButton.BackColor = Color.DarkRed;

            _tblPegBoard.Controls.Add(pegButton, column, row);
        }

        private void OnClickPeg(object sender, EventArgs e)
        {

        }

        #endregion 

        #region Event Handlers



        #endregion 

        #region Public Access

        /// <summary>
        /// 
        /// </summary>
        public MainControl()
        {
            InitializeComponent();
        }

        #endregion 


    }
}

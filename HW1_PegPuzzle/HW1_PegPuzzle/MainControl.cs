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
            foreach (Control peg in _tblPegBoard.Controls)
            {
                peg.Enabled = true;
            }
        }


        private void OnClickChooseGoal(object sender, EventArgs e)
        {
            foreach (Control peg in _tblPegBoard.Controls)
            {
                peg.Enabled = true;
                peg.BackColor = Color.White;
            }
        }

        private void OnClickSearch(object sender, EventArgs e)
        {
            SetPuzzleState(_pegPuzzle.Board);

            List<GraphNode<Dictionary<KeyValuePair<int, int>, int>>> solution = DFS.Search(_pegPuzzle);

            if (solution != null)
                SetBoardToState(solution.ElementAt(solution.Count - 1).Value);
        }

        private void DisplayPuzzle(PegPuzzle pegPuzzle)
        {
            double rows = _pegPuzzle.NValue;
            double columns = (_pegPuzzle.NValue * 2) - 1;

            _tblPegBoard.RowCount = (int)rows;
            _tblPegBoard.ColumnCount = (int)columns;

            int centerColumn = Convert.ToInt32(Math.Ceiling(columns/2)) - 1;

            for (int i = 0; i < rows; i++)
            {
                // keep track of what order pegs are placed in. 
                Dictionary<int, KeyValuePair<int, int>> pegInsertionDictionary = new Dictionary<int, KeyValuePair<int, int>>();
                int pegInsertionKey = 1;

                // i will also denote how many pegs to place this level
                int pegsToPlace = i + 1;

                if (i % 2 == 0) // add center peg
                {
                    pegsToPlace--;
                    pegInsertionDictionary.Add(pegInsertionKey++, new KeyValuePair<int,int>(i, centerColumn));
                }

                int rightPegsToPlace = pegsToPlace / 2;
                int leftPegsToPlace = rightPegsToPlace;

                // add pegs to right side every 2 columns
                for (int j = centerColumn + 1; j < columns; j+=2)
                {
                    if (i % 2 == 0 && j == centerColumn + 1) j++; //shift over to the right since we added to center
                    if (rightPegsToPlace > 0)
                    {
                        rightPegsToPlace--;
                        pegInsertionDictionary.Add(pegInsertionKey++, new KeyValuePair<int, int>(i, j));
                    }
                }

                // add pegs to left side every 2 columns
                for (int j = centerColumn-1; j >= 0; j -= 2)
                {
                    if (i % 2 == 0 && j == centerColumn - 1) j--; //shift over to the left since we added to center
                    if (leftPegsToPlace > 0)
                    {
                        leftPegsToPlace--;
                        pegInsertionDictionary.Add(pegInsertionKey++, new KeyValuePair<int, int>(i, j));
                    }
                }

                // order will matter later when we assign names to the pegs, so order from lowest to highest column
                IEnumerable<KeyValuePair<int, KeyValuePair<int, int>>> query = pegInsertionDictionary.OrderBy(kvp => kvp.Value.Value);

                foreach (KeyValuePair<int, KeyValuePair<int, int>> kvp in query)
                {
                    PlacePeg(kvp.Value.Value, kvp.Value.Key);
                }
            }

            AssignNamesToPegs();
        }

        private void AssignNamesToPegs()
        {
            int textVal = 1;
            foreach (Control peg in _tblPegBoard.Controls)
            {
                peg.Enabled = true;
                peg.Text = Convert.ToString(textVal++);
            }
        }

        private void PlacePeg(int column, int row)
        {
            RoundButton pegButton = new RoundButton();
            pegButton.Height = 30;
            pegButton.Width = 30;
            pegButton.Click += OnClickPeg;
            pegButton.Enabled = false;
            pegButton.Tag = new KeyValuePair<int, int>(column, row);

            pegButton.BackColor = Color.DarkRed;

            _tblPegBoard.Controls.Add(pegButton, column, row);
        }

        private void OnClickPeg(object sender, EventArgs e)
        {
            RoundButton clickedPeg = (RoundButton)sender;
            if (clickedPeg.BackColor == Color.DarkRed)
            {
                // we are setting initial state
                clickedPeg.BackColor = Color.White;
                SetPuzzleState(_pegPuzzle.Start);
            }
            else if (clickedPeg.BackColor == Color.White)
            {
                // we are setting goal state
                clickedPeg.BackColor = Color.DarkRed;
                SetPuzzleState(_pegPuzzle.Goal);
            }

            SetBoardToState(_pegPuzzle.Start);
        }

        private void SetPuzzleState(Dictionary<KeyValuePair<int, int>, int> state)
        {
            state.Clear();
            foreach (Control peg in _tblPegBoard.Controls)
            {
                int pegPlaced = Convert.ToInt16(Object.Equals(peg.BackColor, Color.DarkRed));

                state.Add((KeyValuePair<int,int>)peg.Tag, pegPlaced);
            }
        }

        private void SetBoardToState(Dictionary<KeyValuePair<int, int>, int> state)
        {
            for (int i = 1; i <= _tblPegBoard.Controls.Count; i++)
            {
                Control currentPeg = _tblPegBoard.Controls[i - 1];
                currentPeg.Enabled = false;
                KeyValuePair<int, int> coordinates = (KeyValuePair<int, int>)currentPeg.Tag;

                if (state[coordinates] > 0) currentPeg.BackColor = Color.DarkRed;
                else currentPeg.BackColor = Color.White;
            }
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

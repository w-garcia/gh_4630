using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW1_PegPuzzle
{
    class PegPuzzle
    {
        #region Private

        private Graph<Dictionary<int, bool>> _movesGraph;
        private Dictionary<int, bool> _currentBoard = new Dictionary<int, bool>();
        private Dictionary<int, bool> _startState = new Dictionary<int, bool>();
        private Dictionary<int, bool> _goalState = new Dictionary<int, bool>();
        private int _nValue = 0;

        #endregion

        #region Public

        public int NValue
        {
            get { return _nValue; }
        }

        public Dictionary<int, bool> Board
        {
            get { return _currentBoard;  }
            set { _currentBoard = value; }
        }

        public Dictionary<int, bool> Start
        {
            get { return _startState; }
            set { _startState = value; }
        }

        public Dictionary<int, bool> Goal
        {
            get { return _goalState; }
            set { _goalState = value; }
        }

        public PegPuzzle(int n)
        {
            _nValue = n;
            _movesGraph = new Graph<Dictionary<int, bool>>();
            int pegs = 1;
            for(int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    _currentBoard.Add(pegs++, true);
                }
            }

        }

        #endregion


    }
}

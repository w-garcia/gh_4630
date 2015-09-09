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

        private Graph<Dictionary<KeyValuePair<int, int>, int>> _movesGraph;
        private Dictionary<KeyValuePair<int, int>, int> _currentBoard = new Dictionary<KeyValuePair<int, int>, int>();
        private Dictionary<KeyValuePair<int, int>, int> _startState = new Dictionary<KeyValuePair<int, int>, int>();
        private Dictionary<KeyValuePair<int, int>, int> _goalState = new Dictionary<KeyValuePair<int, int>, int>();
        private int _nValue = 0;

        #endregion

        #region Public

        public int NValue
        {
            get { return _nValue; }
        }

        public Dictionary<KeyValuePair<int, int>, int> Board
        {
            get { return _currentBoard;  }
            set { _currentBoard = value; }
        }

        public Dictionary<KeyValuePair<int, int>, int> Start
        {
            get { return _startState; }
            set { _startState = value; }
        }

        public Dictionary<KeyValuePair<int, int>, int> Goal
        {
            get { return _goalState; }
            set { _goalState = value; }
        }

        public Graph<Dictionary<KeyValuePair<int, int>, int>> Moves
        {
            get { return _movesGraph; }
            set { _movesGraph = value; }
        }

        public PegPuzzle(int n)
        {
            _nValue = n;
            _movesGraph = new Graph<Dictionary<KeyValuePair<int, int>, int>>();
        }

        public void GenerateGraph()
        {
            GraphNode<Dictionary<KeyValuePair<int, int>, int>> currentMove = new GraphNode<Dictionary<KeyValuePair<int, int>, int>>(_currentBoard);
            _movesGraph.AddNode(currentMove);

            bool foundSolution = false;

            while (!foundSolution)
            {
                if (currentMove.Value == _goalState)
                {

                    foundSolution = true;
                }

                var emptyPegsQuery =
                    from peg in currentMove.Value
                    where peg.Value == 0
                    select peg;

                foreach(var emptyPeg in emptyPegsQuery)
                {
                    // 6 possible moves, check each peg for no vacancy
                    var leftUpPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key - 2, emptyPeg.Key.Value - 2);
                    var leftDownPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key - 2, emptyPeg.Key.Value + 2);
                    var leftPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key - 4, emptyPeg.Key.Value);
                    var rightUpPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key + 2, emptyPeg.Key.Value - 2);
                    var rightDownPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key + 2, emptyPeg.Key.Value + 2);
                    var rightPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key + 4, emptyPeg.Key.Value);



                }

                

            }

        }

        #endregion


    }
}

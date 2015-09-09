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

        public void GenerateGraph(GraphNode<Dictionary<KeyValuePair<int, int>, int>> currentMove)
        {
            var emptyPegsQuery =
                from peg in currentMove.Value
                where peg.Value == 0
                select peg;

            foreach(var emptyPeg in emptyPegsQuery)
            {
                var currentEmptyPeg = emptyPeg.Key;
                // 6 possible moves, check each peg for no vacancy
                var leftUpPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key - 2, emptyPeg.Key.Value - 2);
                var leftDownPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key - 2, emptyPeg.Key.Value + 2);
                var leftPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key - 4, emptyPeg.Key.Value);
                var rightUpPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key + 2, emptyPeg.Key.Value - 2);
                var rightDownPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key + 2, emptyPeg.Key.Value + 2);
                var rightPeg = new KeyValuePair<int, int>(emptyPeg.Key.Key + 4, emptyPeg.Key.Value);

                int pegInPlace;
                if (currentMove.Value.TryGetValue(leftUpPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(emptyPeg.Key.Key - 1, emptyPeg.Key.Value - 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(leftDownPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(emptyPeg.Key.Key - 1, emptyPeg.Key.Value + 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(leftPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(emptyPeg.Key.Key - 2, emptyPeg.Key.Value);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(rightUpPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(emptyPeg.Key.Key + 1, emptyPeg.Key.Value - 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(rightDownPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(emptyPeg.Key.Key + 1, emptyPeg.Key.Value + 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(rightPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(emptyPeg.Key.Key + 2, emptyPeg.Key.Value);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
            }
        }

        private void AddNextMove(GraphNode<Dictionary<KeyValuePair<int, int>, int>> currentMove, ref KeyValuePair<int, int> currentEmptyPeg, ref KeyValuePair<int, int> leftUpPeg, ref KeyValuePair<int, int> adjacentPegToReplace)
        {
            var newNextMove = new GraphNode<Dictionary<KeyValuePair<int, int>, int>>(currentMove.Value);
            // move the peg to our empty slot
            newNextMove.Value[adjacentPegToReplace] = 0;
            newNextMove.Value[leftUpPeg] = 0;
            newNextMove.Value[currentEmptyPeg] = 1;

            newNextMove.Parent = currentMove;
            _movesGraph.AddNode(newNextMove);
            _movesGraph.AddDirectedEdge(currentMove, newNextMove);
        }

        #endregion


    }
}

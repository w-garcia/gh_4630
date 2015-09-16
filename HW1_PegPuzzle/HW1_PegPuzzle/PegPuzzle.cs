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
            Dictionary<KeyValuePair<int, int>, int> currentBoard = new Dictionary<KeyValuePair<int, int>, int>(currentMove.Value);

            var emptyPegsQuery =
                from peg in currentBoard
                where peg.Value == 0
                select peg;

            for (int i = 0; i < emptyPegsQuery.Count(); i++)
            {
                var currentEmptyPeg = emptyPegsQuery.ElementAt(i).Key;
                // 6 possible moves, check each peg for no vacancy
                var leftUpPeg =     new KeyValuePair<int, int>(currentEmptyPeg.Key - 2, currentEmptyPeg.Value - 2);
                var leftDownPeg =   new KeyValuePair<int, int>(currentEmptyPeg.Key - 2, currentEmptyPeg.Value + 2);
                var leftPeg =       new KeyValuePair<int, int>(currentEmptyPeg.Key - 4, currentEmptyPeg.Value);
                var rightUpPeg =    new KeyValuePair<int, int>(currentEmptyPeg.Key + 2, currentEmptyPeg.Value - 2);
                var rightDownPeg =  new KeyValuePair<int, int>(currentEmptyPeg.Key + 2, currentEmptyPeg.Value + 2);
                var rightPeg =      new KeyValuePair<int, int>(currentEmptyPeg.Key + 4, currentEmptyPeg.Value);

                int pegInPlace;
                if (currentMove.Value.TryGetValue(leftUpPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(currentEmptyPeg.Key - 1, currentEmptyPeg.Value - 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(leftDownPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(currentEmptyPeg.Key - 1, currentEmptyPeg.Value + 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftDownPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(leftPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(currentEmptyPeg.Key - 2, currentEmptyPeg.Value);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref leftPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(rightUpPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(currentEmptyPeg.Key + 1, currentEmptyPeg.Value - 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref rightUpPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(rightDownPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(currentEmptyPeg.Key + 1, currentEmptyPeg.Value + 1);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref rightDownPeg, ref adjacentPegToReplace);
                    }
                }
                if (currentMove.Value.TryGetValue(rightPeg, out pegInPlace))
                {
                    var adjacentPegToReplace = new KeyValuePair<int, int>(currentEmptyPeg.Key + 2, currentEmptyPeg.Value);
                    if (currentMove.Value[adjacentPegToReplace] == 1 && pegInPlace == 1)
                    {
                        AddNextMove(currentMove, ref currentEmptyPeg, ref rightPeg, ref adjacentPegToReplace);
                    }
                }
            }
        }

        private void AddNextMove(GraphNode<Dictionary<KeyValuePair<int, int>, int>> currentMove, ref KeyValuePair<int, int> currentEmptyPeg, ref KeyValuePair<int, int> pegMovingToEmpty, ref KeyValuePair<int, int> adjacentPegToReplace)
        {
            var boardCopy = new Dictionary<KeyValuePair<int, int>, int>(currentMove.Value);
            var newNextMove = new GraphNode<Dictionary<KeyValuePair<int, int>, int>>(boardCopy);
            // move the peg to our empty slot
            newNextMove.Value[adjacentPegToReplace] = 0;
            newNextMove.Value[pegMovingToEmpty] = 0;
            newNextMove.Value[currentEmptyPeg] = 1;
            newNextMove.Neighbors = new GraphNodeList<Dictionary<KeyValuePair<int, int>, int>>();

            newNextMove.Parent = currentMove;
            _movesGraph.AddNode(newNextMove);
            _movesGraph.AddDirectedEdge(currentMove, newNextMove);
        }

        #endregion


    }
}

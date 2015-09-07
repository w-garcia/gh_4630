using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    static class DFS
    {
        private bool _foundSolution = false;

        public void Search(PegPuzzle pegPuzzle)
        {
            Stack<GraphNode<Dictionary<int, bool>>> stack = new Stack<GraphNode<Dictionary<int, bool>>>(); //filo

            Dictionary<int, bool> currentState = pegPuzzle.Board;
            Dictionary<int, bool> goalState = pegPuzzle.Goal;

            Graph<Dictionary<int, bool>> moves = pegPuzzle.Moves;

            stack.Push(moves.Nodes.Root());
            while (stack.Count != 0)
            {
                GraphNode<Dictionary<int, bool>> currentNode = stack.Pop();

                for (int i = 0; i < currentNode.Neighbors.Count; i++)
                {
                    stack.Push(currentNode.Neighbors.ElementAt(i));
                    currentNode.Neighbors.ElementAt(i).Parent = currentNode;
                }

                if (currentNode.Value == goalState)
                {
                    stack.Clear();
                    _foundSolution = true;
                                        
                }
            }


        }
    }
}

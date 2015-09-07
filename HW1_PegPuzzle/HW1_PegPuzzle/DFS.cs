using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    static class DFS
    {

        static public List<GraphNode<Dictionary<int, bool>>> Search(PegPuzzle pegPuzzle)
        {
            Stack<GraphNode<Dictionary<int, bool>>> stack = new Stack<GraphNode<Dictionary<int, bool>>>(); //filo

            Dictionary<int, bool> currentState = pegPuzzle.Board;
            Dictionary<int, bool> goalState = pegPuzzle.Goal;

            Graph<Dictionary<int, bool>> moves = pegPuzzle.Moves;

            stack.Push(moves.Nodes.Root());
            while (stack.Count != 0)
            {
                GraphNode<Dictionary<int, bool>> currentNode = stack.Pop();

                if (currentNode == null) return null;

                for (int i = 0; i < currentNode.Neighbors.Count; i++)
                {
                    stack.Push(currentNode.Neighbors.ElementAt(i));
                    currentNode.Neighbors.ElementAt(i).Parent = currentNode;
                }

                if (currentNode.Value == goalState)
                {
                    stack.Clear();

                    List<GraphNode<Dictionary<int, bool>>> solutionList = new List<GraphNode<Dictionary<int, bool>>>();

                    while (currentNode.Parent != null)
                    {
                        solutionList.Add(currentNode);
                        currentNode = currentNode.Parent;
                    }

                    return solutionList;
                }
            }

            return null;


        }
    }
}

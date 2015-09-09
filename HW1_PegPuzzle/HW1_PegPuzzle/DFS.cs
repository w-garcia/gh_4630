using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    static class DFS
    {

        static public List<GraphNode<Dictionary<KeyValuePair<int, int>, int>>> Search(PegPuzzle pegPuzzle)
        {
            Stack<GraphNode<Dictionary<KeyValuePair<int, int>, int>>> stack = new Stack<GraphNode<Dictionary<KeyValuePair<int, int>, int>>>(); //filo

            Dictionary<KeyValuePair<int, int>, int> rootState = pegPuzzle.Board;
            Dictionary<KeyValuePair<int, int>, int> goalState = pegPuzzle.Goal;

            Graph<Dictionary<KeyValuePair<int, int>, int>> moves = pegPuzzle.Moves;

            var rootNode = new GraphNode<Dictionary<KeyValuePair<int,int>, int>>(rootState);
            rootNode.Neighbors = new GraphNodeList<Dictionary<KeyValuePair<int, int>, int>>();
            moves.Nodes.Add(rootNode);

            stack.Push(moves.Nodes.Root());

            while (stack.Count != 0)
            {
                GraphNode<Dictionary<KeyValuePair<int, int>, int>> currentNode = stack.Pop();

                pegPuzzle.GenerateGraph(currentNode);

                if (currentNode == null || currentNode.Neighbors == null) return null;

                for (int i = 0; i < currentNode.Neighbors.Count; i++)
                {
                    stack.Push(currentNode.Neighbors.ElementAt(i));
                    currentNode.Neighbors.ElementAt(i).Parent = currentNode;
                }

                if (currentNode.Value == goalState)
                {
                    stack.Clear();

                    List<GraphNode<Dictionary<KeyValuePair<int, int>, int>>> solutionList = new List<GraphNode<Dictionary<KeyValuePair<int, int>, int>>>();

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    static class DFS
    {
        public static bool DictionaryEqual<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second)
        {
            return first.DictionaryEqual(second, null);
        }

        public static bool DictionaryEqual<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second, IEqualityComparer<TValue> valueComparer)
        {
            if (first == second) return true;
            if ((first == null) || (second == null)) return false;
            if (first.Count != second.Count) return false;

            valueComparer = valueComparer ?? EqualityComparer<TValue>.Default;

            foreach (var kvp in first)
            {
                TValue secondValue;
                if (!second.TryGetValue(kvp.Key, out secondValue)) return false;
                if (!valueComparer.Equals(kvp.Value, secondValue)) return false;
            }
            return true;
        }

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

                bool isGoalState = currentNode.Value.DictionaryEqual(goalState);

                if (isGoalState)
                {
                    stack.Clear();

                    List<GraphNode<Dictionary<KeyValuePair<int, int>, int>>> solutionList = new List<GraphNode<Dictionary<KeyValuePair<int, int>, int>>>();

                    while (currentNode.Parent != null)
                    {
                        solutionList.Add(currentNode);
                        currentNode = currentNode.Parent;
                    }
                    solutionList.Add(pegPuzzle.Moves.Nodes.Root());
                    return solutionList;
                }

                pegPuzzle.GenerateGraph(currentNode);

                if (currentNode == null || currentNode.Neighbors == null) return null;

                for (int i = 0; i < currentNode.Neighbors.Count; i++)
                {
                    stack.Push(currentNode.Neighbors.ElementAt(i));
                    currentNode.Neighbors.ElementAt(i).Parent = currentNode;
                }


            }

            return null;


        }
    }
}

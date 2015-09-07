using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    public class Graph<T> 
    {
        private GraphNodeList<T> _nodeList;

        public Graph() : this(null) {}
        public Graph(GraphNodeList<T> nodeSet)
        {
            if (nodeSet == null) _nodeList = new GraphNodeList<T>();
            else _nodeList = nodeSet;
        }

        public void AddNode(GraphNode<T> node)
        {
            _nodeList.Add(node);
        }

        public void AddNode(T value)
        {
            _nodeList.Add(new GraphNode<T>(value));
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to)
        {
            from.Neighbors.Add(to);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to)
        {
            from.Neighbors.Add(to);

            to.Neighbors.Add(from);
        }

        public bool Contains(T value)
        {
            return _nodeList.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            // first remove the node from the nodeset
            GraphNode<T> nodeToRemove = (GraphNode<T>)_nodeList.FindByValue(value);
            if (nodeToRemove == null)
                return false;

            _nodeList.Remove(nodeToRemove);

            foreach (GraphNode<T> node in _nodeList)
            {
                int index = node.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    node.Neighbors.RemoveAt(index);
                }
            }

            return true;
        }

        public GraphNodeList<T> Nodes
        {
            get { return _nodeList; }
        }

        public int Count
        {
            get { return _nodeList.Count; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    public class Graph<T> : IEnumerable<T>
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

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to)
        {
            
        }
    }
}

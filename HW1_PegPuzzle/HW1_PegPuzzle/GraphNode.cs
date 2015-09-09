using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PegPuzzle
{
    public class GraphNode<T>
    {
        private T _data;
        private GraphNodeList<T> _neighbors;
        private GraphNode<T> _parent;

        public GraphNode() {}
        public GraphNode(T data) : this(data, null) {}
        public GraphNode(T data, GraphNodeList<T> neighbors)
        {
            _data = data;
            _neighbors = neighbors;
        }

        public T Value
        {
            get { return _data; }
            set { _data = value; }
        }

        public GraphNodeList<T> Neighbors
        {
            get { return _neighbors; }
            set { _neighbors = value; }
        }

        public GraphNode<T> Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

    }
}

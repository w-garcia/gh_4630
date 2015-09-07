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

        private Graph<int> _movesGraph;
        private Dictionary<int, bool> _board = new Dictionary<int, bool>();
        private int _nValue = 0;

        #endregion

        #region Public

        public int NValue
        {
            get { return _nValue; }
        }

        public Dictionary<int, bool> Board
        {
            get { return _board; }
        }
        
        public PegPuzzle(int n)
        {
            _nValue = n;
            _movesGraph = new Graph<int>();
            int pegs = 1;
            for(int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    _board.Add(pegs++, true);
                }
            }

        }

        #endregion


    }
}

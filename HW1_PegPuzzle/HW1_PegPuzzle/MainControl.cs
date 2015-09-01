using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_PegPuzzle
{
    public partial class MainControl : UserControl
    {

        #region Private

        PegPuzzle pegPuzzle = null;

        private void OnClickGenerate(object sender, EventArgs e)
        {
            pegPuzzle = new PegPuzzle();
        }

        private void OnClickChooseStart(object sender, EventArgs e)
        {

        }

        private void OnClickSearch(object sender, EventArgs e)
        {
            DFS.Search(pegPuzzle);
        }

        #endregion 

        #region Event Handlers



        #endregion 

        #region Public Access

        /// <summary>
        /// 
        /// </summary>
        public MainControl()
        {
            InitializeComponent();
        }

        #endregion 


    }
}

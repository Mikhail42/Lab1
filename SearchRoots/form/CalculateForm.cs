using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject.SearchRoots
{
    internal partial class SearchRootsForm : Form
    {
        public SearchRootsForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var intFT = intervalFromText.Text;
            var intTT = intervalToText.Text;
        }
    }
}

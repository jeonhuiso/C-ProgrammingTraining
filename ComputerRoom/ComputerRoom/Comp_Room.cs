using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRoom
{
    public partial class Comp_Room : Form
    {
        windows_bg wbg = new windows_bg();
        public Comp_Room()
        {
            InitializeComponent();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            wbg.ShowDialog();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        public delegate void CompClear(string n);
        public event CompClear ComClearEvent;
        public windows_bg wbg = new windows_bg();
        
        public Comp_Room()
        {
            InitializeComponent();
        }
        void ComClear() {
            ComClearEvent("computer");
        }
        private void btnComputer_Click(object sender, EventArgs e)
        {
            wbg.ComClearEvent += new windows_bg.CompClear(ComClear);
            wbg.ShowDialog();
            
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

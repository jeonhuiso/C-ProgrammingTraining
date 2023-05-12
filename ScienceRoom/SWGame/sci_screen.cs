using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWGame
{
    public partial class sci_screen : Form
    {
        public sci_screen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string msg;
            string code = textBox1.Text;

            if (code == "f7d11913")
                msg = "normal";

            else if (code == "ffd11t13")
                msg = "hidden";

            else
                msg = "wrong";
        }
    }
}

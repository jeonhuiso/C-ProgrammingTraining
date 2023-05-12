using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageLibrary
{
    public partial class StageMain : Form
    {
        public StageMain()
        {
            InitializeComponent();
        }
        public delegate void Level1Show();
        public event Level1Show Level1ShowEvent;


        private void button1_Click(object sender, EventArgs e)
        {
            Level1ShowEvent();
        }

        private void StageMain_Load(object sender, EventArgs e)
        {

        }
    }
}

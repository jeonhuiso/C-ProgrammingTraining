using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
namespace EscapeFromHighschool
{
    public partial class StageMain : Form
    {
        public StageMain()
        {
            InitializeComponent();
        }
        public delegate void Level1Show();
        public event Level1Show Level1ShowEvent;

        public delegate void Level2Show();
        public event Level2Show Level2ShowEvent;

        public delegate void contextShow(string filename, string obj);
        public event contextShow contextShowEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            Level1ShowEvent();

        }

        private void StageMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level2ShowEvent();
        }
    }
}

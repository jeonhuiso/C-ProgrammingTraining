using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auditorium
{
    public partial class auditorium : Form
    {
        public auditorium()
        {
            InitializeComponent();
        }
        
        private void maze_no_start_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maze_Start_Click(object sender, EventArgs e)
        {
            maze maze_mad = new maze();
            maze_mad.Show();
            //maze_mad.ShowDialog();
            maze_mad.FormClosed += new FormClosedEventHandler(auditorium_room_exit);
            this.Enabled = false;
        }

        private void auditorium_room_exit(object sender, EventArgs e)
        {
            this.Enabled = true;
            this.Close();
        }
    }
}

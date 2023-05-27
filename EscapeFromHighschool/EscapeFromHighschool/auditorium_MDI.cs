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
    public partial class auditorium_MDI : Form
    {
        Context con;
        auditorium aud;
        public auditorium_MDI()
        {
            InitializeComponent();
            con = new Context();
            con.Show();
            con.MdiParent = this;
            con.Location = new System.Drawing.Point(0, 400);

            aud = new auditorium(con);
            aud.MdiParent = this;
            aud.Show();
            aud.Location = new System.Drawing.Point(0, 0);
            aud.FormClosing += new FormClosingEventHandler(close_maze);

        }

        private void close_maze(object sender, EventArgs e) // 퍼즐 종료시 멈췄던 시간 다시 돌림
        {
            this.Close();
            con.Close();
        }

        private void auditorium_MDI_MouseClick(object sender, MouseEventArgs e)
        {
            this.SendToBack();
        }

        private void auditorium_MDI_Load(object sender, EventArgs e)
        {
        }
    }
}

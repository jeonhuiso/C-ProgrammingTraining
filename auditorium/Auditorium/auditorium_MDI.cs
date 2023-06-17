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
        public delegate void AuditoriumClear(string n);
        public event AuditoriumClear AuditoriumClearEvent;
        Context con; // 대화창
        auditorium aud; // maze 게임 들어가기전 문 선택
        public auditorium_MDI() // auditorium mdi
        {
            InitializeComponent();
            con = new Context();
            con.Show();
            con.MdiParent = this;
            con.Location = new System.Drawing.Point(0, 600);

            aud = new auditorium(con);
            aud.MdiParent = this;
            aud.Show();
            aud.Location = new System.Drawing.Point(0, 0);
            aud.FormClosing += new FormClosingEventHandler(close_maze);
            aud.AuditoriumClearEvent += new auditorium.AuditoriumClear(AuditoriumClearME) ;

        }
        void AuditoriumClearME()
        {
            AuditoriumClearEvent("auditorium");
        }
        private void close_maze(object sender, EventArgs e) // 퍼즐 종료시 멈췄던 시간 다시 돌림
        {
            this.Dispose();
            con.Dispose();
        }

        private void auditorium_MDI_MouseClick(object sender, MouseEventArgs e)
        {
            this.SendToBack();
        }
    }
}

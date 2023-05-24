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
        Context con;

        public auditorium(Context co)
        {
            InitializeComponent();
            con = co;
        }

        private void maze_no_start_Click(object sender, EventArgs e) // 처음 화면의 미로에 들어가지 않을 때 버튼
        {
            this.Close();
        }

        private void maze_Start_Click(object sender, EventArgs e) // 처음 화면의 미로에 들어갈 때 버튼
        {
            pic_bring_first(pic_maze_game);
            txt_bring_first(txt_game_ex);
            visible_game_ex();
        }

        private void btn_maze_explain_Click(object sender, EventArgs e) // 게임 시작 버튼, 미로 탈출을 시작함
        {
            con.TopMost = true;
            maze maze_mad = new maze(con);
            maze_mad.Show();
            maze_mad.Location = new System.Drawing.Point(this.MdiParent.Left, this.MdiParent.Top);
            maze_mad.FormClosed += new FormClosedEventHandler(auditorium_room_exit);
            
            this.Enabled = false;
        }


        private void auditorium_room_exit(object sender, EventArgs e) // 미로 탈출이 끝나면 해당 폼 종료
        {
            this.Enabled = true;
            this.Close();
        }


        private void visible_game_ex() // 게임 설명을 위한 TextBox, PictureBox의 화면 전환
        {
            txt_bring_first(txt_game_ex_1);
            txt_bring_first(txt_game_ex_2);
            txt_bring_first(txt_game_ex_3);
            pic_bring_first(pic_game_ex_1_1);
            pic_bring_first(pic_game_ex_1_2);
            pic_bring_first(pic_game_ex_2_1);
            btn_bring_first(btn_maze_explain);
        }

        private void pic_bring_first(PictureBox pic) // PictureBox를 제일 앞으로 가져오고, 보이게 만듦
        {
            pic.Visible = true;
            pic.BringToFront();
        }

        private void txt_bring_first(TextBox txt) // TextBox를 제일 앞으로 가져오고, 보이게 만듦
        {
            txt.Visible = true;
            txt.BringToFront();
        }

        private void btn_bring_first(Button btn) // Button을 제일 앞으로 가져오고, 보이게 만듦
        {
            btn.Visible = true;
            btn.BringToFront();
        }
    }
}

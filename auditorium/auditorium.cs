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
        private int game_ex_num = 0; // 화면 페이지를 표시하기 위한 정수

        public auditorium()
        {
            InitializeComponent();
        }

        private void maze_no_start_Click(object sender, EventArgs e) // 처음 화면의 미로에 들어가지 않을 때 버튼
        {
            this.Close();
        }

        private void maze_Start_Click(object sender, EventArgs e) // 처음 화면의 미로에 들어갈 때 버튼
        {
            btn_left_ex.Enabled = false;
            pic_bring_first(pic_maze_game);
            txt_bring_first(txt_game_ex);
            btn_bring_first(btn_left_ex);
            btn_bring_first(btn_right_ex);
            btn_bring_first(btn_maze_explain);
            visible_game_ex();
        }

        private void btn_maze_explain_Click(object sender, EventArgs e) // 게임 시작 버튼, 미로 탈출을 시작함
        {
            maze maze_mad = new maze();
            maze_mad.Show();
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
            txt_game_ex_1_1.Visible = false;
            txt_game_ex_1_2.Visible = false;
            txt_game_ex_1_3.Visible = false;
            txt_game_ex_2_1.Visible = false;
            txt_game_ex_2_2.Visible = false;
            txt_game_ex_2_3.Visible = false;
            txt_game_ex_3.Visible = false;
            pic_game_ex_1_1.Visible = false;
            pic_game_ex_1_2.Visible = false;
            pic_game_ex_1_3.Visible = false;
            pic_game_ex_2_1.Visible = false;
            pic_game_ex_2_2.Visible = false;
            pic_game_ex_2_3.Visible = false;
            pic_game_ex_3.Visible = false;

            if (game_ex_num == 0)
            {
                txt_bring_first(txt_game_ex_1_1);
                txt_bring_first(txt_game_ex_1_2);
                txt_bring_first(txt_game_ex_1_3);
                pic_bring_first(pic_game_ex_1_1);
                pic_bring_first(pic_game_ex_1_2);
                pic_bring_first(pic_game_ex_1_3);
            }
            else if (game_ex_num == 1)
            {
                txt_bring_first(txt_game_ex_2_1);
                txt_bring_first(txt_game_ex_2_2);
                txt_bring_first(txt_game_ex_2_3);
                pic_bring_first(pic_game_ex_2_1);
                pic_bring_first(pic_game_ex_2_2);
                pic_bring_first(pic_game_ex_2_3);
            }
            else if(game_ex_num == 2)
            {
                txt_bring_first(txt_game_ex_3);
                pic_bring_first(pic_game_ex_3);
            }
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

        private void btn_left_ex_Click(object sender, EventArgs e) // 오른쪽 버튼을 누르면 페이지가 움직이게 동작
        {
            if (game_ex_num > 0)
            {
                game_ex_num--;
                btn_left_right_check();
                visible_game_ex();
            }
        }

        private void btn_right_ex_Click(object sender, EventArgs e) // 왼쪽 버튼을 누르면 페이지가 움직이게 동작
        {
            if (game_ex_num < 2)
            {
                game_ex_num++;
                btn_left_right_check();
                visible_game_ex();
            }
        }

        private void btn_left_right_check() // 오른쪽 왼쪽 버튼의 활성/비활성화를 정함
        {
            if (game_ex_num == 0)
                btn_left_ex.Enabled = false;
            else
                btn_left_ex.Enabled = true;
            if (game_ex_num == 2)
                btn_right_ex.Enabled = false;
            else
                btn_right_ex.Enabled = true;
        }
    }
}

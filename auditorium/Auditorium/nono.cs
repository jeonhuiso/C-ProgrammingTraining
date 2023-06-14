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
    public partial class nono : Form
    {
        private Button[,] nono_btn; // 퍼즐을 풀때 사용하는 버튼
        private int[,] nono_check_array; // 퍼즐에 대한 정보를 저장하는 배열
        private int level = 0; // 퍼즐 단계 확인을 위한 정수
        private int s_location_x = 190; // 퍼즐의 시작 위치 x축
        private int s_location_y = 80; // 퍼즐의 시작 위치 y축
        private int game_ex_num = 0; // 게임 설명시 페이지를 확인하기 위한 정수
        int current_time; // 현재 시간

        public nono(int time)
        {
            InitializeComponent();
            nono_puzzle_init();
            btn_left_ex.Enabled = false; // 처음 시작 페이지의 왼쪽 버튼은 못누르게 방지
            current_time = time;
            nono_time.Text = ("600 / " + current_time.ToString());
            nono_game_success.Visible = false;
            fail_txt.Visible = false;
            nono_timer.Stop();
            visible_game_ex(); // 게임 설명 페이지 활성화
        }

        public void nono_puzzle_init()
        {
            nono_btn = new Button[4 + level, 4 + level]; 
            nono_check_array = new int[3 + level, 3 + level];
            make_game(4 + level); // 게임 생성
        }

        private void make_game(int size) // 랜덤을 이용해 눌러야 하는 버튼을 생성
        {
            Random rand = new Random();
            int use_size = 450 / size; // 버튼 크기 지정
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == 0) // 누르지 말아야할 버튼
                    {
                        if (i == 0 && j == 0) // 확인 버튼 생성
                        {
                            make_btn(i, j, 80, 80, s_location_x, s_location_y);
                            nono_btn[i, j].Click += new EventHandler(change_level_btn_Click);
                            nono_btn[i, j].Text = "확인";
                            nono_btn[i, j].Font = new Font("Microsoft Sans Serif", 20);
                            this.Controls.Add(nono_btn[i, j]);
                        }
                        else
                        {
                            if (j == 0) // 숫자를 기입할 버튼 생성
                            {
                                make_btn(i, j, use_size, 80, s_location_x + 80 + (i - 1) * use_size, s_location_y);
                                nono_btn[i, j].TextAlign = ContentAlignment.BottomCenter;
                                nono_btn[i, j].Enabled = false;
                                this.Controls.Add(nono_btn[i, j]);
                            }
                            else // 숫자를 기입할 버튼 생성
                            {
                                make_btn(i, j, 80, use_size, s_location_x, s_location_y + 80 + (j - 1) * use_size);
                                nono_btn[i, j].TextAlign = ContentAlignment.MiddleRight;
                                nono_btn[i, j].Enabled = false;
                                this.Controls.Add(nono_btn[i, j]);
                            }
                        }
                    }
                    else // 눌러야할 버튼
                    {
                        if (rand.Next(10) % 2 == 0) // 랜덤을 이용해 초기화
                            nono_check_array[i - 1, j - 1] = 1;
                        else
                            nono_check_array[i - 1, j - 1] = 0;
                        make_btn(i, j, use_size, use_size, s_location_x + 80 + (i - 1) * use_size, s_location_y + 80 + (j - 1) * use_size);
                        this.Controls.Add(nono_btn[i, j]);
                    }
                }
            }

            int btn_check_num = 0;
            for (int i = 1; i < size; i++) // 숫자를 넣기 위해 사용, 모든 배열을 확인해 각 줄당 몇개가 연속으로 있는지 확인
            {
                btn_check_num = 0;
                for (int j = 1; j < size; j++)
                {
                    if (nono_check_array[i - 1, j - 1] == 1)
                    {
                        btn_check_num++;
                    }
                    else
                    {
                        if (btn_check_num != 0)
                        {
                            nono_btn[i, 0].Text = (nono_btn[i, 0].Text + "\r\n" + btn_check_num).ToString(); // 제일 위에 저장
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    nono_btn[i, 0].Text = (nono_btn[i, 0].Text + "\r\n" + btn_check_num).ToString(); // 제일 위에 저장
                }

                btn_check_num = 0;
                for (int j = 1; j < size; j++)
                {
                    if (nono_check_array[j - 1, i - 1] == 1)
                    {
                        btn_check_num++;
                    }
                    else
                    {
                        if (btn_check_num != 0)
                        {
                            nono_btn[0, i].Text = (nono_btn[0, i].Text + " "  + btn_check_num).ToString(); // 제일 왼쪽에 저장
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    nono_btn[0, i].Text = (nono_btn[0, i].Text + " "  + btn_check_num).ToString(); // 제일 왼쪽에 저장
                }
            }
        }

        private void nono_btn_click(int i, int j) // 버튼을 누르면 색을 바꿈
        {
            if (i > 0 && j > 0)
            {
                if (nono_btn[i, j].BackColor == Color.WhiteSmoke)
                    nono_btn[i, j].BackColor = Color.BlueViolet;
                else
                    nono_btn[i, j].BackColor = Color.WhiteSmoke;
            }
        }

        private void make_btn(int i, int j, int size_x, int size_y, int location_x, int location_y) // 버튼을 생성
        {
            nono_btn[i, j] = new Button();
            nono_btn[i, j].Width = size_x;
            nono_btn[i, j].Height = size_y;
            nono_btn[i, j].Left = location_x;
            nono_btn[i, j].Top = location_y;
            nono_btn[i, j].BackColor = Color.WhiteSmoke;
            nono_btn[i, j].Click += (sender1, e) => nono_btn_click(i, j);
        }


        private void change_level_btn_Click(object sender, EventArgs e) // 확인 버튼 (성공했는지 확인)
        {
            if (check_complete(4 + level)) // 성공했는지 확인
            {
                for (int i = 0; i < 4 + level; i++)
                    for (int j = 0; j < 4 + level; j++)
                        this.Controls.Remove(nono_btn[i, j]);
                level++;
                if (level == 4) // 게임 성공
                {
                    pan_nono_explain.Visible = true;
                    nono_game_success.Visible = true;
                    ((maze)(this.Owner)).first_game_clear = 1;
                }
                else // 다음 단계 실행
                {
                    nono_btn = new Button[4 + level, 4 + level];
                    nono_check_array = new int[3 + level, 3 + level];
                    make_game(4 + level);
                    lbl_nono_level.Text = "Level : 4 / " + (int.Parse(lbl_nono_level.Text.Remove(0, 11)) + 1).ToString();
                }
            }
            else // 실패시
            {
                if (int.Parse(lbl_life.Text.Remove(0, 3)) == 1) // ♥가 부족하면 실행
                {
                    pan_nono_explain.Visible = true;
                    nono_game_success.Visible = true;
                    nono_game_success.Text = "game over";
                    ((maze)(this.Owner)).first_game_clear = 2;
                }
                else // ♥가 남아있으면 실행
                {
                    pan_nono_explain.Visible = true;
                    fail_txt.Visible = true;
                    lbl_life.Text = "♥ x  " + (int.Parse(lbl_life.Text.Remove(0, 3)) - 1).ToString();
                }
            }
        }

        private bool check_complete(int size) // 완벽하게 끝냈는지 확인
        {
            string compare_com_check;
            int btn_check_num = 0;
            string nono_btn_save;
            string complete_use_btn;
            for (int i = 1; i < size; i++)
            {
                compare_com_check = "";
                nono_btn_save = nono_btn[i, 0].Text;
                complete_use_btn = nono_btn_save.Replace("\r\n", ""); // 줄바꿈 제거
                complete_use_btn = complete_use_btn.Replace(" ", ""); // 스페이스 제거
                btn_check_num = 0;
                for (int j = 1; j < size; j++) // 버튼 색을 줄마다 확인 (세로 확인)
                {
                    if (nono_btn[i, j].BackColor == Color.BlueViolet)
                    {
                        btn_check_num++;
                    }
                    else
                    {
                        if (btn_check_num != 0)
                        {
                            compare_com_check = (compare_com_check + btn_check_num).ToString();
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    compare_com_check = (compare_com_check + btn_check_num).ToString();
                }
                if (!complete_use_btn.Equals(compare_com_check))
                {
                    return false;
                }

                compare_com_check = "";
                nono_btn_save = nono_btn[0, i].Text;
                complete_use_btn = nono_btn_save.Replace("\r\n", "");
                complete_use_btn = complete_use_btn.Replace(" ", "");
                btn_check_num = 0;
                for (int j = 1; j < size; j++) // 버튼 색을 줄마다 확인 (가로 확인)
                {
                    if (nono_btn[j, i].BackColor == Color.BlueViolet)
                    {
                        btn_check_num++;
                    }
                    else
                    {
                        if (btn_check_num != 0)
                        {
                            compare_com_check = (compare_com_check + btn_check_num).ToString();
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    compare_com_check = (compare_com_check + btn_check_num).ToString();
                }
                if (!complete_use_btn.Equals(compare_com_check))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_nono_explain_Click(object sender, EventArgs e) // 게임 시작 버튼
        {
            btn_left_ex.Visible = false;
            btn_right_ex.Visible = false;
            nono_game_success.Visible = false;
            btn_nono_explain.Visible = false;
            pan_nono_explain.Visible = false;
            txt_game_ex.Visible = false;
            txt_game_ex1.Visible = false;
            txt_game_ex2.Visible = false;
            txt_game_ex3.Visible = false;
            pic_game_ex_1_1.Visible = false;
            pic_game_ex_1_2.Visible = false;
            pic_game_ex_2_1.Visible = false;
            pic_game_ex_2_2.Visible = false;
            pic_game_ex_3.Visible = false;
            nono_timer.Start();
            nono_time.BringToFront();
        }

        private void btn_right_ex_Click(object sender, EventArgs e) // 퍼즐 오른쪽으로 넘기기 버튼
        {
            if (game_ex_num < 2) {
                game_ex_num++;
                btn_left_right_check();
                visible_game_ex();
            }
        }

        private void btn_left_ex_Click(object sender, EventArgs e) // 퍼즐 왼쪽으로 넘기기 버튼
        {
            if (game_ex_num > 0)
            {
                game_ex_num--;
                btn_left_right_check();
                visible_game_ex();
            }
        }

        private void visible_game_ex() // 퍼즐 설명 페이지를 구현하기 위해 사용
        {
            nono_game_success.Visible = false;
            txt_game_ex1.Visible = false;
            txt_game_ex2.Visible = false;
            txt_game_ex3.Visible = false;
            pic_game_ex_1_1.Visible = false;
            pic_game_ex_1_2.Visible = false;
            pic_game_ex_2_1.Visible = false;
            pic_game_ex_2_2.Visible = false;
            pic_game_ex_3.Visible = false;

            if (game_ex_num == 0)
            {
                txt_game_ex1.Visible = true;
                pic_game_ex_1_1.Visible = true;
                pic_game_ex_1_2.Visible = true;
            } 
            else if(game_ex_num == 1)
            {
                txt_game_ex2.Visible = true;
                pic_game_ex_2_1.Visible = true;
                pic_game_ex_2_2.Visible = true;
            } 
            else if(game_ex_num == 2)
            {
                txt_game_ex3.Visible = true;
                pic_game_ex_3.Visible = true;
            }
        }
        private void btn_left_right_check() // 버튼이 더이상 넘어가지 않게 boundary 설정
        {
            if (game_ex_num == 2)
            {
                btn_right_ex.Enabled = false;
                btn_left_ex.Enabled = true;
                btn_nono_explain.Visible = true;
                cur_explain.Visible = false;
            }
            else
            {
                cur_explain.Text = "3 / " + (game_ex_num + 1).ToString();
                cur_explain.Visible = true;
                btn_nono_explain.Visible = false;
                btn_right_ex.Enabled = true;
                btn_left_ex.Enabled = true;
                if (game_ex_num == 0)
                {
                    btn_left_ex.Enabled = false;
                }
            }
        }

        private void nono_timer_Tick(object sender, EventArgs e) // 미로 탈출의 시간을 줄이기 위한 timer
        {
            current_time++;
            nono_time.Text = ("600 / " + current_time.ToString());
            ((maze)(this.Owner)).puzzle_game_time = current_time;
            if (current_time > 600)
            {
                this.Close();
                game_exit();
            }
        }
        private void fail_txt_Click(object sender, EventArgs e) // 퍼즐을 맞추는데 실패시 발생하는 버튼
        {
            pan_nono_explain.Visible = false;
            fail_txt.Visible = false;
        }

        private void nono_game_success_Click(object sender, EventArgs e)
        {
            this.Close();
            game_exit();
        }

        private void game_exit()
        {
            for(int i = 0;  i< 4+level; i++)
            {
                for(int j = 0; j < 4+level; j++)
                {
                    this.Controls.Remove(nono_btn[i, j]);
                    nono_btn[i, j].Dispose();
                }
            }
        }
    }
}

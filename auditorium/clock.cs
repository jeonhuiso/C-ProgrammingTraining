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
    public partial class clock : Form
    {
        Button[,] user_clock; // 유저가 사용하는 시계
        Button[,] make_clock; // 퍼즐의 성공여부를 위해 사용하는 왼쪽 시계
        private int level = 0; // 단계 확인
        private int game_start_x = 43; // 왼쪽 시계의 시작위치 x
        private int game_start_y = 90; // 왼쪽 시계의 시작위치 y
        private int time_or_color = 0; // 시간과 색상을 구별
        private int game_ex_num = 0; // 게임 설명 페이지 확인
        int current_time; // 현재 시간

        public clock(int time) // 미로 탈출의 시간을 초기화
        {
            InitializeComponent();
            clock_game_init();
            btn_left_ex.Enabled = false;
            clock_timer.Stop();
            current_time = time;
            clock_time.Text = ("600 / " + current_time.ToString());
            clock_game_success.Visible = false;
            fail_txt.Visible = false;
        }

        private void clock_game_init() // 게임을 초기화
        {
            make_clock = new Button[4 + level, 4 + level];
            user_clock = new Button[4 + level, 4 + level];
            make_game(make_clock, 4 + level, 0, 0);
            make_game(user_clock, 4 + level, 260, 1);
            make_clock[0, 0].Text = "확인";
            make_clock[0, 0].Enabled = true;
            make_clock[0, 0].Click += new EventHandler(make_check_btn);
            user_clock[0, 0].Text = "시간";
            user_clock[0, 0].Click += new EventHandler(user_check_btn);
            make_clock_init(4 + level);
            visible_game_ex();
        }

        private void make_game(Button[,] clock, int num, int wid, int make_user) // make_clock = 0, user_clock = 1 으로 시계를 2개 생성
        {
            int btn_size = 250 / num;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == 0 || j == 0) // 시간, 확인일 때
                    {
                        clock[i, j] = new Button();
                        make_Button(clock, i, j, btn_size, (game_start_x + wid + i * btn_size), (game_start_y + j * btn_size)); // 버튼 생성
                        if (make_user == 0) // 왼쪽은 확인을 제외하고 모두 enable 제거
                            clock[i, j].Enabled = false;
                        else
                            if (i != 0 || j != 0)
                            user_event_setting(i, j); // 유저는 이벤트를 추가 (i,j)의 값을 넘겨주기 위해서는 함수를 이용해야함
                        this.Controls.Add(clock[i, j]);
                    }
                    else
                    {
                        clock[i, j] = new Button();
                        make_Button(clock, i, j, btn_size, (game_start_x + wid + i * btn_size), (game_start_y + j * btn_size)); // 버튼 생성
                        clock[i, j].Text = "1:00";
                        clock[i, j].Enabled = false;
                        this.Controls.Add(clock[i, j]);
                    }
                }
            }
        }

        private void user_event_setting(int i, int j) // 유저의 버튼에 이벤트를 추가
        {
            user_clock[i, j].Click += (sender1, e) => user_btn_click(i, j);
        }

        private void make_clock_init(int num) // 왼쪽 시계 초기화
        {
            Random rand = new Random();
            List<int> row = new List<int>(); // 행을 랜덤하게 추가하기 위한 장치
            List<int> col = new List<int>(); // 열을 랜덤하게 추가하기 위한 장치
            int use_remove;
            for (int i = 1; i < num; i++) // 행렬의 크기 만큼 저장
            {
                row.Add(i);
                col.Add(i);
            }
            for (int i = 1; i < num; i++) // 랜덤하게 시계를 초기화함
            {
                use_remove = rand.Next(3 * (row.Count - 1)) % row.Count;
                make_clock_add(0, rand.Next(12), row[use_remove], num); // 
                row.RemoveAt(use_remove);
                use_remove = rand.Next(3 * (col.Count - 1)) % col.Count;
                make_clock_add(1, rand.Next(12), col[use_remove], num);
                col.RemoveAt(use_remove);
            }

            List<int> color = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            row.Clear();
            col.Clear();
            int color_choice = 0;
            for (int i = 1; i < num; i++)
            {
                row.Add(i);
                col.Add(i);
            }
            for (int i = 1; i < num; i++)
            {
                use_remove = rand.Next(3 * (row.Count - 1)) % row.Count;
                color_choice = rand.Next(7 * (color.Count - 1)) % color.Count;
                make_color_add(0, row[use_remove], num, color[color_choice]);
                row.RemoveAt(use_remove);
                color.RemoveAt(color_choice);

                use_remove = rand.Next(3 * (col.Count - 1)) % col.Count;
                color_choice = rand.Next(7 * (color.Count - 1)) % color.Count;
                make_color_add(1, col[use_remove], num, color[color_choice]);
                col.RemoveAt(use_remove);
                color.RemoveAt(color_choice);
            }
        }

        private void make_color_add(int row_col, int where_row_col, int num, int color_num) // 시계의 색상을 추가함
        {
            if (row_col == 0) // 행 일때
            {
                for (int j = 1; j < num; j++)
                    clock_Backcolor_check_change(make_clock, j, where_row_col, color_num); // 왼쪽 시계의 색상 추가
                clock_Backcolor_check_change(user_clock, 0, where_row_col, color_num); // 오른쪽 시계의 버튼에 생상추가
                clock_Forecolor_check_change(user_clock, 0, where_row_col, color_num); // 이름으로 색을 구분하기 때문에 같은 색상 추가
                user_clock[0, where_row_col].Text = color_num.ToString();
            }
            else // 열 일때
            {
                for (int j = 1; j < num; j++)
                    clock_Backcolor_check_change(make_clock, where_row_col, j, color_num);
                clock_Backcolor_check_change(user_clock, where_row_col, 0, color_num);
                clock_Forecolor_check_change(user_clock, where_row_col, 0, color_num);
                user_clock[where_row_col, 0].Text = color_num.ToString();

            }
        }

        private void clock_Backcolor_check_change(Button[,] clock, int i, int j, int color_num) // 숫자에 맞게 배경색 추가
        {
            switch (color_num)
            {
                case 0:
                    clock[i, j].BackColor = Color.LightPink;
                    break;
                case 1:
                    clock[i, j].BackColor = Color.LightSalmon;
                    break;
                case 2:
                    clock[i, j].BackColor = Color.LightSkyBlue;
                    break;
                case 3:
                    clock[i, j].BackColor = Color.Violet;
                    break;
                case 4:
                    clock[i, j].BackColor = Color.Silver;
                    break;
                case 5:
                    clock[i, j].BackColor = Color.LightCyan;
                    break;
                case 6:
                    clock[i, j].BackColor = Color.Gold;
                    break;
                case 7:
                    clock[i, j].BackColor = Color.Aquamarine;
                    break;
            }
        }

        private void clock_Forecolor_check_change(Button[,] clock, int i, int j, int color_num) // 숫자에 맞게 폰트색 추가
        {
            switch (color_num)
            {
                case 0:
                    clock[i, j].ForeColor = Color.LightPink;
                    break;
                case 1:
                    clock[i, j].ForeColor = Color.LightSalmon;
                    break;
                case 2:
                    clock[i, j].ForeColor = Color.LightSkyBlue;
                    break;
                case 3:
                    clock[i, j].ForeColor = Color.Violet;
                    break;
                case 4:
                    clock[i, j].ForeColor = Color.Silver;
                    break;
                case 5:
                    clock[i, j].ForeColor = Color.LightCyan;
                    break;
                case 6:
                    clock[i, j].ForeColor = Color.Gold;
                    break;
                case 7:
                    clock[i, j].ForeColor = Color.Aquamarine;
                    break;
            }
        }

        private void make_clock_add(int row_col, int rand_num, int where_row_col, int num) // 왼쪽 시계의 숫자 변경
        {
            if (row_col == 0) // 행 : 0
                for (int j = 1; j < num; j++)
                    clock_check_change(make_clock, j, where_row_col, rand_num);
            else // 열 : 1
                for (int j = 1; j < num; j++)
                    clock_check_change(make_clock, where_row_col, j, rand_num);
        }

        private void clock_check_change(Button[,] clock, int i, int j, int sum) // sum 만큼 시계에 더해서 추가함
        {
            int origin_sum = int.Parse(clock[i, j].Text.Substring(0, clock[i, j].Text.LastIndexOf(":"))) + sum; // : 이후로는 날림
            if (origin_sum > 12) // 12:00가 넘어가면 실행
            {
                clock[i, j].Text = (origin_sum - 12 + ":00").ToString();
            }
            else
            {
                clock[i, j].Text = (origin_sum + ":00").ToString();
            }
        }

        private void make_Button(Button[,] clock, int i, int j, int size, int left, int top) // 버튼 만들기
        {
            clock[i, j].TextAlign = ContentAlignment.MiddleCenter;
            clock[i, j].Width = size;
            clock[i, j].Height = size;
            clock[i, j].Left = left;
            clock[i, j].Top = top;
        }

        private void remove_Button(int num) // 게임이 끝나면 버튼을 제거
        {
            for (int i = 0; i < num; i++)
                for (int j = 0; j < num; j++)
                {
                    this.Controls.Remove(make_clock[i, j]);
                    this.Controls.Remove(user_clock[i, j]);
                }
        }

        private void make_check_btn(object sender, EventArgs e) // 확인 버튼의 동작
        {
            if (level < 1) // 레벨이 1을 넘어가면 종료, 아니면 다음 레벨 실행
            {
                if (compelete_check()) // 왼쪽 시계와 같은지 확인
                {
                    remove_Button(4 + level);
                    level++;
                    make_clock = new Button[4 + level, 4 + level];
                    user_clock = new Button[4 + level, 4 + level];
                    make_game(make_clock, 4 + level, 0, 0);
                    make_game(user_clock, 4 + level, 260, 1);
                    make_clock[0, 0].Text = "확인";
                    make_clock[0, 0].Enabled = true;
                    make_clock[0, 0].Click += new EventHandler(make_check_btn);
                    user_clock[0, 0].Text = "시간";
                    user_clock[0, 0].Click += new EventHandler(user_check_btn);
                    time_or_color = 0;
                    make_clock_init(4 + level);
                    lbl_clock_level.Text = "Level : 2 / " + (int.Parse(lbl_clock_level.Text.Remove(0, 11)) + 1).ToString();
                }
                else // 같지 않을 때
                {
                    if (int.Parse(lbl_clock_life.Text.Remove(0, 3)) == 1) //♥가 부족하면 실행
                    {
                        pan_clock_explain.Visible = true;
                        clock_game_success.Visible = true;
                        clock_game_success.Text = "game over";
                        ((maze)(this.Owner)).second_game_clear = 2;
                    }
                    else // ♥가 남아 있으면 실행
                    {
                        pan_clock_explain.Visible = true;
                        fail_txt.Visible = true;
                        lbl_clock_life.Text = "♥ x  " + (int.Parse(lbl_clock_life.Text.Remove(0, 3)) - 1).ToString();
                    }
                }
            }
            else 
            {
                if (compelete_check()) // 성공했으면 실행
                {
                    pan_clock_explain.Visible = true;
                    clock_game_success.Visible = true;
                    clock_game_success.Text = "성공했습니다!!!";
                    ((maze)(this.Owner)).second_game_clear = 1;
                }
                else
                {
                    if (int.Parse(lbl_clock_life.Text.Remove(0, 3)) == 1) //♥가 부족하면 실행
                    {
                        pan_clock_explain.Visible = true;
                        clock_game_success.Visible = true;
                        clock_game_success.Text = "game over";
                        ((maze)(this.Owner)).second_game_clear = 2;
                    }
                    else // ♥가 남아 있으면 실행
                    {
                        pan_clock_explain.Visible = true;
                        fail_txt.Visible = true;
                        lbl_clock_life.Text = "♥ x  " + (int.Parse(lbl_clock_life.Text.Remove(0, 3)) - 1).ToString();
                    }
                }
            }
        }


        private bool compelete_check() // 두 시계가 같은지 확인
        {
            bool return_complete = true;
            for (int i = 1; i < 4 + level; i++)
                for (int j = 1; j < 4 + level; j++)
                    if (user_clock[i, j].Text != make_clock[i, j].Text || user_clock[i, j].BackColor != make_clock[i, j].BackColor)
                        return false;
            return return_complete;
        }

        private void user_check_btn(object sender, EventArgs e) // 색상과 시간 바꾸기 버튼
        {
            if (time_or_color == 0)
            {
                time_or_color = 1;
                user_clock[0, 0].Text = "색상";
            }
            else
            {
                time_or_color = 0;
                user_clock[0, 0].Text = "시간";
            }
        }

        private void user_btn_click(int i, int j) // 오른쪽 시계에서 버튼을 누르면 시간, 색상에 따라 바뀜
        {
            if (time_or_color == 0) // 시간일 때
            {
                if (i == 0)
                {
                    for (int row = 1; row < 4 + level; row++)
                    {
                        clock_check_change(user_clock, row, j, 1);
                    }
                }
                if (j == 0)
                {
                    for (int col = 1; col < 4 + level; col++)
                    {
                        clock_check_change(user_clock, i, col, 1);
                    }
                }
            }
            else // 색상일 때
            {
                if (i == 0)
                {
                    for (int row = 1; row < 4 + level; row++)
                    {
                        clock_Backcolor_check_change(user_clock, row, j, int.Parse(user_clock[0, j].Text));
                    }
                }
                if (j == 0)
                {
                    for (int col = 1; col < 4 + level; col++)
                    {
                        clock_Backcolor_check_change(user_clock, i, col, int.Parse(user_clock[i, 0].Text));
                    }
                }
            }
        }
        
        private void visible_game_ex() // 퍼즐 설명 페이지를 구현하기 위해 사용
        {
            txt_game_ex_1.Visible = false;
            txt_game_ex_12.Visible = false;
            txt_game_ex_2.Visible = false;
            txt_game_ex_3_1.Visible = false;
            txt_game_ex_3_2.Visible = false;
            txt_game_ex_4.Visible = false;
            txt_game_ex_5.Visible = false;
            pic_game_ex_1_1.Visible = false;
            pic_game_ex_1_2.Visible = false;
            pic_game_ex_2_1.Visible = false;
            pic_game_ex_2_2.Visible = false;
            pic_game_ex_3_1.Visible = false;
            pic_game_ex_3_2.Visible = false;
            pic_game_ex_4.Visible = false;
            pic_game_ex_5_1.Visible = false;
            pic_game_ex_5_2.Visible = false;

            if (game_ex_num == 0)
            {
                txt_game_ex_1.Visible = true;
                txt_game_ex_12.Visible = true;
                pic_game_ex_1_1.Visible = true;
                pic_game_ex_1_2.Visible = true;
            }
            else if (game_ex_num == 1)
            {
                txt_game_ex_12.Visible = true;
                txt_game_ex_2.Visible = true;
                pic_game_ex_2_1.Visible = true;
                pic_game_ex_2_2.Visible = true;
            }
            else if (game_ex_num == 2)
            {
                txt_game_ex_3_1.Visible = true;
                txt_game_ex_3_2.Visible = true;
                pic_game_ex_3_1.Visible = true;
                pic_game_ex_3_2.Visible = true;
            }
            else if(game_ex_num == 3)
            {
                txt_game_ex_4.Visible = true;
                pic_game_ex_4.Visible = true;
            }
            else if(game_ex_num == 4)
            {
                txt_game_ex_5.Visible = true;
                pic_game_ex_5_1.Visible = true;
                pic_game_ex_5_2.Visible = true;
            }

        }
        
        private void clock_game_success_Click(object sender, EventArgs e) // 퍼즐이 끝났을 때 사용하는 버튼
        {
            this.Close();
        }

        private void btn_left_ex_Click(object sender, EventArgs e) // 퍼즐 설명 왼쪽으로 넘기기 버튼
        {
            if (game_ex_num > 0)
            {
                game_ex_num--;
                btn_left_right_check();
                visible_game_ex();
            }
        }

        private void btn_right_ex_Click(object sender, EventArgs e) // 퍼즐 설명 오른쪽으로 넘기기 버튼
        {
            if (game_ex_num < 4)
            {
                game_ex_num++;
                btn_left_right_check();
                visible_game_ex();
            }
        }

        private void btn_left_right_check() // 버튼이 더이상 넘어가지 않게 boundary 설정
        {
            if (game_ex_num == 0)
                btn_left_ex.Enabled = false;
            else
                btn_left_ex.Enabled = true;
            if (game_ex_num == 4)
                btn_right_ex.Enabled = false;
            else
                btn_right_ex.Enabled = true;
        }

        private void btn_clock_explain_Click(object sender, EventArgs e) // 게임 시작 버튼
        {
            btn_clock_explain.Visible = false;
            txt_game_ex.Visible = false;
            btn_left_ex.Visible = false;
            btn_right_ex.Visible = false;
            pan_clock_explain.Visible = false;
            clock_game_success.Visible = false;
            txt_game_ex_1.Visible = false;
            txt_game_ex_12.Visible = false;
            txt_game_ex_2.Visible = false;
            txt_game_ex_3_1.Visible = false;
            txt_game_ex_3_2.Visible = false;
            txt_game_ex_4.Visible = false;
            txt_game_ex_5.Visible = false;
            pic_game_ex_1_1.Visible = false;
            pic_game_ex_1_2.Visible = false;
            pic_game_ex_2_1.Visible = false;
            pic_game_ex_2_2.Visible = false;
            pic_game_ex_3_1.Visible = false;
            pic_game_ex_3_2.Visible = false;
            pic_game_ex_4.Visible = false;
            pic_game_ex_5_1.Visible = false;
            pic_game_ex_5_2.Visible = false;
            clock_timer.Start();
            clock_time.BringToFront();
        }
        
        private void clock_timer_Tick(object sender, EventArgs e) // 미로 탈출의 시간을 줄이기 위한 timer
        {
            current_time++;
            clock_time.Text = ("600 / " + current_time.ToString());
            ((maze)(this.Owner)).puzzle_game_time = current_time;
            if(current_time > 600)
            {
                this.Close();
            }
        }

        private void fail_txt_Click(object sender, EventArgs e) // 퍼즐을 맞추는데 실패시 발생하는 버튼
        {
            pan_clock_explain.Visible = false;
            fail_txt.Visible = false;
        }
    }
}

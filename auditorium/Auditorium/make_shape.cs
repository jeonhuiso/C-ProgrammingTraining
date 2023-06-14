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
    public partial class make_shape : Form
    {
        private Boolean mouseDown_check = false; // 마우스의 이동 감지 체크
        private Point mouse_move_start; // 마우스 드래그의 시작 지점
        private Point mouse_move_end; // 마우스 드래그의 종료 지점
        Button[,] root_button; // 사용자가 맞춰야하는 모양
        Button[,] goal_button; // 목표 모양
        Button[] use_button; // 드래그해서 옮길 수 있는 버튼
        private int root_top = 0;
        private int root_left = 0;
        private int use_button_num = 0; // 현재 size
        private int last_current_i = 0; // 드래그한 버튼의 마지막 x축
        private int last_current_j = 0; // 드래그한 버튼의 마지막 y축
        private int first_num = 0; // 오랜지 색상의 버튼
        private int second_num = 0; // 초록 색상의 버튼
        private int third_num = 0; // 핑크 색상의 버튼
        private int game_ex_num = 0;
        int current_time; // 현재 시간

        public make_shape(int time)
        {
            InitializeComponent();
            make_shape_init(5);
            btn_left_ex.Enabled = false;
            fail_txt.Visible = false;
            shape_game_success.Visible = false;
            visible_game_ex();
            current_time = time;
            shape_timer.Stop();
            shape_time.Text = ("600 / " + current_time.ToString());
        }

        private void make_shape_init(int size) // 게임 세팅
        {
            make_shape_set use_shape = new make_shape_set(size); // 목표 모양을 만들어냄
            int[,] small_goal = use_shape.re_return_shape();
            goal_button = new Button[size, size]; // 목표 모양을 가져옴
            for (int i = 0; i < size; i++) //  가져온 모양을 토대로 좌측 상단에 고정
            {
                for (int j = 0; j < size; j++)
                {
                    goal_button[i, j] = new Button();
                    goal_button[i, j].Width = 30;
                    goal_button[i, j].Height = 30;
                    goal_button[i, j].Top = 100 + i * 30;
                    goal_button[i, j].Left = 75 + j * 30;
                    goal_button[i, j].Enabled = false;
                    if (small_goal[i, j] == 0)
                    {
                        goal_button[i, j].Visible = false;
                        goal_button[i, j].BackColor = Color.White;
                    }
                    else if (small_goal[i, j] == 1)
                        goal_button[i, j].BackColor = Color.Orange;
                    else if (small_goal[i, j] == 2)
                        goal_button[i, j].BackColor = Color.SeaGreen;
                    else if (small_goal[i, j] == 3)
                        goal_button[i, j].BackColor = Color.LightPink;
                    else
                        goal_button[i, j].BackColor = Color.BlueViolet;
                    this.Controls.Add(goal_button[i, j]);
                }
            }
            root_top = 100;
            root_left = 300;
            use_button_num = 0;
            last_current_i = 0;
            last_current_j = 0;
            root_button = new Button[size, size]; 
            int use_size = 450 / size;
            for (int i = 0; i < size; i++) // 사용자의 버튼을 생성하고, 이벤트 추가
            {
                for (int j = 0; j < size; j++)
                {
                    root_button[i, j] = new Button();
                    root_button[i, j].Width = use_size;
                    root_button[i, j].Height = use_size;
                    root_button[i, j].Top = root_top + i * use_size;
                    root_button[i, j].Left = root_left + j * use_size;
                    if (i == size / 2 && j == size / 2) // 확인 버튼
                    {
                        root_button[i, j].Text = "확인";
                        root_button[i, j].BackColor = Color.BlueViolet;
                        root_button[i, j].Click += new EventHandler(check_same_shape_Click);
                    }
                    else // 이외의 버튼은 안보이게 설정
                    {
                        make_root_btn_handler(i, j);
                        root_button[i, j].Visible = false;
                        root_button[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(root_button[i, j]);
                }
            }
            // 드래그 가능한 버튼 수를 가져와 저장하고, 드래그 가능한 버튼 옆에 표시하고 버튼 생성
            use_button_num = size;
            first_num = use_shape.return_first();
            second_num = use_shape.return_second();
            third_num = use_shape.return_third();

            btn_first_num.Text = first_num.ToString();
            btn_second_num.Text = second_num.ToString();
            btn_third_num.Text = third_num.ToString();

            first_make_other_btn(btn_first_num, use_size, 275, 150, 0);
            first_make_other_btn(btn_second_num, use_size, 275, 150, 1);
            first_make_other_btn(btn_third_num, use_size, 275, 150, 2);

            use_button = new Button[first_num + second_num + third_num];
            make_other_btn(use_size, 275, 150, 0, 0, first_num);
            make_other_btn(use_size, 275, 150, 1, first_num, first_num + second_num);
            make_other_btn(use_size, 275, 150, 2, first_num + second_num, first_num + second_num + third_num);
        }

        private void first_make_other_btn(Button btn, int size, int location_i, int location_j, int color)
        {
            if (color == 0)
            {
                make_btn_number_num(btn, location_i + color * size, location_j, size);
                btn.BackColor = Color.Orange;
                btn.ForeColor = Color.Orange;
            }
            else if (color == 1)
            {
                make_btn_number_num(btn, location_i + color * size, location_j, size);
                btn.BackColor = Color.SeaGreen;
                btn.ForeColor = Color.SeaGreen;
            }
            else
            {
                make_btn_number_num(btn, location_i + color * size, location_j, size);
                btn.BackColor = Color.LightPink;
                btn.ForeColor = Color.LightPink;
            }
        }

        private void make_other_btn(int size, int location_i, int location_j, int color, int start, int last) // 드래그 가능한 버튼 생성
        {
            for (int i = start; i < last; i++)
            {
                use_button[i] = new Button();
                use_button[i].Width = size;
                use_button[i].Height = size;
                use_button[i].Top = location_i + color * size;
                use_button[i].Left = location_j;
                if (color == 0)
                    use_button[i].BackColor = Color.Orange;
                else if (color == 1)
                    use_button[i].BackColor = Color.SeaGreen;
                else
                    use_button[i].BackColor = Color.LightPink;
                setting_event(i);
                this.Controls.Add(use_button[i]);
            }
        }

        private void make_btn_number_num(Button btn, int location_i, int location_j, int size) // 버튼의 위치, 크기 설정
        {
            btn.Top = location_i;
            btn.Left = location_j - size;
            btn.Width = size;
            btn.Height = size;
        }


        private void make_root_btn_handler(int i, int j) // 버튼의 이벤트 핸들러 부여 (i,j)를 부여하기 위해 따로 함수 사용
        {
            root_button[i, j].Click += (sender, e) => root_btn_click(i, j);
        }

        private void root_btn_click(int i, int j) // 드래그해서 넣었을 때 색상을 변경하기 위해 사용
        {
            if(root_button[i, j].BackColor != Color.White)
            {
                root_button[i, j].BackColor = Color.White;
                root_button[i, j].Visible = false;
            }
        }

        private void root_btn_click_white(int i, int j) // 드래그 할때, 넣을 ㅜ 있는 위치를 알려주기 위해 visiable을 true로 설정
        {
            if (0 <= i && i < 5 && 0 <= j && j < 5)
                if (root_button[i, j].BackColor == Color.White)
                    root_button[i, j].Visible = true;
        }

        private void setting_event(int i) // 드래그 가능한 버튼에 마우스 이벤트를 세팅하기 위해 사용
        {
            use_button[i].MouseMove += (sender1, e) => MouseMove(sender1, e, i);
            use_button[i].MouseDown += (sender1, e) => MouseDown(sender1, e, i);
            use_button[i].MouseUp += (sender1, e) => MouseUp(sender1, e, i);
        }

        new private void MouseDown(object sender, MouseEventArgs e, int btn) // 마우스를 눌렀을 때 이벤트
        {
            mouseDown_check = true;
            mouse_move_start = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
            for(int i = 0; i < use_button_num; i++) // 모든 넣을 수 있는 곳을 표시
            {
                for(int j = 0; j < use_button_num; j++)
                {
                    if (root_button[i,j].BackColor != Color.White)
                    {
                        root_btn_click_white(i - 1, j);
                        root_btn_click_white(i + 1, j);
                        root_btn_click_white(i, j - 1);
                        root_btn_click_white(i, j + 1);
                    }
                }
            }
            use_button[btn].BringToFront();
        }

        new private void MouseUp(object sender, MouseEventArgs e, int i) // 마우스를 땠을 때 사용하는 이벤트
        {
            mouseDown_check = false;
            int x = use_button[i].Left + use_button[i].Width / 2;
            int y = use_button[i].Top + use_button[i].Height / 2;
            root_check(x, y, i);

            for(int c = 0;c < use_button_num; c++) // 다시 색이 칠해진 곳만 표시
            {
                for(int j = 0; j < use_button_num; j++)
                {
                    if(root_button[c,j].BackColor == Color.White)
                    {
                        root_button[c, j].Visible = false;
                    }
                }
            }
        }

        private void root_check(int x, int y, int use_num) // 색칠할 것을 확인
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (root_button[i, j].Left < x && x < (root_button[i, j].Left + root_button[i, j].Width) && root_button[i, j].Top < y && y < (root_button[i, j].Top + root_button[i, j].Height)) // 버튼이 놓을 수 있는 곳에 놓아지면 실행
                    {
                        if (root_button[i, j].Visible == true)
                        {
                            if (i == 2 && j == 2) // 확인 부분은 바꾸지 않음
                            {
                                use_button[use_num].BringToFront();
                            }
                            else // 이외의 부분은 해당 버튼을 넣고, 드래그한 버튼은 안보이게 설정하고, NO를 설정
                            {
                                use_button[use_num].Visible = false;
                                last_current_i = i;
                                last_current_j = j;
                                if (use_button[use_num].BackColor == Color.Orange)
                                {
                                    btn_first_num.Text = (int.Parse(btn_first_num.Text) - 1).ToString();
                                    root_button[i, j].BackColor = Color.Orange;
                                }
                                else if (use_button[use_num].BackColor == Color.SeaGreen)
                                {
                                    btn_second_num.Text = (int.Parse(btn_second_num.Text) - 1).ToString();
                                    root_button[i, j].BackColor = Color.SeaGreen;
                                }
                                else if (use_button[use_num].BackColor == Color.LightPink)
                                {
                                    btn_third_num.Text = (int.Parse(btn_third_num.Text) - 1).ToString();
                                    root_button[i, j].BackColor = Color.LightPink;
                                }
                            }
                        }
                    }
                }
            }
            use_button[use_num].BringToFront();
        }
      
        new private void MouseMove(object sender, MouseEventArgs e, int i) // 마우스 이동시 마우스의 움직임을 계속해서 계산해 드래그 가능한 버튼의 위치를 최신화
        {
            if (mouseDown_check == false)
                return;
            else
            {
                mouse_move_end = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
                use_button[i].Left += (mouse_move_end.X - mouse_move_start.X);
                use_button[i].Top += (mouse_move_end.Y - mouse_move_start.Y);
                mouse_move_start = mouse_move_end;
            }
        }

        private void check_same_shape_Click(object sender, EventArgs e) // 확인 버튼 클릭 이벤트
        {
            if (smae_shape_check()) // 같은 모양인지 확인
            {
                pan_shape_explain.Visible = true;
                shape_game_success.Visible = true;
                ((maze)(this.Owner)).third_game_clear = 1;
            }
            else
            {
                if (int.Parse(btn_reset.Text.Remove(0, 5)) == 1) // ♥가 충분하지 않으면 실행
                {
                    pan_shape_explain.Visible = true;
                    shape_game_success.Visible = true;
                    shape_game_success.Text = "game over";
                    ((maze)(this.Owner)).third_game_clear = 2;
                }
                else // ♥가 충분하면 실행
                {
                    pan_shape_explain.Visible = true;
                    fail_txt.Visible = true;
                    btn_reset.Text = "♥ x  " + (int.Parse(btn_reset.Text.Remove(0, 5)) - 1).ToString();
                }
            }
        }

        private bool smae_shape_check() // 왼쪽과 오른쪽이 같은 모양인지 확인
        {
            for (int i = 0; i < use_button_num; i++)
            {
                for (int j = 0; j < use_button_num; j++)
                {
                    if (root_button[i, j].BackColor != goal_button[i, j].BackColor)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btn_reset_Click(object sender, EventArgs e) // 재시작 버튼 (♥ 버튼)
        {
            if (int.Parse(btn_reset.Text.Remove(0, 5)) == 1) // ♥가 부족하면 실행
            {
                pan_shape_explain.Visible = true;
                shape_game_success.Visible = true;
                shape_game_success.Text = "game over";
                ((maze)(this.Owner)).third_game_clear = 2;
            }
            else // ♥가 충분하면 실행
            {
                for (int i = 0; i < use_button_num; i++) // 버튼 제거 
                {
                    for (int j = 0; j < use_button_num; j++)
                    {
                        this.Controls.Remove(goal_button[i, j]);
                        this.Controls.Remove(root_button[i, j]);
                    }
                }
                for (int i = 0; i < first_num + second_num + third_num; i++)
                    this.Controls.Remove(use_button[i]);
                make_shape_init(5);
                btn_reset.Text = "♥ x  " + (int.Parse(btn_reset.Text.Remove(0, 5)) - 1).ToString();
            }
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

        private void btn_left_right_check()  // 버튼이 더이상 넘어가지 않게 boundary 설정
        {
            if (game_ex_num == 4)
            {
                btn_right_ex.Enabled = false;
                btn_left_ex.Enabled = true;
                btn_shape_explain.Visible = true;
                cur_explain.Visible = false;
            }
            else
            {
                cur_explain.Text = "5 / " + (game_ex_num + 1).ToString();
                cur_explain.Visible = true;
                btn_shape_explain.Visible = false;
                btn_right_ex.Enabled = true;
                btn_left_ex.Enabled = true;
                if (game_ex_num == 0)
                {
                    btn_left_ex.Enabled = false;
                }
            }
        }

        private void visible_game_ex()  // 퍼즐 설명 페이지를 구현하기 위해 사용
        {
            txt_game_ex_1.Visible = false;
            txt_game_ex_2.Visible = false;
            txt_game_ex_3_1.Visible = false;
            txt_game_ex_3_2.Visible = false;
            txt_game_ex_3.Visible = false;
            txt_game_ex_4_1.Visible = false;
            txt_game_ex_4_2.Visible = false;
            txt_game_ex_5.Visible = false;
            pic_game_ex_1.Visible = false;
            pic_game_ex_2.Visible = false;
            pic_game_ex_3_1.Visible = false;
            pic_game_ex_3_2.Visible = false;
            pic_game_ex_3_3.Visible = false;
            pic_game_ex_4_1.Visible = false;
            pic_game_ex_4_2.Visible = false;
            pic_game_ex_5_1.Visible = false;
            pic_game_ex_5_2.Visible = false;

            if (game_ex_num == 0)
            {
                txt_game_ex_1.Visible = true;
                pic_game_ex_1.Visible = true;
            }
            else if (game_ex_num == 1)
            {
                txt_game_ex_2.Visible = true;
                pic_game_ex_2.Visible = true;
            }
            else if (game_ex_num == 2)
            {
                txt_game_ex_3.Visible = true;
                txt_game_ex_3_1.Visible = true;
                txt_game_ex_3_2.Visible = true;
                pic_game_ex_3_1.Visible = true;
                pic_game_ex_3_2.Visible = true;
                pic_game_ex_3_3.Visible = true;
            }
            else if (game_ex_num == 3)
            {
                txt_game_ex_4_1.Visible = true;
                txt_game_ex_4_2.Visible = true;
                pic_game_ex_4_1.Visible = true;
                pic_game_ex_4_2.Visible = true;
            }
            else if (game_ex_num == 4)
            {
                txt_game_ex_5.Visible = true;
                pic_game_ex_5_1.Visible = true;
                pic_game_ex_5_2.Visible = true;
            }
        }


        private void btn_shape_explain_Click(object sender, EventArgs e) // 게임 시작 버튼
        {
            txt_game_ex_1.Visible = false;
            txt_game_ex_2.Visible = false;
            txt_game_ex_3.Visible = false;
            txt_game_ex_3_1.Visible = false;
            txt_game_ex_3_2.Visible = false;
            txt_game_ex_4_1.Visible = false;
            txt_game_ex_4_2.Visible = false;
            txt_game_ex_5.Visible = false;
            pic_game_ex_1.Visible = false;
            pic_game_ex_2.Visible = false;
            pic_game_ex_3_1.Visible = false;
            pic_game_ex_3_2.Visible = false;
            pic_game_ex_3_3.Visible = false;
            pic_game_ex_4_1.Visible = false;
            pic_game_ex_4_2.Visible = false;
            pic_game_ex_5_1.Visible = false;
            pic_game_ex_5_2.Visible = false;
            txt_game_ex.Visible = false;
            btn_left_ex.Visible = false;
            btn_right_ex.Visible = false;
            pan_shape_explain.Visible = false;
            btn_shape_explain.Visible = false;
            shape_timer.Start();
            shape_time.BringToFront();
        }

        private void shape_game_success_Click(object sender, EventArgs e) // 퍼즐 성공시 실행하는 버튼
        {
            this.Close();
            game_exit();
        }

        private void fail_txt_Click(object sender, EventArgs e) // 퍼즐을 맞추는데 실패시 발생하는 버튼
        {
            pan_shape_explain.Visible = false;
            fail_txt.Visible = false;
        }

        private void shape_timer_Tick(object sender, EventArgs e) // 미로 탈출의 시간을 줄이기 위한 timer
        {
            current_time++;
            shape_time.Text = ("600 / " + current_time.ToString());
            ((maze)(this.Owner)).puzzle_game_time = current_time;
            if (current_time > 600)
            {
                this.Close();
                game_exit();
            }
        }

        private void game_exit()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    this.Controls.Remove(root_button[i, j]);
                    this.Controls.Remove(goal_button[i, j]);
                    root_button[i, j].Dispose();
                    goal_button[i, j].Dispose();
                }
            }
            for (int i = 0; i < 5; i++)
            {
                this.Controls.Remove(use_button[i]);
                use_button[i].Dispose();
            }
        }
    }
}

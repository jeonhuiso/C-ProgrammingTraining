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
    public partial class maze : Form
    {
        private int[,] maze_array; // 미로의 정보
        PictureBox[,] pic = new PictureBox[27, 43]; // 미로를 표현
        int current_y; // 현재 주인공의 x축
        int current_x; // 현재 주인공의 y축
        enemy[] enemy_char = new enemy[4]; // 적의 정보를 담는 용도
        int enemy_num; // 적의 개수
        public int first_game_clear = 0; // 첫번째 퍼즐 클리어 확인
        public int second_game_clear = 0; // 두번째 퍼즐 클리어 확인
        public int third_game_clear = 0; // 세번째 퍼즐 클리어 확인
        public int puzzle_game_time = 0;
        Context con;

        public maze(Context co)
        {
            InitializeComponent();
            maze_init();
            pan_maze.Visible = false;
            fail_maze.Visible = false;
            maze_all_puzzle.Visible = false;
            time_over.Visible = false;
            con = co;
        }
        
        private void maze_array_setting() // 미로 세팅
        {
            maze_array = new int[16, 25] { { 1, 1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1 },
                                           { 1, 0,  0,  0,  0,  1,  1,  0,  0,  0,  1,  6,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  1 },
                                           { 1, 0,  1,  1,  0,  0,  1,  0,  1,  0,  1,  1,  1,  0,  1,  0,  1,  0,  0,  1,  1,  0,  0,  1,  1 },
                                           { 1, 7,  0,  1,  1,  0,  0,  0,  0,  0,  1,  0,  1,  0,  0,  0,  1,  1,  0,  0,  1,  2,  1,  0,  1 },
                                           { 1, 1,  0,  0,  0,  0,  1,  1,  1,  0,  1,  0,  1,  1,  1,  1,  1,  0,  0,  0,  1,  0,  1,  0,  1 },
                                           { 1, 1,  1,  1,  0,  1,  1,  0,  0,  2,  0,  0,  0,  0,  0,  0,  1,  1,  0,  1,  1,  0,  1,  0,  1 },
                                           { 1, 5,  1,  0,  0,  1,  0,  0,  1,  1,  1,  0,  1,  1,  0,  0,  0,  0,  0,  0,  1,  0,  1,  0,  1 },
                                           { 1, 0,  1,  1,  0,  1,  0,  0,  1,  0,  1,  0,  0,  1,  0,  1,  0,  1,  1,  1,  1,  0,  1,  0,  1 },
                                           { 1, 0,  1,  0,  0,  0,  0,  1,  1,  0,  0,  0,  0,  0,  0,  0,  0,  1,  0,  0,  0,  0,  0,  0,  1 },
                                           { 1, 0,  1,  1,  1,  1,  0,  0,  0,  0,  1,  0,  1,  0,  1,  0,  1,  1,  1,  0,  1,  0,  1,  1,  1 },
                                           { 1, 0,  0,  0,  1,  0,  2,  0,  1,  1,  1,  0,  1,  0,  1,  0,  0,  1,  0,  0,  0,  0,  0,  0,  1 },
                                           { 1, 0,  1,  0,  0,  0,  1,  0,  1,  0,  0,  0,  0,  0,  1,  0,  2,  0,  0,  1,  1,  1,  1,  0,  1 },
                                           { 1, 0,  1,  1,  1,  0,  0,  0,  1,  0,  1,  1,  1,  0,  0,  0,  1,  1,  0,  0,  1,  0,  1,  0,  3 },
                                           { 1, 0,  1,  0,  1,  0,  1,  0,  0,  0,  1,  4,  1,  0,  1,  0,  1,  0,  0,  0,  1,  0,  1,  1,  1 },
                                           { 1, 0,  0,  0,  0,  0,  1,  0,  1,  0,  0,  0,  1,  0,  0,  0,  0,  0,  1,  0,  0,  0,  0,  0,  1 },
                                           { 1, 1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1 } };
        }

        public void maze_init()
        {
            maze_timer.Stop();
            
            for (int i = 0; i < 16; i++) // picturebox 설정 + enemy 초기 방향 설정
            {
                for (int j = 0; j < 25; j++)
                {
                    pic[i, j] = new PictureBox();
                    pic[i, j].Width = 20;
                    pic[i, j].Height = 20;
                    pic[i, j].Left = 20 * j + 45;
                    pic[i, j].Top = 20 * i + 55;
                    this.Controls.Add(pic[i, j]);
                }
            }

            new_maze_init();

            maze_timer.Start();
        }

        private void char_move_print()
        {
            if (char_move_enemy_check()) // 적이 나를 바라보고 있으면 적의 방향을 주인공 쪽으로 돌림 
            {
                con.ScriptParse("discovery_enemy", "discovery");
                con.print();
            }
            else
            {
                con.ScriptParse("nomal", "nomal");
                con.print();
            }
        }

        private void maze_keydown(object sender, KeyEventArgs e) // 키보드 입력 받기 (주인공의 움직임을 표현)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (current_x - 1 >= 0)
                    {
                        int check = pre_check(current_x - 1, current_y);
                        if (check == 0 || check == 4 || check == 5 || check == 6) // 벽이나 퍼즐을 만나면 이동
                        {
                            move_My_Character(current_x, current_y, current_x - 1, current_y, 1);
                            current_x--;
                        }
                        else if (check == 3) // 탈출구를 만나면 미로 탈출 or 미로를 계속 탐험
                            maze_exit();
                    }
                    char_move_print();
                    break;
                case Keys.Right:  // 위의 Left와 동일
                    if (current_x + 1 <= 25)
                    {
                        int check = pre_check(current_x + 1, current_y);
                        if (check == 0 || check == 4 || check == 5 || check == 6)
                        {
                            move_My_Character(current_x, current_y, current_x + 1, current_y, 0);
                            current_x++;
                        }
                        else if (check == 3)
                            maze_exit();
                    }
                    char_move_print();
                    break;
                case Keys.Up: // 위의 Left와 동일
                    if (current_y - 1 >= 0)
                    {
                        int check = pre_check(current_x, current_y - 1);
                        if (check == 0 || check == 4 || check == 5 || check == 6)
                        {
                            move_My_Character(current_x, current_y, current_x, current_y - 1, 3);
                            current_y--;
                        }
                        else if (check == 3)
                            maze_exit();
                    }
                    char_move_print();
                    break;
                case Keys.Down: // 위의 Left와 동일
                    if (current_y + 1 <= 16)
                    {
                        int check = pre_check(current_x, current_y + 1);
                        if (check == 0 || check == 4 || check == 5 || check == 6)
                        {
                            move_My_Character(current_x, current_y, current_x, current_y + 1, 2);
                            current_y++;
                        }
                        else if (check == 3)
                            maze_exit();
                    }
                    char_move_print();
                    break;
            }
        }

        private bool char_move_enemy_check() // 적이 주인공을 바라보는지 확인
        {
            int check = 0;
            for (int i = 0; i < enemy_num; i++)
                if (change_enemy_direcition(i))
                    check = 1;
            if (check == 1)
                return true;
            else
                return false;
        }

        private bool change_enemy_direcition(int i) // 적의 위치 확인 + 방향 전환
        {
            int enemy_x = enemy_char[i].return_enemy_x(); // 적의 현재 x축
            int enemy_y = enemy_char[i].return_enemy_y(); // 적의 현재 y축
            // 주인공의 x, y축과 적의 x, y축을 비교해서 같은 방향에 있으면 실행, 만약 벽이 뚫려있으면 방향을 바꿈
            if (enemy_x == current_x)
            {
                if (enemy_y < current_y)
                {
                    if (find_character(enemy_x, enemy_y, 0, 1))
                    {
                        enemy_char[i].change_direction_xy(0, 1);
                        pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                            return true;
                    }
                }
                else
                {
                    if (find_character(enemy_x, enemy_y, 0, -1))
                    {
                        enemy_char[i].change_direction_xy(0, -1);
                        pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                            return true;
                    }
                }
            }
            else
            {
                if (enemy_y == current_y)
                {
                    if (enemy_x < current_x)
                    {
                        if (find_character(enemy_x, enemy_y, 1, 0))
                        {
                            enemy_char[i].change_direction_xy(1, 0);
                            pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                            return true;
                        }
                    }
                    else
                    {
                        if (find_character(enemy_x, enemy_y, -1, 0))
                        {
                            enemy_char[i].change_direction_xy(-1, 0);
                            pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void maze_exit() // 미로 종료
        {
            if (first_game_clear == 0 && second_game_clear == 0 && third_game_clear == 0) // 퍼즐이 다 풀렸는지 확인
            {
                pan_maze.Visible = true;
                fail_maze.Visible = true;
            }
            else
            {
                maze_timer.Stop();
                pan_maze.Visible = true;
                if (first_game_clear == 1 && second_game_clear == 1 && third_game_clear == 1)
                {
                    lbl_result_1.Visible = true;
                    lbl_result_2.Visible = true;
                    lbl_result_3.Visible = true;
                    txt_result_1.Visible = true;
                    txt_result_2.Visible = true;
                    txt_result_3.Visible = true;
                    maze_all_puzzle.Visible = true;
                }
                else
                    maze_no_all_puzzle.Visible = true;
            }
        }

        private void move_My_Character(int pre_x, int pre_y, int cur_x, int cur_y, int dir) // 주인공이 움직임
        {
            pic[pre_y, pre_x].Image = maze_image.Images[0];
            maze_array[pre_y, pre_x] = 0;
            pic[cur_y, cur_x].Image = main_character_img.Images[dir];
            maze_array[cur_y, cur_x] = 7;
        }

        private int pre_check(int next_x, int next_y)
        {
            if (maze_array[next_y, next_x] == 1) // 벽을 만나는 경우
            {
                return 1;
            }
            else if (maze_array[next_y, next_x] == 2) // enemy를 만나는 경우
            {
                new_maze_init();
                return 2;
            }
            else if (maze_array[next_y, next_x] == 3) // 미로 탈출
            {
                return 3;
            }
            else if (maze_array[next_y, next_x] == 4) // 1번 퍼즐
            {
                maze_timer.Stop();
                puzzle_timer.Stop();
                nono nono_mad = new nono(puzzle_game_time);
                nono_mad.Owner = this;
                nono_mad.Location = new System.Drawing.Point(this.Location.X, this.Location.X);
                nono_mad.Show();
                nono_mad.FormClosing += new FormClosingEventHandler(puzzle_exit);
                return 4;
            }
            else if (maze_array[next_y, next_x] == 5) // 2번 퍼즐
            {
                maze_timer.Stop();
                puzzle_timer.Stop();
                clock clock_mad = new clock(puzzle_game_time);
                clock_mad.Owner = this;
                clock_mad.Location = new System.Drawing.Point(this.Location.X, this.Location.X);
                clock_mad.Show();
                clock_mad.FormClosed += new FormClosedEventHandler(puzzle_exit);
                return 5;
            }
            else if (maze_array[next_y, next_x] == 6) // 3번 퍼즐
            {
                maze_timer.Stop();
                puzzle_timer.Stop();
                make_shape make_shape_mad = new make_shape(puzzle_game_time);
                make_shape_mad.Owner = this;
                make_shape_mad.Location = new System.Drawing.Point(this.Location.X, this.Location.X);
                make_shape_mad.Show();
                make_shape_mad.FormClosed += new FormClosedEventHandler(puzzle_exit);
                return 6;
            }
            else // 지날 수 있는 길
            {
                return 0;
            }
        }

        public void new_maze_init() // 새로운 길을 생성함
        {
            maze_array_setting();
            enemy_num = 0;
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    pic[i, j].Width = 20;
                    pic[i, j].Height = 20;
                    pic[i, j].Left = 20 * j + 45;
                    pic[i, j].Top = 20 * i + 55;
                    pic[i, j].BackColor = SystemColors.Control;
                    pic[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (maze_array[i, j] == 0) // 벽은 일반 길로 표현
                    {
                        pic[i, j].Image = maze_image.Images[0];
                    }
                    else if (maze_array[i, j] == 1) // 벽
                    {
                        pic[i, j].Image = maze_image.Images[1];
                    }
                    else if (maze_array[i, j] == 2) // 적
                    {
                        enemy_char[enemy_num] = new enemy(j, i);
                        int e = 0, w = 0, s = 0, n = 0;
                        if (maze_array[i, j + 1] == 0)
                            e = 1;
                        if (maze_array[i, j - 1] == 0)
                            w = 1;
                        if (maze_array[i + 1, j] == 0)
                            s = 1;
                        if (maze_array[i - 1, j] == 0)
                            n = 1;
                        enemy_char[enemy_num].direction_change(e, w, s, n); // 적의 시작 방향을 지정, 빈공간을 향함
                        pic[i, j].Image = enemy_image.Images[enemy_char[enemy_num].return_direction_check()];
                        enemy_num++;
                    }
                    else if (maze_array[i, j] == 3)
                    {
                        if (first_game_clear == 0 && second_game_clear == 0 && third_game_clear == 0)
                            pic[i, j].Image = maze_image.Images[4];
                        else
                            pic[i, j].Image = maze_image.Images[3];
                    }
                    else if (maze_array[i, j] == 4) // 첫 번째 퍼즐
                    {
                        if (first_game_clear == 0)
                            pic[i, j].Image = maze_image.Images[2];
                        else
                        {
                            maze_array[i, j] = 0;
                            pic[i, j].Image = maze_image.Images[0];
                        }
                    }
                    else if (maze_array[i, j] == 5) // 두 번째 퍼즐
                    {
                        if(second_game_clear == 0)
                            pic[i, j].Image = maze_image.Images[2];
                        else
                        {
                            maze_array[i, j] = 0;
                            pic[i, j].Image = maze_image.Images[0];
                        }
                    }
                    else if (maze_array[i, j] == 6) // 세 번째 퍼즐
                    {
                        if (third_game_clear == 0)
                            pic[i, j].Image = maze_image.Images[2];
                        else
                        {
                            maze_array[i, j] = 0;
                            pic[i, j].Image = maze_image.Images[0];
                        }
                    }
                    else // 주인공
                    {
                        pic[i, j].Image = main_character_img.Images[0]; // 처음에 동쪽을 바라봄
                    }
                }
            }
            current_x = 1;
            current_y = 3;
        }
        
       

        private void maze_tick(object sender, EventArgs e) // 1초당 적이 움직임
        {
            for (int i = 0; i < enemy_num; i++)
            {
                change_enemy_direcition(i);
                int enemy_x = enemy_char[i].return_enemy_x();
                int enemy_y = enemy_char[i].return_enemy_y();
                int enemy_direction_x = enemy_char[i].return_direction_x();
                int enemy_direction_y = enemy_char[i].return_direction_y();
                if (maze_array[enemy_y + enemy_direction_y, enemy_x + enemy_direction_x] == 0) // 길이면 방향 그대로 움직임
                {
                    enemy_char[i].change_enemy_xy(enemy_x + enemy_direction_x, enemy_y + enemy_direction_y);
                    enemy_move(enemy_x, enemy_y, enemy_direction_x, enemy_direction_y, i);
                }
                else if (maze_array[enemy_y + enemy_direction_y, enemy_x + enemy_direction_x] == 7) // 적이 주인공을 잡으면 미로 초기화
                {
                    new_maze_init();
                }
                else // 이외의 경우에는 방향만 바꿈
                {
                    int ee = 0, w = 0, s = 0, n = 0;
                    if (maze_array[enemy_y, enemy_x + 1] == 0)
                        ee = 1;
                    if (maze_array[enemy_y, enemy_x - 1] == 0)
                        w = 1;
                    if (maze_array[enemy_y + 1, enemy_x] == 0)
                        s = 1;
                    if (maze_array[enemy_y - 1, enemy_x] == 0)
                        n = 1;
                    enemy_char[i].direction_change(ee, w, s, n);
                    pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                }
            }
        }

        private void enemy_move(int enemy_x, int enemy_y, int dir_x, int dir_y, int i) // 적의 움직이는 것 표현
        {
            pic[enemy_y, enemy_x].Image = maze_image.Images[0];
            maze_array[enemy_y, enemy_x] = 0;
            pic[enemy_y + dir_y, enemy_x + dir_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
            maze_array[enemy_y + dir_y, enemy_x + dir_x] = 2;
        }

        private bool find_character(int x, int y, int dir_x, int dir_y) // enemy가 주인공을 잡았는지 확인
        {
            int start_x = x, start_y = y;
            bool find_char = false;
            while (true)
            {
                start_x += dir_x;
                start_y += dir_y;
                if (maze_array[start_y, start_x] == 7)
                {
                    find_char = true;
                    break;
                }
                else if (maze_array[start_y, start_x] == 0)
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
            return find_char;
        }

        private void puzzle_exit(object sender, EventArgs e) // 퍼즐 종료시 멈췄던 시간 다시 돌림
        {
            puzzle_timer.Start();
            maze_timer.Start();
            total_timer.Text = "600 / " + puzzle_game_time.ToString();
            if(first_game_clear != 0 && second_game_clear != 0 && third_game_clear != 0)
                pic[12, 24].Image = maze_image.Images[3];
        }

        private void puzzle_timer_Tick(object sender, EventArgs e)
        {
            puzzle_game_time++;
            total_timer.Text = "600 / " + puzzle_game_time.ToString();
            if(puzzle_game_time > 600) {
                fail_maze.Visible = true;
                pan_maze.Visible = true;
            }
        }

        private void fail_maze_Click(object sender, EventArgs e)
        {
            fail_maze.Visible = false;
            pan_maze.Visible = false;
        }

        private void maze_all_puzzle_Click(object sender, EventArgs e)
        {
            if(txt_result_1.Text == "6" && txt_result_2.Text == "4" && txt_result_3.Text == "9")
            {
                MessageBox.Show("성공");
                this.Close();
            }
            else
            {
                MessageBox.Show("실패");
                this.Close();
            }
        }

        private void time_over_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maze_no_all_puzzle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enemy_deteching_Tick(object sender, EventArgs e)
        {
            char_move_print();
        }

        private void maze_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
    }
}

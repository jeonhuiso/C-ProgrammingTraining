﻿using System;
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
        private int[,] maze_array;
        PictureBox[,] pic = new PictureBox[27, 43];
        int current_y;
        int current_x;
        enemy[] enemy_char = new enemy[15];
        int enemy_num;

        public maze()
        {
            InitializeComponent();
            maze_init();
        }
        
        private void maze_array_setting()
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
            maze_array_setting();
            enemy_num = 0;
            for (int i = 0; i < 16; i++) // picturebox 설정 + enemy 초기 방향 설정
            {
                for (int j = 0; j < 25; j++)
                {
                    pic[i, j] = new PictureBox();
                    pic[i, j].Width = 20;
                    pic[i, j].Height = 20;
                    pic[i, j].Left = 20 * j + 45;
                    pic[i, j].Top = 20 * i + 55;
                    pic[i, j].BackColor = SystemColors.Control;
                    pic[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (maze_array[i, j] == 0 || maze_array[i, j] == 3)
                    {
                        pic[i, j].Image = maze_image.Images[0];
                    }
                    else if (maze_array[i, j] == 1)
                    {
                        pic[i, j].Image = maze_image.Images[1];
                    }
                    else if (maze_array[i, j] == 2)
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
                        enemy_char[enemy_num].direction_change(e, w, s, n);
                        pic[i, j].Image = enemy_image.Images[enemy_char[enemy_num].return_direction_check()];
                        enemy_num++;
                    }
                    else if (maze_array[i, j] == 4)
                    {
                        pic[i, j].Image = maze_image.Images[2];
                    }
                    else if (maze_array[i, j] == 5)
                    {
                        pic[i, j].Image = maze_image.Images[2];
                    }
                    else if (maze_array[i, j] == 6)
                    {
                        pic[i, j].Image = maze_image.Images[2];
                    }
                    else
                    {
                        pic[i, j].Image = main_character_img.Images[0];
                    }
                    this.Controls.Add(pic[i, j]);
                }
            }
            current_x = 1;
            current_y = 3;
        }

        private void maze_keydown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (current_x - 1 >= 0)
                    {
                        int check = pre_check(current_x - 1, current_y);
                        if (check == 0 || check == 4 || check == 5 || check == 6)
                        {
                            move_My_Character(current_x, current_y, current_x - 1, current_y, 1);
                            current_x--;
                        }
                        else if (check == 3)
                            maze_exit();
                    }
                    char_move_enemy_check();
                    break;
                case Keys.Right:
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
                    char_move_enemy_check();
                    break;
                case Keys.Up:
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
                    char_move_enemy_check();
                    break;
                case Keys.Down:
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
                    char_move_enemy_check();
                    break;
            }
        }

        private void char_move_enemy_check()
        {
            for (int i = 0; i < enemy_num; i++)
            {
                change_enemy_direcition(i);
            }
        }

        private void maze_exit()
        {
            maze_timer.Stop();
            var maze_exit = MessageBox.Show(
                "미로 탈출 성공했습니다.\r\n탈출하시겠습니까?",
                "Caption",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (maze_exit == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                maze_timer.Start();
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
                nono nono_mad = new nono();
                nono_mad.Owner = this;
                nono_mad.Show();
                nono_mad.FormClosed += new FormClosedEventHandler(puzzle_exit);
                maze_timer.Stop();
                return 4;
            }
            else if (maze_array[next_y, next_x] == 5) // 2번 퍼즐
            {
                clock clock_mad = new clock();
                clock_mad.Owner = this;
                clock_mad.Show();
                clock_mad.FormClosed += new FormClosedEventHandler(puzzle_exit);
                maze_timer.Stop();
                return 5;
            }
            else if (maze_array[next_y, next_x] == 6) // 3번 퍼즐
            {
                make_shape make_shape_mad = new make_shape();
                make_shape_mad.Owner = this;
                make_shape_mad.Show();
                make_shape_mad.FormClosed += new FormClosedEventHandler(puzzle_exit);
                maze_timer.Stop();
                return 6;
            }
            else // 지날 수 있는 길
            {
                return 0;
            }
        }


        public void new_maze_init()
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
                    if (maze_array[i, j] == 0 || maze_array[i, j] == 3) 
                    {
                        pic[i, j].Image = maze_image.Images[0];
                    }
                    else if (maze_array[i, j] == 1)
                    {
                        pic[i, j].Image = maze_image.Images[1];
                    }
                    else if (maze_array[i, j] == 2)
                    {
                        enemy_char[enemy_num].change_enemy_xy(j, i);
                        int e = 0, w = 0, s = 0, n = 0;
                        if (maze_array[i, j + 1] == 0)
                            e = 1;
                        if (maze_array[i, j - 1] == 0)
                            w = 1;
                        if (maze_array[i + 1, j] == 0)
                            s = 1;
                        if (maze_array[i - 1, j] == 0)
                            n = 1;
                        enemy_char[enemy_num].direction_change(e, w, s, n);
                        pic[i, j].Image = enemy_image.Images[enemy_char[enemy_num].return_direction_check()];
                        enemy_num++;
                    }
                    else if (maze_array[i, j] == 4)
                    {
                        pic[i, j].Image = maze_image.Images[2];
                    }
                    else if (maze_array[i, j] == 5)
                    {
                        pic[i, j].Image = maze_image.Images[2];
                    }
                    else if (maze_array[i, j] == 6)
                    {
                        pic[i, j].Image = maze_image.Images[2];
                    }
                    else
                    {
                        pic[i, j].Image = main_character_img.Images[0];
                    }
                }
            }
            current_x = 1;
            current_y = 3;
        }
        
        private void change_enemy_direcition(int i)
        {
            int enemy_x = enemy_char[i].return_enemy_x();
            int enemy_y = enemy_char[i].return_enemy_y();
            int enemy_direction_x = enemy_char[i].return_direction_x();
            int enemy_direction_y = enemy_char[i].return_direction_y();

            if (enemy_x == current_x)
            {
                if (enemy_y < current_y)
                {
                    if (find_character(enemy_x, enemy_y, 0, 1))
                    {
                        enemy_char[i].change_direction_xy(0, 1);
                        pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                    }
                }
                else
                {
                    if (find_character(enemy_x, enemy_y, 0, -1))
                    {
                        enemy_char[i].change_direction_xy(0, -1);
                        pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
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
                        }
                    }
                    else
                    {
                        if (find_character(enemy_x, enemy_y, -1, 0))
                        {
                            enemy_char[i].change_direction_xy(-1, 0);
                            pic[enemy_y, enemy_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
                        }
                    }
                }
            }
        }

        private void maze_tick(object sender, EventArgs e)
        {
            total_timer.Text = "600 / " + (int.Parse(total_timer.Text.Remove(0, 5)) + 1).ToString();
            for (int i = 0; i < enemy_num; i++)
            {
                change_enemy_direcition(i);
                int enemy_x = enemy_char[i].return_enemy_x();
                int enemy_y = enemy_char[i].return_enemy_y();
                int enemy_direction_x = enemy_char[i].return_direction_x();
                int enemy_direction_y = enemy_char[i].return_direction_y();
                enemy_direction_x = enemy_char[i].return_direction_x();
                enemy_direction_y = enemy_char[i].return_direction_y();
                if (maze_array[enemy_y + enemy_direction_y, enemy_x + enemy_direction_x] == 0)
                {
                    enemy_char[i].change_enemy_xy(enemy_x + enemy_direction_x, enemy_y + enemy_direction_y);
                    enemy_move(enemy_x, enemy_y, enemy_direction_x, enemy_direction_y, i);
                }
                else if (maze_array[enemy_y + enemy_direction_y, enemy_x + enemy_direction_x] == 7)
                {
                    new_maze_init();
                }
                else
                {

                    enemy_x = enemy_char[i].return_enemy_x();
                    enemy_y = enemy_char[i].return_enemy_y();
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
                    enemy_direction_x = enemy_char[i].return_direction_x();
                    enemy_direction_y = enemy_char[i].return_direction_y();
                    if (maze_array[enemy_y + enemy_direction_y, enemy_x + enemy_direction_x] == 0)
                    {
                        enemy_char[i].change_enemy_xy(enemy_x + enemy_direction_x, enemy_y + enemy_direction_y);
                        enemy_move(enemy_x, enemy_y, enemy_direction_x, enemy_direction_y, i);
                    }
                }
            }
        }

        private void enemy_move(int enemy_x, int enemy_y, int dir_x, int dir_y, int i)
        {
            pic[enemy_y, enemy_x].Image = maze_image.Images[0];
            maze_array[enemy_y, enemy_x] = 0;
            pic[enemy_y + dir_y, enemy_x + dir_x].Image = enemy_image.Images[enemy_char[i].return_direction_check()];
            maze_array[enemy_y + dir_y, enemy_x + dir_x] = 2;
        }

        private bool find_character(int x, int y, int dir_x, int dir_y) // enemy가 주인공을 볼 수 있는지 확인 
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

        private void puzzle_exit(object sender, EventArgs e)
        {
            maze_timer.Start();
        }
    }
}

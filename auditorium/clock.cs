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
        Button[,] user_clock;
        Button[,] make_clock;
        private int level = 0;
        private int game_start_x = 43;
        private int game_start_y = 90;
        private int time_or_color = 0;

        public clock()
        {
            InitializeComponent();
            clock_game_init();
        }

        private void clock_game_init()
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
        }

        private void make_game(Button[,] clock, int num, int wid, int make_user) // make_clock = 0, user_clock = 1;
        {
            int btn_size = 250 / num;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        clock[i, j] = new Button();
                        make_Button(clock, i, j, btn_size, (game_start_x + wid + i * btn_size), (game_start_y + j * btn_size));
                        if (make_user == 0)
                            clock[i, j].Enabled = false;
                        else
                            if (i != 0 || j != 0)
                            user_event_setting(i, j);
                        this.Controls.Add(clock[i, j]);
                    }
                    else
                    {
                        clock[i, j] = new Button();
                        make_Button(clock, i, j, btn_size, (game_start_x + wid + i * btn_size), (game_start_y + j * btn_size));
                        clock[i, j].Text = "1:00";
                        clock[i, j].Enabled = false;
                        this.Controls.Add(clock[i, j]);
                    }
                }
            }
        }

        private void user_event_setting(int i, int j)
        {
            user_clock[i, j].Click += (sender1, e) => user_btn_click(i, j);
        }

        private void make_clock_init(int num)
        {
            Random rand = new Random();
            List<int> row = new List<int>(); // 행
            List<int> col = new List<int>(); // 열
            int use_remove;
            for (int i = 1; i < num; i++)
            {
                row.Add(i);
                col.Add(i);
            }
            for (int i = 1; i < num; i++)
            {
                use_remove = rand.Next(3 * (row.Count - 1)) % row.Count;
                make_clock_add(0, rand.Next(12), row[use_remove], num);
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

        private void make_color_add(int row_col, int where_row_col, int num, int color_num)
        {
            if (row_col == 0)
            {
                for (int j = 1; j < num; j++)
                    clock_Backcolor_check_change(make_clock, j, where_row_col, color_num);
                clock_Backcolor_check_change(user_clock, 0, where_row_col, color_num);
                clock_Forecolor_check_change(user_clock, 0, where_row_col, color_num);
                user_clock[0, where_row_col].Text = color_num.ToString();
            }
            else
            {
                for (int j = 1; j < num; j++)
                    clock_Backcolor_check_change(make_clock, where_row_col, j, color_num);
                clock_Backcolor_check_change(user_clock, where_row_col, 0, color_num);
                clock_Forecolor_check_change(user_clock, where_row_col, 0, color_num);
                user_clock[where_row_col, 0].Text = color_num.ToString();

            }
        }

        private void clock_Backcolor_check_change(Button[,] clock, int i, int j, int color_num)
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

        private void clock_Forecolor_check_change(Button[,] clock, int i, int j, int color_num)
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

        private void make_clock_add(int row_col, int rand_num, int where_row_col, int num)
        {
            if (row_col == 0) // row : 0
                for (int j = 1; j < num; j++)
                    clock_check_change(make_clock, j, where_row_col, rand_num);
            else // col : 1
                for (int j = 1; j < num; j++)
                    clock_check_change(make_clock, where_row_col, j, rand_num);
        }

        private void clock_check_change(Button[,] clock, int i, int j, int sum)
        {
            int origin_sum = int.Parse(clock[i, j].Text.Substring(0, clock[i, j].Text.LastIndexOf(":"))) + sum;
            if (origin_sum > 12)
            {
                clock[i, j].Text = (origin_sum - 12 + ":00").ToString();
            }
            else
            {
                clock[i, j].Text = (origin_sum + ":00").ToString();
            }
        }

        private void make_Button(Button[,] clock, int i, int j, int size, int left, int top)
        {
            clock[i, j].TextAlign = ContentAlignment.MiddleCenter;
            clock[i, j].Width = size;
            clock[i, j].Height = size;
            clock[i, j].Left = left;
            clock[i, j].Top = top;
        }

        private void remove_Button(int num)
        {
            for (int i = 0; i < num; i++)
                for (int j = 0; j < num; j++)
                {
                    this.Controls.Remove(make_clock[i, j]);
                    this.Controls.Remove(user_clock[i, j]);
                }
        }

        private void make_check_btn(object sender, EventArgs e)
        {
            if (level < 2)
            {
                if (compelete_check())
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
                    make_clock_init(4 + level);
                    lbl_clock_level.Text = "2 / " + (int.Parse(lbl_clock_level.Text.Remove(0, 11)) + 1).ToString();
                }
                else
                {
                    if (int.Parse(lbl_clock_life.Text.Remove(0, 3)) == 1)
                    {
                        MessageBox.Show("game over", "Cpation", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("실패했습니다.");
                        lbl_clock_life.Text = "♥ x  " + (int.Parse(lbl_clock_life.Text.Remove(0, 3)) - 1).ToString();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private bool compelete_check()
        {
            bool return_complete = true;
            for (int i = 1; i < 4 + level; i++)
                for (int j = 1; j < 4 + level; j++)
                    if (user_clock[i, j].Text != make_clock[i, j].Text || user_clock[i, j].BackColor != make_clock[i, j].BackColor)
                        return false;
            return return_complete;
        }

        private void user_check_btn(object sender, EventArgs e)
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

        private void user_btn_click(int i, int j)
        {
            if (time_or_color == 0)
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
            else
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

        private void btn_clock_explain_Click(object sender, EventArgs e)
        {
            btn_clock_explain.Visible = false;
            txt_clock_explain.Visible = false;
            pan_clock_explain.Visible = false;
        }
    }
}

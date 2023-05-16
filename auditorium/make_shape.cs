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
        public make_shape()
        {
            InitializeComponent();
            make_shape_init(5);
        }

        private void make_shape_init(int size)
        {
            make_shape_set use_shape = new make_shape_set(size);
            int[,] small_goal = use_shape.re_return_shape();
            goal_button = new Button[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    goal_button[i, j] = new Button();
                    goal_button[i, j].Width = 20;
                    goal_button[i, j].Height = 20;
                    goal_button[i, j].Top = 80 + i * 20;
                    goal_button[i, j].Left = 52 + j * 20;
                    goal_button[i, j].Enabled = false;
                    if (small_goal[i, j] == 0)
                    {
                        goal_button[i, j].Visible = false;
                        goal_button[i, j].BackColor = Color.White;
                    }
                    else if (small_goal[i, j] == 1)
                        goal_button[i, j].BackColor = Color.Yellow;
                    else if (small_goal[i, j] == 2)
                        goal_button[i, j].BackColor = Color.SeaGreen;
                    else if (small_goal[i, j] == 3)
                        goal_button[i, j].BackColor = Color.LightPink;
                    else
                        goal_button[i, j].BackColor = Color.BlueViolet;
                    this.Controls.Add(goal_button[i, j]);
                }
            }

            root_top = 55;
            root_left = 210;
            use_button_num = 0;
            last_current_i = 0;
            last_current_j = 0;
            root_button = new Button[size, size];
            int use_size = 300 / size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    root_button[i, j] = new Button();
                    root_button[i, j].Width = use_size;
                    root_button[i, j].Height = use_size;
                    root_button[i, j].Top = root_top + i * use_size;
                    root_button[i, j].Left = root_left + j * use_size;
                    if (i == size / 2 && j == size / 2)
                    {
                        root_button[i, j].Text = "확인";
                        root_button[i, j].BackColor = Color.BlueViolet;
                        root_button[i, j].Click += new EventHandler(check_same_shape_Click);
                    }
                    else
                    {
                        make_root_btn_handler(i, j);
                        root_button[i, j].Visible = false;
                        root_button[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(root_button[i, j]);
                }
            }

            use_button_num = size;
            first_num = use_shape.return_first();
            second_num = use_shape.return_second();
            third_num = use_shape.return_third();

            btn_first_num.Text = first_num.ToString();
            btn_second_num.Text = second_num.ToString();
            btn_third_num.Text = third_num.ToString();

            use_button = new Button[first_num + second_num + third_num];
            make_other_btn(use_size, 200, 100, 0, 0, first_num);
            make_other_btn(use_size, 200, 100, 1, first_num, first_num + second_num);
            make_other_btn(use_size, 200, 100, 2, first_num + second_num, first_num + second_num + third_num);
        }

        private void make_other_btn(int size, int location_i, int location_j, int color, int start, int last)
        {
            for (int i = start; i < last; i++)
            {
                use_button[i] = new Button();
                use_button[i].Width = size;
                use_button[i].Height = size;
                use_button[i].Top = location_i + color * size;
                use_button[i].Left = location_j;
                if (color == 0)
                {
                    use_button[i].BackColor = Color.Yellow;
                    make_btn_number_num(btn_first_num, location_i + color * size, location_j, size);
                    btn_first_num.BackColor = Color.Yellow;
                    btn_first_num.ForeColor = Color.Yellow;
                }
                else if (color == 1)
                {
                    use_button[i].BackColor = Color.SeaGreen;
                    make_btn_number_num(btn_second_num, location_i + color * size, location_j, size);
                    btn_second_num.BackColor = Color.SeaGreen;
                    btn_second_num.ForeColor = Color.SeaGreen;
                }
                else
                {
                    use_button[i].BackColor = Color.LightPink;
                    make_btn_number_num(btn_third_num, location_i + color * size, location_j, size);
                    btn_third_num.BackColor = Color.LightPink;
                    btn_third_num.ForeColor = Color.LightPink;
                }
                use_button[i].Text = "YES";
                setting_event(i);
                this.Controls.Add(use_button[i]);
            }
        }

        private void make_btn_number_num(Button btn, int location_i, int location_j, int size)
        {
            btn.Top = location_i;
            btn.Left = location_j - size;
            btn.Width = size;
            btn.Height = size;
        }


        private void make_root_btn_handler(int i, int j)
        {
            root_button[i, j].Click += (sender, e) => root_btn_click(i, j);
        }

        private void root_btn_click(int i, int j)
        {
            if (root_button[i, j].BackColor == Color.White)
            {
                if (save_color == 0)
                    root_button[i, j].BackColor = Color.Yellow;
                else if (save_color == 1)
                    root_button[i, j].BackColor = Color.SeaGreen;
                else
                    root_button[i, j].BackColor = Color.LightPink;
                root_btn_click_white(last_current_i - 1, last_current_j);
                root_btn_click_white(last_current_i + 1, last_current_j);
                root_btn_click_white(last_current_i, last_current_j - 1);
                root_btn_click_white(last_current_i, last_current_j + 1);
                for (int ubn = 0; ubn < use_button_num; ubn++)
                {
                    if (use_button[ubn].Text == "YES")
                    {
                        use_button[ubn].Enabled = true;
                    }
                }
                root_btn_enable_f_t(1);
            }
            else
            {
                root_button[i, j].BackColor = Color.White;
                root_button[i, j].Visible = false;
            }
        }

        private void root_btn_click_white(int i, int j)
        {
            if (0 <= i && i < 5 && 0 <= j && j < 5)
                if (root_button[i, j].BackColor == Color.White)
                    root_button[i, j].Visible = false;
        }

        private void setting_event(int i)
        {
            use_button[i].MouseMove += (sender1, e) => MouseMove(sender1, e, i);
            use_button[i].MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDown);
            use_button[i].MouseUp += (sender1, e) => MouseUp(sender1, e, i);
        }

        new private void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown_check = true;
            mouse_move_start = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
        }

        new private void MouseUp(object sender, MouseEventArgs e, int i)
        {
            mouseDown_check = false;
            int x = use_button[i].Left + use_button[i].Width / 2;
            int y = use_button[i].Top + use_button[i].Height / 2;
            root_check(x, y, i);
        }

        private void root_check(int x, int y, int use_num)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (root_button[i, j].Left < x && x < (root_button[i, j].Left + root_button[i, j].Width) && root_button[i, j].Top < y && y < (root_button[i, j].Top + root_button[i, j].Height))
                    {
                        if (root_button[i, j].BackColor != Color.White)
                        {

                            int false_num = 0;
                            if (root_button_visible(i - 1, j))
                                false_num++;
                            if (root_button_visible(i + 1, j))
                                false_num++;
                            if (root_button_visible(i, j - 1))
                                false_num++;
                            if (root_button_visible(i, j + 1))
                                false_num++;

                            if (false_num != 0)
                            {
                                use_button[use_num].Visible = false;
                                use_button[use_num].Text = "NO";
                                last_current_i = i;
                                last_current_j = j;
                                for (int ubn = 0; ubn < use_button_num; ubn++)
                                {
                                    use_button[ubn].Enabled = false;
                                }
                                if (use_button[use_num].BackColor == Color.Yellow)
                                {
                                    save_color = 0;
                                    btn_first_num.Text = (int.Parse(btn_first_num.Text) - 1).ToString();
                                }
                                else if (use_button[use_num].BackColor == Color.SeaGreen)
                                {
                                    save_color = 1;
                                    btn_second_num.Text = (int.Parse(btn_second_num.Text) - 1).ToString();
                                }
                                else if (use_button[use_num].BackColor == Color.LightPink)
                                {
                                    save_color = 2;
                                    btn_third_num.Text = (int.Parse(btn_third_num.Text) - 1).ToString();
                                }
                                root_btn_enable_f_t(0);
                            }
                            else
                            {
                                use_button[use_num].BringToFront();
                            }
                        }
                    }
                }
            }
            use_button[use_num].BringToFront();
        }

        private void root_btn_enable_f_t(int f_t)
        {
            for (int i = 0; i < use_button_num; i++)
                for (int j = 0; j < use_button_num; j++)
                    if (root_button[i, j].BackColor != Color.White)
                        if (f_t == 0)
                            root_button[i, j].Enabled = false;
                        else
                            root_button[i, j].Enabled = true;
            for (int i = 0; i < first_num + second_num + third_num; i++)
                if (f_t == 0)
                    use_button[i].Enabled = false;
                else
                    use_button[i].Enabled = true;
            if (f_t == 0)
                btn_reset.Enabled = false;
            else
                btn_reset.Enabled = true;
        }

        private bool root_button_visible(int i, int j)
        {
            if (0 <= i && i < 5 && 0 <= j && j < 5)
            {
                root_button[i, j].Visible = true;
                if (root_button[i, j].BackColor != Color.White)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        new private void MouseMove(object sender, MouseEventArgs e, int i)
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

        private void check_same_shape_Click(object sender, EventArgs e)
        {
            if (smae_shape_check())
            {
                MessageBox.Show("성공했습니다");
                this.Close();
            }
            else
            {
                if (int.Parse(btn_reset.Text.Remove(0, 5)) == 1)
                {
                    MessageBox.Show("game over");
                    this.Close();
                }
                else
                {
                    btn_reset.Text = "♥ x  " + (int.Parse(btn_reset.Text.Remove(0, 5)) - 1).ToString();
                }
            }
        }

        private bool smae_shape_check()
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (int.Parse(btn_reset.Text.Remove(0, 5)) == 1)
            {
                MessageBox.Show("game over");
                this.Close();
            }
            else
            {
                for (int i = 0; i < use_button_num; i++)
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

        private Boolean mouseDown_check = false;
        private Point mouse_move_start;
        private Point mouse_move_end;
        Button[,] root_button;
        Button[,] goal_button;
        Button[] use_button;
        private int root_top = 100;
        private int root_left = 150;
        private int use_button_num = 0;
        private int last_current_i = 0;
        private int last_current_j = 0;
        private int save_color;
        private int first_num = 0;
        private int second_num = 0;
        private int third_num = 0;
    }
}

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
        private Button[,] nono_btn;
        private int[,] nono_check_array;
        private int level = 0;
        private int s_location_x = 150;
        private int s_location_y = 40;

        public nono()
        {
            InitializeComponent();
            nono_puzzle_init();
        }

        public void nono_puzzle_init()
        {
            nono_btn = new Button[4 + level, 4 + level];
            nono_check_array = new int[3 + level, 3 + level];
            make_game(4 + level);
        }

        private void make_game(int size)
        {
            Random rand = new Random();
            int use_size = 300 / size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (i == 0 && j == 0)
                        {
                            make_btn(i, j, 80, 80, s_location_x, s_location_y);
                            nono_btn[i, j].Click += new EventHandler(change_level_btn_Click);
                            nono_btn[i, j].Text = "확인";
                            nono_btn[i, j].Font = new Font("맑은고딕", 20);
                            this.Controls.Add(nono_btn[i, j]);
                        }
                        else
                        {
                            if (j == 0)
                            {
                                make_btn(i, j, use_size, 80, s_location_x + 80 + (i - 1) * use_size, s_location_y);
                                nono_btn[i, j].TextAlign = ContentAlignment.BottomCenter;
                                this.Controls.Add(nono_btn[i, j]);
                            }
                            else
                            {
                                make_btn(i, j, 80, use_size, s_location_x, s_location_y + 80 + (j - 1) * use_size);
                                nono_btn[i, j].TextAlign = ContentAlignment.MiddleRight;
                                this.Controls.Add(nono_btn[i, j]);
                            }
                        }
                    }
                    else
                    {
                        if (rand.Next(10) % 2 == 0)
                            nono_check_array[i - 1, j - 1] = 1;
                        else
                            nono_check_array[i - 1, j - 1] = 0;
                        make_btn(i, j, use_size, use_size, s_location_x + 80 + (i - 1) * use_size, s_location_y + 80 + (j - 1) * use_size);
                        this.Controls.Add(nono_btn[i, j]);
                    }
                }
            }

            int btn_check_num = 0;
            for (int i = 1; i < size; i++)
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
                            nono_btn[i, 0].Text = (btn_check_num + "\r\n" + nono_btn[i, 0].Text).ToString();
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    nono_btn[i, 0].Text = (btn_check_num + "\r\n" + nono_btn[i, 0].Text).ToString();
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
                            nono_btn[0, i].Text = (btn_check_num + " " + nono_btn[0, i].Text).ToString();
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    nono_btn[0, i].Text = (btn_check_num + " " + nono_btn[0, i].Text).ToString();
                }
            }
        }

        private void nono_btn_click(int i, int j)
        {
            if (i > 0 && j > 0)
            {
                if (nono_btn[i, j].BackColor == Color.WhiteSmoke)
                    nono_btn[i, j].BackColor = Color.BlueViolet;
                else
                    nono_btn[i, j].BackColor = Color.WhiteSmoke;
            }
        }

        private void make_btn(int i, int j, int size_x, int size_y, int location_x, int location_y)
        {
            nono_btn[i, j] = new Button();
            nono_btn[i, j].Width = size_x;
            nono_btn[i, j].Height = size_y;
            nono_btn[i, j].Left = location_x;
            nono_btn[i, j].Top = location_y;
            nono_btn[i, j].BackColor = Color.WhiteSmoke;
            nono_btn[i, j].Click += (sender1, e) => nono_btn_click(i, j);
        }


        private void change_level_btn_Click(object sender, EventArgs e)
        {
            if (check_complete(4 + level))
            {
                for (int i = 0; i < 4 + level; i++)
                    for (int j = 0; j < 4 + level; j++)
                        this.Controls.Remove(nono_btn[i, j]);
                level++;
                if (level == 4)
                {
                    this.Close();
                }
                else
                {
                    nono_btn = new Button[4 + level, 4 + level];
                    nono_check_array = new int[3 + level, 3 + level];
                    make_game(4 + level);
                    lbl_nono_level.Text = "4 / " + (int.Parse(lbl_nono_level.Text.Remove(0, 3)) + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("실패했습니다.", "Cpation", MessageBoxButtons.OK);
            }
        }

        private bool check_complete(int size)
        {
            string compare_com_check;
            int btn_check_num = 0;
            string nono_btn_save;
            string complete_use_btn;
            for (int i = 1; i < size; i++)
            {
                compare_com_check = "";
                nono_btn_save = nono_btn[i, 0].Text;
                complete_use_btn = nono_btn_save.Replace("\r\n", "");
                complete_use_btn = complete_use_btn.Replace(" ", "");
                btn_check_num = 0;
                for (int j = 1; j < size; j++)
                {
                    if (nono_btn[i, j].BackColor == Color.BlueViolet)
                    {
                        btn_check_num++;
                    }
                    else
                    {
                        if (btn_check_num != 0)
                        {
                            compare_com_check = (btn_check_num + compare_com_check).ToString();
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    compare_com_check = (btn_check_num + compare_com_check).ToString();
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
                for (int j = 1; j < size; j++)
                {
                    if (nono_btn[j, i].BackColor == Color.BlueViolet)
                    {
                        btn_check_num++;
                    }
                    else
                    {
                        if (btn_check_num != 0)
                        {
                            compare_com_check = (btn_check_num + compare_com_check).ToString();
                            btn_check_num = 0;
                        }
                    }
                }
                if (btn_check_num != 0)
                {
                    compare_com_check = (btn_check_num + compare_com_check).ToString();
                }
                if (!complete_use_btn.Equals(compare_com_check))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

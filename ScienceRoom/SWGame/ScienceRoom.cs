using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWGame
{
    public partial class science : Form
    {
        public science()
        {
            InitializeComponent();

            bool lighter = sci_lighter.Enabled;
            bool phenol = sci_phenol.Enabled;
        }

        public string PrintResult(bool lighter, bool phenol, int num)
        {
            string msg = "";

            if (lighter == false)
            {
                msg = "금속이 담긴 유리병 앞에 막대기가 하나 놓여있다.";
                MessageBox.Show("유리병");
            }

            //페놀프탈레인 실험
            else if (phenol == true)
            {
                switch (num)
                {
                    case 1:
                        msg = "작은 금속 조각을 넣고 용액을 떨어트리니 물이 보랏빛으로 변했다.";
                        break;
                    case 10:
                        msg = "작은 금속 조각을 넣고 용액을 떨어트리니 물이 보랏빛으로 변했다.";
                        break;
                    default:
                        msg = "아무 일도 일어나지 않았다.";
                        break;
                }
            }

            //불꽃색 실험
            else
            {
                switch (num)
                {
                    case 1:
                        msg = "노란색 불꽃이다.";
                        MessageBox.Show("노란색 불꽃");
                        break;
                    case 2:
                        msg = "하얀색 불꽃이다.";
                        break;
                    case 3:
                        msg = "연두색 불꽃이다.";
                        break;
                    case 4:
                        msg = "하얀색 불꽃이다.";
                        break;
                    case 5:
                        msg = "노란색 불꽃이다.";
                        break;
                    case 6:
                        msg = "빨간색 불꽃이다.";
                        break;
                    case 7:
                        msg = "파란색 불꽃이다.";
                        break;
                    case 8:
                        msg = "진한 빨간색 불꽃이다.";
                        break;
                    case 9:
                        msg = "파란색 불꽃이다.";
                        break;
                    case 10:
                        msg = "빨간색 불꽃이다.";
                        break;
                }
            }
            return msg;
        }

        //테이블 위 금속 병 클릭
        private void sci_1_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 1;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_2_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 2;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_3_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 3;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_4_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 4;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_5_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 5;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_6_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 6;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_7_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 7;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_8_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 8;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_9_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 9;
            string msg = PrintResult(lighter, phenol, num);
        }

        private void sci_10_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            bool phenol = sci_phenol.Checked;
            int num = 10;
            string msg = PrintResult(lighter, phenol, num);
        }

        //노트북 열기
        private void sci_laptop_Click(object sender, EventArgs e)
        {
            sci_screen newForm = new sci_screen();
            newForm.ShowDialog();
        }
        
    }
}

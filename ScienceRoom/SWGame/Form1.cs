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
        int[] check = new int[12];
        
        public science()
        {
            InitializeComponent();

            for (int i = 0; i < 12; i++)
                check[i] = 0;

            bool lighter = sci_lighter.Enabled;

        }

        public string PrintResult(bool lighter, int num)
        {
            string msg = "";

            if (lighter == false)
            {
                msg = "금속이 담긴 유리병 앞에 막대기가 하나 놓여있다.";
            }

            else
            {
                switch (num) {
                    case 1: msg = "노란색 불꽃이다.";
                        break;
                    case 2: msg = "하얀색 불꽃이다.";
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

        private void sci_1_Click(object sender, EventArgs e)
        {
            bool lighter = sci_lighter.Checked;
            int num = 1;
            string msg = PrintResult(lighter, num);
        }
    }
}

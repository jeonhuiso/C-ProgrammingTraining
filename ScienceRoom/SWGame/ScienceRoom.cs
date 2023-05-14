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
            lock_open = false;
            lock_event = 0; //0=이벤트 전, 1=이벤트 후, 2=열쇠 획득
            sci_ans = 0;    //0이면 오답, 1이면 노말, 2이면 히든 정답을 입력한 상태
        }

        public string PrintResult(bool lighter, bool phenol, int num)
        {
            string msg = "";

            if (lighter == false)
            {
                msg = "금속이 담긴 유리병 앞에 막대기가 하나 놓여있다.";
                MessageBox.Show("유리병"); //테스트용
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
                        MessageBox.Show("노란색 불꽃");  //테스트용
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


        public int sci_ans;    //0이면 오답, 1이면 노말, 2이면 히든 정답을 입력한 상태
        public bool lock_open;

        //노트북 열기
        private void sci_laptop_Click(object sender, EventArgs e)
        {
            sci_screen screen= new sci_screen(sci_ans);
            screen.Owner = this;
            //정답 여부 전달받기
            if (screen.ShowDialog() == DialogResult.OK) 
            {
                screen.sci_ans = sci_ans;
            }

            //정답을 맞췄으면 락커가 열림
            if (sci_ans != 0 && lock_open == false)
            {
                lock_open = true;
                MessageBox.Show("락커가 열렸다.");
                //락커 이미지 변경시키기
            }
        }

        public int lock_event;  //0=이벤트 전, 1=이벤트 후, 2=열쇠 획득
        //락커 열기
        private void sci_locker_Click(object sender, EventArgs e)
        {
            if (lock_open == false)
                MessageBox.Show("락커가 잠겨있다. 밖에서 잠금장치는 보이지 않는다.");
            else
            {
                if (Na.Enabled == false && lock_event == 0)
                {
                    //수조이벤트
                    lock_event = 1;
                }
                else if (Na.Enabled == false && lock_event == 1)
                {
                    MessageBox.Show("산성 수조에서 열쇠를 꺼내야한다.");
                }
                else if (Na.Enabled == true && lock_event == 1)
                {
                    //수조가 터지고 열쇠를 획득
                    lock_event = 2;
                }
                else if (Na.Enabled == true && lock_event == 0)
                {
                    //그냥 나트륨을 수조에 던져버리고 열쇠 획득, 조금 황당해함
                    lock_event = 2;
                }
                else if (lock_event == 2)
                {
                    MessageBox.Show("터진 수조다.");
                }
            }
        }

        private void sci_lock_Click(object sender, EventArgs e)
        {
            if(lock_event != 2)
            {
                MessageBox.Show("문이 잠겼다. 이걸 열지 못하면 방에서 나가지 못한다.");
            }
            else
            {
                //열쇠 사용 후 밖으로 이동
                MessageBox.Show("밖으로 이동");
            }
        }
    }
}

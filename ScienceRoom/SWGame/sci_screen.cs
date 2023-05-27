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
    public partial class sci_screen : Form
    {
        public int sci_ans;
        public sci_screen(int ans)
        {
            InitializeComponent();
            sci_ans = ans;
                        
            //정답을 이미 맞춘경우 정답만 다시 표시
            if (sci_ans == 1)
            {
                MessageBox.Show("노말정답");
                //노말정답 표시
                sci_ans = 1;
            }
            else if (sci_ans == 2)
            {
                MessageBox.Show("히든정답");
                //히든정답 표시
                sci_ans = 2;
            }
        }

        private void aply_btn_Click(object sender, EventArgs e)
        {
            string msg;
            string code = textBox1.Text;
            int ans = 0;    //부모에게 답 결과 전달용;

            //아직 정답을 맞추지 못했다면
            if (sci_ans == 0)
            {
                if (code == "f7d11913")
                {
                    msg = "normal";
                    //노말 정답 표시 기능 임시
                    MessageBox.Show("노말정답\n락커 비밀번호: 8503");
                    sci_ans = 1;
                }
                else if (code == "ffd11t13")
                {
                    msg = "hidden";
                    //히든 정답 표시 기능 임시
                    MessageBox.Show("히든정답\n락커 비밀번호: 8503");
                    sci_ans = 2;
                }
                else
                {
                    msg = "wrong";
                    sci_ans = 0;
                }
            }

            //결과 전달
            DialogResult = DialogResult.OK;
            science ScienceRoom = (science)Owner;
            ScienceRoom.sci_ans = sci_ans;
        }

        //이미 정답을 맞췄으면 답만 보여주고 화면은 닫아버림
        private void sci_screen_Activated(object sender, EventArgs e)
        {
            if (sci_ans != 0)
                this.Close();
        }

        private void sci_screen_Load(object sender, EventArgs e)
        {

        }
    }
}

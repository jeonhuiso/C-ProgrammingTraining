using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRoom
{
    public partial class mail : Form
    {
        public mail()
        {
            InitializeComponent();
            pnlReceive.Visible = true;
            pnlMailIn.Visible = false;
            pnlBanner.Visible = true;
            pnlMailList.Visible = true;

            pnlReceive.Parent = this;
            pnlMailIn.Parent = this;
            pnlNothing.Parent = this;

            pnlMailIn.Visible = false;
            pnlNothing.Visible = false;

            lblMail1.Text = "님 확인좀";
            lblMail1Date.Text = "20XX.XX.XX";
            lblMail2.Text = "계정 해지 요청";
            lblMail2Date.Text = "20XX.XX.XX";
            lblMail3.Text = "이메일 소유권 확인 필요";
            lblMail3Date.Text = "20XX.XX.X1";
            lblMail4.Text = "가입을 축하합니다!";
            lblMail4Date.Text = "20XX.XX.XX";

            lblDate.Text = "20XX.XX.XX";
            lblTo.Text = "freeman75@hmail.net";
        }


        // Mail Context
        private void lblMail1_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "kingwang21@hmail.net";
            lblDate.Text = "20XX.XX.XX";
            lblTo.Text = "freeman75@hmail.net";
            txtSubject.Text = "님 확인좀";
            txtMailContext.Text = "퀴즈 1등 했다면서? ㅊㅊ";

            lblAtt.Enabled = true;
            lblAtt.Text = "noname";
            lblAtt.ForeColor = Color.Blue;
            lblAtt.Visible = true;
        }

        private void lblMail2_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "realadmin231434@iklwx.com";
            lblDate.Text = "20XX.XX.XX";
            lblTo.Text = "freeman75@hmail.net";
            txtSubject.Text = "계정 해지 요청";
            txtMailContext.Text = "반갑다, freeman75.\n\n당신의 계정이 곧 해지 예정입니다.\n\n아래 Link를 누르십시오.\n\nnotscamsite.ls.xwq";

            lblAtt.Text = "";
            lblAtt.Enabled = false;

        }

        private void lblMail3_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "qwkdxpa@3k2d.cxz";
            lblDate.Text = "20XX.XX.X1";
            lblTo.Text = "freeman75@hmail.net";
            txtSubject.Text = "이메일 소유권 확인 필요";
            txtMailContext.Text = "주의! 당신의 계정이 위협받고 있는것 같습니다!\n이를 해결하기 위해 33$/월 이 필요!\n지금 당장 결제하세요!";

            lblAtt.Text = "";
            lblAtt.Enabled = false;

        }

        private void lblMail4_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "admin@hmail.net";
            lblDate.Text = "20XX.XX.XX";
            lblTo.Text = "freeman75@hmail.net";
            txtSubject.Text = "가입을 축하합니다!";
            txtMailContext.Text = "안녕하세요 freeman75님,\n\nHmail에 가입하신 것을 진심으로 축하합니다.\n\n항상 더 나은 서비스를 위해 노력하는 Hmail이 되겠습니다.\n\n" +
                "감사합니다.\n\nHmail 운영자로부터";

            lblAtt.Text = "";
            lblAtt.Enabled = false;

        }

        // Mail List
        private void lblRecieve_Click(object sender, EventArgs e)
        {
            pnlReceive.Visible = true;
            pnlMailIn.Visible = false;
            pnlNothing.Visible = false;
            pnlReceive.BringToFront();
        }

        private void lblSend_Click(object sender, EventArgs e)
        {
            pnlReceive.Visible = false;
            pnlMailIn.Visible = false;
            pnlNothing.Visible = true;
            pnlNothing.BringToFront();
        }

        private void lblSpam_Click(object sender, EventArgs e)
        {
            pnlReceive.Visible = false;
            pnlMailIn.Visible = false;
            pnlNothing.Visible = true;
            pnlNothing.BringToFront();

        }

        private void lblTrash_Click(object sender, EventArgs e)
        {
            pnlReceive.Visible = false;
            pnlMailIn.Visible = false;
            pnlNothing.Visible = true;
            pnlNothing.BringToFront();

        }

        private void lblAtt_Click(object sender, EventArgs e)
        {
            // 인물 정보나 히든 엔딩 작성
            // 파일에서 오픈하면 정보 텍스트 창 띄워줌
            string path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..\\Downloads\\noname");
            var fileNoname = File.Create(path);
            fileNoname.Close();
            MessageBox.Show("다운로드 완료!\nDownloads\\noname");
        }
    }
}

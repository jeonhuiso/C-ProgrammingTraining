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

            pnlReceive.Parent = this;
            pnlMailIn.Parent = this;
            pnlNothing.Parent = this;
        }


        // Mail Context
        private void lblMail1_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "";
            lblDate.Text = "";
            lblTo.Text = "";
            txtSubject.Text = "";

            lblAtt.Text = "";
            lblAtt.Enabled = true;
            lblAtt.Text = "test";
            lblAtt.ForeColor = Color.Blue;
            lblAtt.Visible = true;
        }

        private void lblMail2_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "";
            lblDate.Text = "";
            lblTo.Text = "";
            txtSubject.Text = "";

            lblAtt.Text = "";
            lblAtt.Enabled = false;

        }

        private void lblMail3_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "";
            lblDate.Text = "";
            lblTo.Text = "";
            txtSubject.Text = "";

            lblAtt.Text = "";
            lblAtt.Enabled = false;

        }

        private void lblMail4_Click(object sender, EventArgs e)
        {
            pnlMailIn.Visible = true;
            pnlMailIn.BringToFront();
            lblFrom.Text = "";
            lblDate.Text = "";
            lblTo.Text = "";
            txtSubject.Text = "";

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
            string path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..\\..\\Downloads\\test");
            File.Create(path);
            MessageBox.Show("다운로드 완료!\nDownloads\\test");
        }
    }
}

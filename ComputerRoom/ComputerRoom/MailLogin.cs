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
    public partial class MailLogin : Form
    {
        public MailLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "freeman75" && txtPassword.Text == "50982")
            {
                mail ml = new mail();
                //ml.Owner = this;
                ml.Show();
                this.Close();
            }
            else if (txtID.Text != "freeman75")
            {
                lblLogin.Text = "존재하지 않는 ID 입니다.";
                lblLogin.Visible = true;
                lblHint.Visible = false;
                txtID.Clear();
                txtPassword.Clear();
            }
            else if (txtID.Text == "freeman75" && txtPassword.Text != "50982")
            {
                lblLogin.Text = "비밀번호를 확인해 주시길 바랍니다.";
                lblLogin.Visible = true;
                lblHint.Visible = true;
                txtID.Clear();
                txtPassword.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EscapeFromHighschool
{
    public partial class EndingMain : Form
    {
        public EndingMain()
        {
            InitializeComponent();
        }
        const string sin = "1921";
        const string mat = "0614";
        bool[] keyGet = new bool[2] { false, false };
        bool isSin = false;
        bool isMat = false;
        string password = "";
        int passwordCount = 0;
        //Sin 금고 패널 보여주기
        private void pbSin_Click(object sender, EventArgs e)
        {
            pnPassword.Visible = true;
            isSin = true;
            isMat = false;
            password = "";
            lblBoxName.Text= "Sin";
            passwordShowChange(tbPassword);
        }
        //Mat 금고 패널 보여주기
        private void pbMat_Click(object sender, EventArgs e)
        {
            pnPassword.Visible = true;
            isSin = false;
            isMat = true;
            password = "";
            lblBoxName.Text = "Mat";
            passwordShowChange(tbPassword);
        }
        //각 패스워드 버튼 입력
        private void PasswordNumBtnClick(object sender ,EventArgs e)
        {
            if (password.Length < 4)
            {
                if (((Button)sender).Name == "lock0")
                {
                    password += "0";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock1")
                {
                    password += "1";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock2")
                {
                    password += "2";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock3")
                {
                    password += "3";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock4")
                {
                    password += "4";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock5")
                {
                    password += "5";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock6")
                {
                    password += "6";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock7")
                {
                    password += "7";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock8")
                {
                    password += "8";
                    passwordShowChange(tbPassword);
                    return;
                }
                if (((Button)sender).Name == "lock9")
                {
                    password += "9";
                    passwordShowChange(tbPassword);
                    return;
                }
            }
        }
        //패스워드 스크린 출력
        private void passwordShowChange(TextBox changeWhat) {
            changeWhat.Text = password;
        }

        private void pbdoor_Click(object sender, EventArgs e)
        {

        }
        private void BtnClose(object sender,EventArgs e)
        {
            ((Control)sender).Parent.Visible = false;
        }
        private void EndingMain_Load(object sender, EventArgs e)
        {
            keyGet[0] = false;
            keyGet[1] = false;
        }

        private void lockDel_Click(object sender, EventArgs e)
        {
            if (password.Length <= 1)
            {
                password = "";
            }
            else
            {
                password = password.Substring(0, password.Length-1);
            }
            passwordShowChange(tbPassword);

        }

        private void lockEnter_Click(object sender, EventArgs e)
        {
            if (isSin && password == sin)
            {
                EndingPanel.Visible = true;
                pnPassword.Visible = false;
                EndingPanel.BackgroundImage = imageList1.Images[0];
            }
            else if (isMat && password == mat)
            {
                pnPassword.Visible = false;
                EndingPanel.Visible = true;
                EndingPanel.BackgroundImage = imageList1.Images[1];
            }
            else {
               // MessageBox.Show("nope");
            }
        }

        private void pnPassword_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}

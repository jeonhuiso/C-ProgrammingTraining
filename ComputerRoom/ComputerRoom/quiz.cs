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
    public partial class quiz : Form
    {
        int life = 3;
        public quiz()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            if (int.Parse(lblTime.Text) == 9)
            {
                this.BackColor = Color.Navy;
            }
            if (int.Parse(lblTime.Text) <= 0)
            {
                timer.Stop();
                timerZero();
                this.BackColor = Color.Red;
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            btnYes1.Visible = false;
            btnYes2.Visible = false;
            lblHappy.Visible = false;

            boxQuestion.Visible = true;
            lblQuestion.Visible = true;
            lblTime.Visible = true;
            txtAnswer.Visible = true;
            lblRemainLife.Visible = true;
            lblLife.Visible = true;

            lblTime.Text = "10";
            lblLife.Text = life.ToString();

            timer.Start();
        }

        private void timerZero()
        {
            life -= 1;
            lblLife.Text = life.ToString();
            if (life <= 0)
            {
                btnYes1.Visible = false;
                btnYes2.Visible = false;
                lblHappy.Visible = false;

                boxQuestion.Visible = false;
                lblQuestion.Visible = false;
                lblTime.Visible = false;
                txtAnswer.Visible = false;
                lblRemainLife.Visible = false;
                lblLife.Visible = false;

                this.BackColor = Color.Red;
                timer.Stop();

                lblLose.Visible = true;
                this.Text = "에구머니나!"
                return;
            }
            this.BackColor = Color.Red;
            lblTime.Text = "10";
            timer.Start();
        }
    }
}

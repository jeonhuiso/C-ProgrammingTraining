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
        List<string> quizs = new List<string>();
        List<string> answers = new List<string>();
        int qNumber = 0;
        public quiz()
        {
            InitializeComponent();
            quizs.Add("대한민국의 수도는?");
            answers.Add("서울");
            quizs.Add("중국의 수도는?");
            answers.Add("베이징");
            quizs.Add("일본의 수도는?");
            answers.Add("도쿄");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            lblLife.Text = life.ToString();
            lblQuestion.Text = quizs[qNumber];
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
            btnOk.Visible = true;

            lblTime.Text = "50";
            lblLife.Text = life.ToString();

            timer.Start();
        }

        private void timerZero()
        {
            life -= 1;
            lblLife.Text = life.ToString();
            if (life <= 0)
            {
                gameEnd();
                return;
            }
            this.BackColor = Color.Red;
            lblTime.Text = "50";
            timer.Start();
        }

        private void showQuestions()
        {
            lblQuestion.Text = quizs[qNumber];

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string input = txtAnswer.Text;

            if (input == answers[qNumber])
            {
                showQuestions();
                lblTime.Text = "50";
                // 사진 출력
                boxCorrect.Visible = true;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    this.Invoke(new Action(() =>
                    {
                        boxCorrect.Visible = false;
                    }));
                });
                if (qNumber == quizs.Count - 1)     // 퀴즈 다 풀었을 때
                {
                    gameEnd();
                    lblLose.Text = "퀴즈를 성공!";
                    lblLose.ForeColor = Color.Navy;
                    this.Text = "성공!";

                    this.BackColor = Color.Gold;

                    willScore();
                }
                qNumber++;
            }
            else
            {
                life -= 1;
                lblLife.Text = life.ToString();
                // 사진 출력
                boxIncorrect.Visible = true;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    this.Invoke(new Action(() =>
                    {
                        boxIncorrect.Visible = false;
                    }));
                });
                if (life <= 0)
                {
                    gameEnd(); return;
                }
            }
            txtAnswer.Clear();
        }

        private void willScore()
        {
            Task.Run(() =>
            {
                Thread.Sleep(1500);
                this.Invoke(new Action(() =>
                {
                    lblWillScore.Visible = true;
                }));
            });

            Task.Run(() =>
            {
                Thread.Sleep(3000);
                this.Invoke(new Action(() =>
                {
                    btnScoreYes.Visible = true;
                    btnScoreNo.Visible = true;
                }));
            });
        }

        private void gameEnd()
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
            btnOk.Visible = false;

            this.BackColor = Color.Red;
            timer.Stop();

            lblLose.Visible = true;
            this.Text = "에구머니나!";
        }
        private void btnScoreYes_Click(object sender, EventArgs e)
        {

        }

        private void btnScoreNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

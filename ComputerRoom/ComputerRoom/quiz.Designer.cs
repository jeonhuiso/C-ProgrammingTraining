﻿namespace ComputerRoom
{
    partial class quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quiz));
            txtAnswer = new TextBox();
            lblQuestion = new Label();
            lblTime = new Label();
            boxQuestion = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            btnYes1 = new Button();
            btnYes2 = new Button();
            lblHappy = new Label();
            lblRemainLife = new Label();
            lblLife = new Label();
            lblLose = new Label();
            btnOk = new Button();
            boxCorrect = new PictureBox();
            boxIncorrect = new PictureBox();
            lblWillScore = new Label();
            btnScoreYes = new Button();
            btnScoreNo = new Button();
            ((System.ComponentModel.ISupportInitialize)boxQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxIncorrect).BeginInit();
            SuspendLayout();
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("휴먼매직체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.Location = new Point(102, 175);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(462, 85);
            txtAnswer.TabIndex = 0;
            txtAnswer.Text = "답";
            txtAnswer.Visible = false;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("휴먼매직체", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.ForeColor = SystemColors.ControlLightLight;
            lblQuestion.Location = new Point(102, 103);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(77, 37);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "문제";
            lblQuestion.Visible = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Ravie", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Gold;
            lblTime.Location = new Point(452, 38);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(137, 45);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time";
            lblTime.Visible = false;
            // 
            // boxQuestion
            // 
            boxQuestion.Image = (Image)resources.GetObject("boxQuestion.Image");
            boxQuestion.Location = new Point(1, 12);
            boxQuestion.Name = "boxQuestion";
            boxQuestion.Size = new Size(178, 147);
            boxQuestion.SizeMode = PictureBoxSizeMode.StretchImage;
            boxQuestion.TabIndex = 3;
            boxQuestion.TabStop = false;
            boxQuestion.Visible = false;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // btnYes1
            // 
            btnYes1.Font = new Font("휴먼매직체", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes1.Location = new Point(217, 175);
            btnYes1.Name = "btnYes1";
            btnYes1.Size = new Size(94, 66);
            btnYes1.TabIndex = 4;
            btnYes1.Text = "Yes";
            btnYes1.UseVisualStyleBackColor = true;
            btnYes1.Click += btnYes_Click;
            // 
            // btnYes2
            // 
            btnYes2.Font = new Font("휴먼매직체", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes2.Location = new Point(377, 175);
            btnYes2.Name = "btnYes2";
            btnYes2.Size = new Size(94, 66);
            btnYes2.TabIndex = 5;
            btnYes2.Text = "Yes";
            btnYes2.UseVisualStyleBackColor = true;
            btnYes2.Click += btnYes_Click;
            // 
            // lblHappy
            // 
            lblHappy.AutoSize = true;
            lblHappy.Font = new Font("휴먼매직체", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHappy.ForeColor = SystemColors.ControlLightLight;
            lblHappy.Location = new Point(240, 80);
            lblHappy.Name = "lblHappy";
            lblHappy.Size = new Size(206, 30);
            lblHappy.TabIndex = 6;
            lblHappy.Text = "즐거운 퀴즈 시간";
            // 
            // lblRemainLife
            // 
            lblRemainLife.AutoSize = true;
            lblRemainLife.Font = new Font("휴먼매직체", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            lblRemainLife.ForeColor = Color.Gold;
            lblRemainLife.Location = new Point(452, 103);
            lblRemainLife.Name = "lblRemainLife";
            lblRemainLife.Size = new Size(85, 17);
            lblRemainLife.TabIndex = 7;
            lblRemainLife.Text = "남은 목숨 : ";
            lblRemainLife.Visible = false;
            // 
            // lblLife
            // 
            lblLife.AutoSize = true;
            lblLife.ForeColor = Color.Gold;
            lblLife.Location = new Point(539, 100);
            lblLife.Name = "lblLife";
            lblLife.Size = new Size(50, 20);
            lblLife.TabIndex = 8;
            lblLife.Text = "label1";
            lblLife.Visible = false;
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.Font = new Font("휴먼매직체", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblLose.ForeColor = Color.Orange;
            lblLose.Location = new Point(195, 110);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(318, 61);
            lblLose.TabIndex = 9;
            lblLose.Text = "YOU LOSE!";
            lblLose.Visible = false;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("휴먼매직체", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(470, 266);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 40);
            btnOk.TabIndex = 10;
            btnOk.Text = "정답 확인!";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // boxCorrect
            // 
            boxCorrect.BackColor = Color.MediumTurquoise;
            boxCorrect.Location = new Point(493, 142);
            boxCorrect.Name = "boxCorrect";
            boxCorrect.Size = new Size(129, 118);
            boxCorrect.SizeMode = PictureBoxSizeMode.StretchImage;
            boxCorrect.TabIndex = 11;
            boxCorrect.TabStop = false;
            boxCorrect.Visible = false;
            // 
            // boxIncorrect
            // 
            boxIncorrect.BackColor = Color.FromArgb(255, 128, 0);
            boxIncorrect.Location = new Point(493, 142);
            boxIncorrect.Name = "boxIncorrect";
            boxIncorrect.Size = new Size(129, 118);
            boxIncorrect.TabIndex = 12;
            boxIncorrect.TabStop = false;
            boxIncorrect.Visible = false;
            // 
            // lblWillScore
            // 
            lblWillScore.AutoSize = true;
            lblWillScore.Font = new Font("휴먼매직체", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblWillScore.ForeColor = Color.FromArgb(128, 64, 0);
            lblWillScore.Location = new Point(251, 277);
            lblWillScore.Name = "lblWillScore";
            lblWillScore.Size = new Size(176, 18);
            lblWillScore.TabIndex = 13;
            lblWillScore.Text = "점수를 등록하시겠습니까?";
            lblWillScore.Visible = false;
            // 
            // btnScoreYes
            // 
            btnScoreYes.Font = new Font("휴먼둥근헤드라인", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnScoreYes.Location = new Point(300, 175);
            btnScoreYes.Name = "btnScoreYes";
            btnScoreYes.Size = new Size(94, 29);
            btnScoreYes.TabIndex = 14;
            btnScoreYes.Text = "네";
            btnScoreYes.UseVisualStyleBackColor = true;
            btnScoreYes.Visible = false;
            btnScoreYes.Click += btnScoreYes_Click;
            // 
            // btnScoreNo
            // 
            btnScoreNo.Font = new Font("휴먼둥근헤드라인", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnScoreNo.Location = new Point(300, 212);
            btnScoreNo.Name = "btnScoreNo";
            btnScoreNo.Size = new Size(94, 29);
            btnScoreNo.TabIndex = 15;
            btnScoreNo.Text = "아니요";
            btnScoreNo.UseVisualStyleBackColor = true;
            btnScoreNo.Visible = false;
            btnScoreNo.Click += btnScoreNo_Click;
            // 
            // quiz
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(682, 353);
            Controls.Add(btnScoreNo);
            Controls.Add(btnScoreYes);
            Controls.Add(lblWillScore);
            Controls.Add(boxIncorrect);
            Controls.Add(boxCorrect);
            Controls.Add(btnOk);
            Controls.Add(lblLose);
            Controls.Add(lblLife);
            Controls.Add(lblRemainLife);
            Controls.Add(lblHappy);
            Controls.Add(btnYes2);
            Controls.Add(btnYes1);
            Controls.Add(lblTime);
            Controls.Add(lblQuestion);
            Controls.Add(txtAnswer);
            Controls.Add(boxQuestion);
            Name = "quiz";
            Text = "퀴즈 타임!";
            ((System.ComponentModel.ISupportInitialize)boxQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxIncorrect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnswer;
        private Label lblQuestion;
        private Label lblTime;
        private PictureBox boxQuestion;
        private System.Windows.Forms.Timer timer;
        private Button btnYes1;
        private Button btnYes2;
        private Label lblHappy;
        private Label lblRemainLife;
        private Label lblLife;
        private Label lblLose;
        private Button btnOk;
        private PictureBox boxCorrect;
        private PictureBox boxIncorrect;
        private Label lblWillScore;
        private Button btnScoreYes;
        private Button btnScoreNo;
    }
}
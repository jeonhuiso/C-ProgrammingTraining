namespace ComputerRoom
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
            pnlScore = new Panel();
            btnNameOk = new Button();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNameYour = new Label();
            lblName1 = new Label();
            lblName2 = new Label();
            lblName3 = new Label();
            lblFreeman = new Label();
            ((System.ComponentModel.ISupportInitialize)boxQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxIncorrect).BeginInit();
            pnlScore.SuspendLayout();
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
            // pnlScore
            // 
            pnlScore.Controls.Add(label5);
            pnlScore.Controls.Add(label4);
            pnlScore.Controls.Add(label3);
            pnlScore.Controls.Add(label2);
            pnlScore.Controls.Add(label1);
            pnlScore.Controls.Add(lblNameYour);
            pnlScore.Controls.Add(lblName1);
            pnlScore.Controls.Add(lblName2);
            pnlScore.Controls.Add(lblName3);
            pnlScore.Controls.Add(lblFreeman);
            pnlScore.Location = new Point(-4, 0);
            pnlScore.Name = "pnlScore";
            pnlScore.Size = new Size(688, 358);
            pnlScore.TabIndex = 16;
            pnlScore.Visible = false;
            // 
            // btnNameOk
            // 
            btnNameOk.Font = new Font("휴먼둥근헤드라인", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNameOk.Location = new Point(504, 192);
            btnNameOk.Name = "btnNameOk";
            btnNameOk.Size = new Size(71, 29);
            btnNameOk.TabIndex = 18;
            btnNameOk.Text = "등록";
            btnNameOk.UseVisualStyleBackColor = true;
            btnNameOk.Visible = false;
            btnNameOk.Click += btnNameOk_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.Font = new Font("Sigmar One", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(217, 188);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 37);
            txtName.TabIndex = 17;
            txtName.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(397, 247);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 9;
            label5.Text = "48095";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(397, 59);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "50982";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(397, 103);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 7;
            label3.Text = "49093";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(397, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 6;
            label2.Text = "48991";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(397, 196);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 5;
            label1.Text = "48132";
            // 
            // lblNameYour
            // 
            lblNameYour.AutoSize = true;
            lblNameYour.Font = new Font("Sigmar One", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameYour.ForeColor = Color.Fuchsia;
            lblNameYour.Location = new Point(148, 95);
            lblNameYour.Name = "lblNameYour";
            lblNameYour.Size = new Size(158, 38);
            lblNameYour.TabIndex = 4;
            lblNameYour.Text = "yourname";
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Font = new Font("Sigmar One", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName1.ForeColor = SystemColors.ControlLightLight;
            lblName1.Location = new Point(149, 142);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(164, 38);
            lblName1.TabIndex = 3;
            lblName1.Text = "abcabcabc";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Font = new Font("Sigmar One", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName2.ForeColor = SystemColors.ControlLightLight;
            lblName2.Location = new Point(148, 189);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(169, 38);
            lblName2.TabIndex = 2;
            lblName2.Text = "jumpman23";
            // 
            // lblName3
            // 
            lblName3.AutoSize = true;
            lblName3.Font = new Font("Sigmar One", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName3.ForeColor = SystemColors.ControlLightLight;
            lblName3.Location = new Point(148, 239);
            lblName3.Name = "lblName3";
            lblName3.Size = new Size(176, 38);
            lblName3.TabIndex = 1;
            lblName3.Text = "qwertyqwe";
            // 
            // lblFreeman
            // 
            lblFreeman.AutoSize = true;
            lblFreeman.Font = new Font("Sigmar One", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFreeman.ForeColor = SystemColors.ControlLightLight;
            lblFreeman.Location = new Point(148, 46);
            lblFreeman.Name = "lblFreeman";
            lblFreeman.Size = new Size(163, 38);
            lblFreeman.TabIndex = 0;
            lblFreeman.Text = "freeman75";
            // 
            // quiz
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(682, 353);
            Controls.Add(btnNameOk);
            Controls.Add(btnScoreNo);
            Controls.Add(txtName);
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
            Controls.Add(pnlScore);
            Name = "quiz";
            Text = "퀴즈 타임!";
            ((System.ComponentModel.ISupportInitialize)boxQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxIncorrect).EndInit();
            pnlScore.ResumeLayout(false);
            pnlScore.PerformLayout();
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
        private Panel pnlScore;
        private Label lblFreeman;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNameYour;
        private Label lblName1;
        private Label lblName2;
        private Label lblName3;
        private Button btnNameOk;
        private TextBox txtName;
    }
}
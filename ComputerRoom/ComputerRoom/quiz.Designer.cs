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
            ((System.ComponentModel.ISupportInitialize)boxQuestion).BeginInit();
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
            // quiz
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(682, 353);
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
    }
}
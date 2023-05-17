namespace ComputerRoom
{
    partial class windows_bg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windows_bg));
            boxQuiz = new PictureBox();
            lbl_boxQuiz = new Label();
            txtTime = new TextBox();
            boxInternet = new PictureBox();
            label1 = new Label();
            boxFolder = new PictureBox();
            lblFolder = new Label();
            ofd = new OpenFileDialog();
            Mail = new PictureBox();
            label2 = new Label();
            lblMail = new Label();
            ((System.ComponentModel.ISupportInitialize)boxQuiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxInternet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mail).BeginInit();
            SuspendLayout();
            // 
            // boxQuiz
            // 
            boxQuiz.BackColor = Color.Transparent;
            boxQuiz.BackgroundImage = (Image)resources.GetObject("boxQuiz.BackgroundImage");
            boxQuiz.Image = (Image)resources.GetObject("boxQuiz.Image");
            boxQuiz.Location = new Point(296, 109);
            boxQuiz.Margin = new Padding(2, 2, 2, 2);
            boxQuiz.Name = "boxQuiz";
            boxQuiz.Size = new Size(63, 52);
            boxQuiz.SizeMode = PictureBoxSizeMode.StretchImage;
            boxQuiz.TabIndex = 3;
            boxQuiz.TabStop = false;
            boxQuiz.Click += boxQuiz_Click;
            // 
            // lbl_boxQuiz
            // 
            lbl_boxQuiz.AutoSize = true;
            lbl_boxQuiz.BackColor = SystemColors.Control;
            lbl_boxQuiz.ForeColor = SystemColors.ControlLightLight;
            lbl_boxQuiz.Image = (Image)resources.GetObject("lbl_boxQuiz.Image");
            lbl_boxQuiz.Location = new Point(296, 163);
            lbl_boxQuiz.Margin = new Padding(2, 0, 2, 0);
            lbl_boxQuiz.Name = "lbl_boxQuiz";
            lbl_boxQuiz.Size = new Size(67, 15);
            lbl_boxQuiz.TabIndex = 5;
            lbl_boxQuiz.Text = "Don't Click";
            // 
            // txtTime
            // 
            txtTime.BackColor = SystemColors.ScrollBar;
            txtTime.Location = new Point(591, 394);
            txtTime.Margin = new Padding(2, 2, 2, 2);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(98, 23);
            txtTime.TabIndex = 6;
            txtTime.Text = "what time?";
            // 
            // boxInternet
            // 
            boxInternet.BackgroundImage = (Image)resources.GetObject("boxInternet.BackgroundImage");
            boxInternet.Image = (Image)resources.GetObject("boxInternet.Image");
            boxInternet.Location = new Point(-19, 0);
            boxInternet.Margin = new Padding(2, 2, 2, 2);
            boxInternet.Name = "boxInternet";
            boxInternet.Size = new Size(110, 58);
            boxInternet.SizeMode = PictureBoxSizeMode.StretchImage;
            boxInternet.TabIndex = 7;
            boxInternet.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(16, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 8;
            label1.Text = "Internet";
            // 
            // boxFolder
            // 
            boxFolder.BackgroundImage = (Image)resources.GetObject("boxFolder.BackgroundImage");
            boxFolder.Image = (Image)resources.GetObject("boxFolder.Image");
            boxFolder.Location = new Point(71, 163);
            boxFolder.Margin = new Padding(2, 2, 2, 2);
            boxFolder.Name = "boxFolder";
            boxFolder.Size = new Size(70, 62);
            boxFolder.SizeMode = PictureBoxSizeMode.StretchImage;
            boxFolder.TabIndex = 9;
            boxFolder.TabStop = false;
            boxFolder.Click += boxFolder_Click;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.ForeColor = SystemColors.ControlLightLight;
            lblFolder.Image = (Image)resources.GetObject("lblFolder.Image");
            lblFolder.Location = new Point(79, 227);
            lblFolder.Margin = new Padding(2, 0, 2, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(56, 15);
            lblFolder.TabIndex = 10;
            lblFolder.Text = "Directory";
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // Mail
            // 
            Mail.Location = new Point(2, 99);
            Mail.Name = "Mail";
            Mail.Size = new Size(89, 50);
            Mail.TabIndex = 12;
            Mail.TabStop = false;
            Mail.Click += Mail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 152);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.ForeColor = SystemColors.ControlLightLight;
            lblMail.Location = new Point(25, 152);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 14;
            lblMail.Text = "Mail";
            // 
            // windows_bg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(686, 415);
            Controls.Add(lblMail);
            Controls.Add(label2);
            Controls.Add(Mail);
            Controls.Add(txtTime);
            Controls.Add(lbl_boxQuiz);
            Controls.Add(boxQuiz);
            Controls.Add(lblFolder);
            Controls.Add(boxFolder);
            Controls.Add(label1);
            Controls.Add(boxInternet);
            DoubleBuffered = true;
            IsMdiContainer = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "windows_bg";
            Text = "Window";
            ((System.ComponentModel.ISupportInitialize)boxQuiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxInternet).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox boxQuiz;
        private Label lbl_boxQuiz;
        private TextBox txtTime;
        private PictureBox boxInternet;
        private Label label1;
        private PictureBox boxFolder;
        private Label lblFolder;
        private OpenFileDialog ofd;
        private PictureBox Mail;
        private Label label2;
        private Label lblMail;
    }
}
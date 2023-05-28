using System.Drawing;

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
            boxFolder = new PictureBox();
            lblFolder = new Label();
            ofd = new OpenFileDialog();
            Mail = new PictureBox();
            label2 = new Label();
            lblMail = new Label();
            boxStartMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)boxQuiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxStartMenu).BeginInit();
            SuspendLayout();
            // 
            // boxQuiz
            // 
            boxQuiz.BackColor = Color.Transparent;
            boxQuiz.BackgroundImage = (Image)resources.GetObject("boxQuiz.BackgroundImage");
            boxQuiz.Image = (Image)resources.GetObject("boxQuiz.Image");
            boxQuiz.Location = new Point(381, 145);
            boxQuiz.Name = "boxQuiz";
            boxQuiz.Size = new Size(81, 69);
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
            lbl_boxQuiz.Location = new Point(396, 217);
            lbl_boxQuiz.Name = "lbl_boxQuiz";
            lbl_boxQuiz.Size = new Size(45, 20);
            lbl_boxQuiz.TabIndex = 5;
            lbl_boxQuiz.Text = "QUIZ";
            // 
            // boxFolder
            // 
            boxFolder.BackgroundImage = (Image)resources.GetObject("boxFolder.BackgroundImage");
            boxFolder.Image = (Image)resources.GetObject("boxFolder.Image");
            boxFolder.Location = new Point(8, 250);
            boxFolder.Name = "boxFolder";
            boxFolder.Size = new Size(90, 83);
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
            lblFolder.Location = new Point(19, 336);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(70, 20);
            lblFolder.TabIndex = 10;
            lblFolder.Text = "Directory";
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // Mail
            // 
            Mail.BackgroundImage = (Image)resources.GetObject("Mail.BackgroundImage");
            Mail.Image = (Image)resources.GetObject("Mail.Image");
            Mail.Location = new Point(-7, 105);
            Mail.Margin = new Padding(4);
            Mail.Name = "Mail";
            Mail.Size = new Size(114, 94);
            Mail.SizeMode = PictureBoxSizeMode.StretchImage;
            Mail.TabIndex = 12;
            Mail.TabStop = false;
            Mail.Click += Mail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 203);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 13;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.ForeColor = SystemColors.ControlLightLight;
            lblMail.Image = (Image)resources.GetObject("lblMail.Image");
            lblMail.Location = new Point(29, 194);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 20);
            lblMail.TabIndex = 14;
            lblMail.Text = "Mail";
            // 
            // boxStartMenu
            // 
            boxStartMenu.Image = (Image)resources.GetObject("boxStartMenu.Image");
            boxStartMenu.Location = new Point(-1, 525);
            boxStartMenu.Name = "boxStartMenu";
            boxStartMenu.Size = new Size(84, 27);
            boxStartMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            boxStartMenu.TabIndex = 18;
            boxStartMenu.TabStop = false;
            boxStartMenu.Click += boxStartMenu_Click;
            // 
            // windows_bg
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 553);
            Controls.Add(boxStartMenu);
            Controls.Add(lblMail);
            Controls.Add(label2);
            Controls.Add(Mail);
            Controls.Add(lbl_boxQuiz);
            Controls.Add(boxQuiz);
            Controls.Add(lblFolder);
            Controls.Add(boxFolder);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "windows_bg";
            Text = "Window";
            ((System.ComponentModel.ISupportInitialize)boxQuiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mail).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxStartMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox boxQuiz;
        private Label lbl_boxQuiz;
        private PictureBox boxFolder;
        private Label lblFolder;
        private OpenFileDialog ofd;
        private PictureBox Mail;
        private Label label2;
        private Label lblMail;
        private PictureBox boxStartMenu;
    }
}
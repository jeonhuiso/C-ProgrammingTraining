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
            this.boxQuiz = new System.Windows.Forms.PictureBox();
            this.lbl_boxQuiz = new System.Windows.Forms.Label();
            this.boxFolder = new System.Windows.Forms.PictureBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.Mail = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.boxStartMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxStartMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // boxQuiz
            // 
            this.boxQuiz.BackColor = System.Drawing.Color.Transparent;
            this.boxQuiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxQuiz.BackgroundImage")));
            this.boxQuiz.Image = ((System.Drawing.Image)(resources.GetObject("boxQuiz.Image")));
            this.boxQuiz.Location = new System.Drawing.Point(381, 145);
            this.boxQuiz.Name = "boxQuiz";
            this.boxQuiz.Size = new System.Drawing.Size(81, 69);
            this.boxQuiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxQuiz.TabIndex = 3;
            this.boxQuiz.TabStop = false;
            this.boxQuiz.Click += new System.EventHandler(this.boxQuiz_Click);
            // 
            // lbl_boxQuiz
            // 
            this.lbl_boxQuiz.AutoSize = true;
            this.lbl_boxQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_boxQuiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_boxQuiz.Image = ((System.Drawing.Image)(resources.GetObject("lbl_boxQuiz.Image")));
            this.lbl_boxQuiz.Location = new System.Drawing.Point(396, 217);
            this.lbl_boxQuiz.Name = "lbl_boxQuiz";
            this.lbl_boxQuiz.Size = new System.Drawing.Size(41, 15);
            this.lbl_boxQuiz.TabIndex = 5;
            this.lbl_boxQuiz.Text = "QUIZ";
            // 
            // boxFolder
            // 
            this.boxFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxFolder.BackgroundImage")));
            this.boxFolder.Image = ((System.Drawing.Image)(resources.GetObject("boxFolder.Image")));
            this.boxFolder.Location = new System.Drawing.Point(8, 250);
            this.boxFolder.Name = "boxFolder";
            this.boxFolder.Size = new System.Drawing.Size(90, 83);
            this.boxFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxFolder.TabIndex = 9;
            this.boxFolder.TabStop = false;
            this.boxFolder.Click += new System.EventHandler(this.boxFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFolder.Image = ((System.Drawing.Image)(resources.GetObject("lblFolder.Image")));
            this.lblFolder.Location = new System.Drawing.Point(19, 336);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(65, 15);
            this.lblFolder.TabIndex = 10;
            this.lblFolder.Text = "Directory";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Mail
            // 
            this.Mail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mail.BackgroundImage")));
            this.Mail.Image = ((System.Drawing.Image)(resources.GetObject("Mail.Image")));
            this.Mail.Location = new System.Drawing.Point(-7, 105);
            this.Mail.Margin = new System.Windows.Forms.Padding(4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(114, 94);
            this.Mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mail.TabIndex = 12;
            this.Mail.TabStop = false;
            this.Mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMail.Image = ((System.Drawing.Image)(resources.GetObject("lblMail.Image")));
            this.lblMail.Location = new System.Drawing.Point(29, 194);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 15);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "Mail";
            // 
            // boxStartMenu
            // 
            this.boxStartMenu.Image = ((System.Drawing.Image)(resources.GetObject("boxStartMenu.Image")));
            this.boxStartMenu.Location = new System.Drawing.Point(-1, 525);
            this.boxStartMenu.Name = "boxStartMenu";
            this.boxStartMenu.Size = new System.Drawing.Size(84, 27);
            this.boxStartMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxStartMenu.TabIndex = 18;
            this.boxStartMenu.TabStop = false;
            this.boxStartMenu.Click += new System.EventHandler(this.boxStartMenu_Click);
            // 
            // windows_bg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.boxStartMenu);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.lbl_boxQuiz);
            this.Controls.Add(this.boxQuiz);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.boxFolder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "windows_bg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Window";
            ((System.ComponentModel.ISupportInitialize)(this.boxQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxStartMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
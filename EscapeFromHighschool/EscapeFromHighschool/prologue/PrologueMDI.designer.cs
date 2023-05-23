
namespace EscapeFromHighschool
{
    partial class PrologueMDI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrologueMain = new System.Windows.Forms.Panel();
            this.PrologueImage = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.StartMain.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartMain
            // 
            this.StartMain.Controls.Add(this.btnExit);
            this.StartMain.Controls.Add(this.btnStart);
            this.StartMain.Controls.Add(this.label1);
            this.StartMain.Location = new System.Drawing.Point(0, 0);
            this.StartMain.Name = "StartMain";
            this.StartMain.Size = new System.Drawing.Size(900, 800);
            this.StartMain.TabIndex = 3;
            this.StartMain.Paint += new System.Windows.Forms.PaintEventHandler(this.StartMain_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 553);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(370, 460);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F);
            this.label1.Location = new System.Drawing.Point(300, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escape From HighSchool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrologueMain
            // 
            this.PrologueMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.PrologueMain.Location = new System.Drawing.Point(0, 0);
            this.PrologueMain.Name = "PrologueMain";
            this.PrologueMain.Size = new System.Drawing.Size(900, 600);
            this.PrologueMain.TabIndex = 4;
            // 
            // PrologueImage
            // 
            this.PrologueImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.PrologueImage.ImageSize = new System.Drawing.Size(256, 256);
            this.PrologueImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenu.Controls.Add(this.button4);
            this.MainMenu.Controls.Add(this.button3);
            this.MainMenu.Controls.Add(this.button2);
            this.MainMenu.Controls.Add(this.btnLibrary);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(900, 600);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Visible = false;
            this.MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(658, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(162, 93);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnLibrary.TabIndex = 0;
            this.btnLibrary.Text = "button1";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // PrologueMDI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.StartMain);
            this.Controls.Add(this.PrologueMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "PrologueMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MDIContainer_Load);
            this.StartMain.ResumeLayout(false);
            this.StartMain.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel PrologueMain;
        private System.Windows.Forms.ImageList PrologueImage;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLibrary;
    }
}


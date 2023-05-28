
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrologueMDI));
            this.StartMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrologueMain = new System.Windows.Forms.Panel();
            this.PrologueImage = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.Panel();
            this.btnAuditorium = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnScience = new System.Windows.Forms.Button();
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
            this.PrologueMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrologueMain.Location = new System.Drawing.Point(0, 0);
            this.PrologueMain.Name = "PrologueMain";
            this.PrologueMain.Size = new System.Drawing.Size(900, 600);
            this.PrologueMain.TabIndex = 4;
            // 
            // PrologueImage
            // 
            this.PrologueImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.PrologueImage.ImageSize = new System.Drawing.Size(16, 16);
            this.PrologueImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMenu.BackgroundImage")));
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenu.Controls.Add(this.btnAuditorium);
            this.MainMenu.Controls.Add(this.btnComputer);
            this.MainMenu.Controls.Add(this.btnScience);
            this.MainMenu.Controls.Add(this.btnLibrary);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(900, 600);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Visible = false;
            this.MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            // 
            // btnAuditorium
            // 
            this.btnAuditorium.BackColor = System.Drawing.Color.Transparent;
            this.btnAuditorium.FlatAppearance.BorderSize = 0;
            this.btnAuditorium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditorium.Location = new System.Drawing.Point(697, 324);
            this.btnAuditorium.Name = "btnAuditorium";
            this.btnAuditorium.Size = new System.Drawing.Size(181, 175);
            this.btnAuditorium.TabIndex = 0;
            this.btnAuditorium.UseVisualStyleBackColor = false;
            this.btnAuditorium.Click += new System.EventHandler(this.btnAuditorium_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.Transparent;
            this.btnComputer.FlatAppearance.BorderSize = 0;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Location = new System.Drawing.Point(22, 348);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(158, 73);
            this.btnComputer.TabIndex = 0;
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnScience
            // 
            this.btnScience.BackColor = System.Drawing.Color.Transparent;
            this.btnScience.FlatAppearance.BorderSize = 0;
            this.btnScience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScience.Location = new System.Drawing.Point(424, 306);
            this.btnScience.Name = "btnScience";
            this.btnScience.Size = new System.Drawing.Size(134, 102);
            this.btnScience.TabIndex = 0;
            this.btnScience.UseVisualStyleBackColor = false;
            this.btnScience.Click += new System.EventHandler(this.btnScience_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.Transparent;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Location = new System.Drawing.Point(31, 206);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(149, 83);
            this.btnLibrary.TabIndex = 0;
            this.btnLibrary.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel PrologueMain;
        private System.Windows.Forms.ImageList PrologueImage;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button btnAuditorium;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnScience;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnExit;
    }
}


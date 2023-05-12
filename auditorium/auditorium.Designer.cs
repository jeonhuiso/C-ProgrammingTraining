
namespace auditorium
{
    partial class auditorium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auditorium));
            this.maze_no_start = new System.Windows.Forms.Button();
            this.maze_timer = new System.Windows.Forms.Timer(this.components);
            this.maze_Start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maze_no_start
            // 
            this.maze_no_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maze_no_start.BackgroundImage")));
            this.maze_no_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maze_no_start.Dock = System.Windows.Forms.DockStyle.Right;
            this.maze_no_start.Font = new System.Drawing.Font("맑은 고딕", 24F);
            this.maze_no_start.Location = new System.Drawing.Point(450, 0);
            this.maze_no_start.Name = "maze_no_start";
            this.maze_no_start.Size = new System.Drawing.Size(450, 600);
            this.maze_no_start.TabIndex = 7;
            this.maze_no_start.Text = "\r\n문을 닫는다";
            this.maze_no_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maze_no_start.UseVisualStyleBackColor = true;
            this.maze_no_start.Click += new System.EventHandler(this.maze_no_start_Click);
            // 
            // maze_Start
            // 
            this.maze_Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maze_Start.BackgroundImage")));
            this.maze_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maze_Start.Dock = System.Windows.Forms.DockStyle.Left;
            this.maze_Start.Font = new System.Drawing.Font("맑은 고딕", 24F);
            this.maze_Start.Location = new System.Drawing.Point(0, 0);
            this.maze_Start.Name = "maze_Start";
            this.maze_Start.Size = new System.Drawing.Size(450, 600);
            this.maze_Start.TabIndex = 8;
            this.maze_Start.Text = "\r\n미로 탈출을 한다\r\n";
            this.maze_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maze_Start.UseVisualStyleBackColor = true;
            this.maze_Start.Click += new System.EventHandler(this.maze_Start_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maze_Start);
            this.panel1.Controls.Add(this.maze_no_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.TabIndex = 11;
            // 
            // auditorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "auditorium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maze_no_start;
        private System.Windows.Forms.Timer maze_timer;
        private System.Windows.Forms.Button maze_Start;
        private System.Windows.Forms.Panel panel1;
    }
}


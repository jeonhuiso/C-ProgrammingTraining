
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
            this.maze_timer = new System.Windows.Forms.Timer(this.components);
            this.maze_Start = new System.Windows.Forms.Button();
            this.maze_no_start = new System.Windows.Forms.Button();
            this.pic_maze_game = new System.Windows.Forms.PictureBox();
            this.txt_game_ex = new System.Windows.Forms.TextBox();
            this.btn_maze_explain = new System.Windows.Forms.Button();
            this.pic_game_ex_1_1 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_1 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_1_2 = new System.Windows.Forms.PictureBox();
            this.pic_game_ex_2_1 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_2 = new System.Windows.Forms.TextBox();
            this.txt_game_ex_3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maze_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // maze_Start
            // 
            this.maze_Start.BackgroundImage = global::auditorium.Properties.Resources.open_door;
            this.maze_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maze_Start.Dock = System.Windows.Forms.DockStyle.Left;
            this.maze_Start.Font = new System.Drawing.Font("맑은 고딕", 24F);
            this.maze_Start.Location = new System.Drawing.Point(0, 0);
            this.maze_Start.Name = "maze_Start";
            this.maze_Start.Size = new System.Drawing.Size(450, 600);
            this.maze_Start.TabIndex = 14;
            this.maze_Start.Text = "\r\n들어간다.\r\n";
            this.maze_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maze_Start.UseVisualStyleBackColor = true;
            this.maze_Start.Click += new System.EventHandler(this.maze_Start_Click);
            // 
            // maze_no_start
            // 
            this.maze_no_start.BackgroundImage = global::auditorium.Properties.Resources.close_door;
            this.maze_no_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maze_no_start.Dock = System.Windows.Forms.DockStyle.Right;
            this.maze_no_start.Font = new System.Drawing.Font("맑은 고딕", 24F);
            this.maze_no_start.Location = new System.Drawing.Point(450, 0);
            this.maze_no_start.Name = "maze_no_start";
            this.maze_no_start.Size = new System.Drawing.Size(450, 600);
            this.maze_no_start.TabIndex = 13;
            this.maze_no_start.Text = "\r\n들어가지 않는다.";
            this.maze_no_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maze_no_start.UseVisualStyleBackColor = true;
            this.maze_no_start.Click += new System.EventHandler(this.maze_no_start_Click);
            // 
            // pic_maze_game
            // 
            this.pic_maze_game.BackColor = System.Drawing.Color.White;
            this.pic_maze_game.BackgroundImage = global::auditorium.Properties.Resources.tablet;
            this.pic_maze_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_maze_game.Location = new System.Drawing.Point(0, 0);
            this.pic_maze_game.Name = "pic_maze_game";
            this.pic_maze_game.Size = new System.Drawing.Size(900, 600);
            this.pic_maze_game.TabIndex = 15;
            this.pic_maze_game.TabStop = false;
            this.pic_maze_game.Visible = false;
            // 
            // txt_game_ex
            // 
            this.txt_game_ex.BackColor = System.Drawing.Color.White;
            this.txt_game_ex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_game_ex.Location = new System.Drawing.Point(351, 41);
            this.txt_game_ex.Name = "txt_game_ex";
            this.txt_game_ex.ReadOnly = true;
            this.txt_game_ex.Size = new System.Drawing.Size(150, 46);
            this.txt_game_ex.TabIndex = 18;
            this.txt_game_ex.Text = "미로 탈출";
            this.txt_game_ex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_game_ex.Visible = false;
            // 
            // btn_maze_explain
            // 
            this.btn_maze_explain.BackColor = System.Drawing.Color.White;
            this.btn_maze_explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maze_explain.Location = new System.Drawing.Point(358, 496);
            this.btn_maze_explain.Name = "btn_maze_explain";
            this.btn_maze_explain.Size = new System.Drawing.Size(140, 60);
            this.btn_maze_explain.TabIndex = 17;
            this.btn_maze_explain.Text = "게임 시작";
            this.btn_maze_explain.UseVisualStyleBackColor = false;
            this.btn_maze_explain.Visible = false;
            this.btn_maze_explain.Click += new System.EventHandler(this.btn_maze_explain_Click);
            // 
            // pic_game_ex_1_1
            // 
            this.pic_game_ex_1_1.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_1_1.BackgroundImage = global::auditorium.Properties.Resources.enemy_s_;
            this.pic_game_ex_1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_1.Location = new System.Drawing.Point(196, 129);
            this.pic_game_ex_1_1.Name = "pic_game_ex_1_1";
            this.pic_game_ex_1_1.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_1_1.TabIndex = 21;
            this.pic_game_ex_1_1.TabStop = false;
            this.pic_game_ex_1_1.Visible = false;
            // 
            // txt_game_ex_1
            // 
            this.txt_game_ex_1.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_1.Location = new System.Drawing.Point(283, 141);
            this.txt_game_ex_1.Multiline = true;
            this.txt_game_ex_1.Name = "txt_game_ex_1";
            this.txt_game_ex_1.ReadOnly = true;
            this.txt_game_ex_1.Size = new System.Drawing.Size(406, 39);
            this.txt_game_ex_1.TabIndex = 34;
            this.txt_game_ex_1.Text = "적을 피해 퍼즐을 풀고, 미로를 탈출해라.";
            this.txt_game_ex_1.Visible = false;
            // 
            // pic_game_ex_1_2
            // 
            this.pic_game_ex_1_2.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_1_2.BackgroundImage = global::auditorium.Properties.Resources.game;
            this.pic_game_ex_1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_2.Location = new System.Drawing.Point(196, 253);
            this.pic_game_ex_1_2.Name = "pic_game_ex_1_2";
            this.pic_game_ex_1_2.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_1_2.TabIndex = 35;
            this.pic_game_ex_1_2.TabStop = false;
            this.pic_game_ex_1_2.Visible = false;
            // 
            // pic_game_ex_2_1
            // 
            this.pic_game_ex_2_1.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_2_1.BackgroundImage = global::auditorium.Properties.Resources.me_s_;
            this.pic_game_ex_2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_2_1.Location = new System.Drawing.Point(196, 382);
            this.pic_game_ex_2_1.Name = "pic_game_ex_2_1";
            this.pic_game_ex_2_1.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_2_1.TabIndex = 37;
            this.pic_game_ex_2_1.TabStop = false;
            this.pic_game_ex_2_1.Visible = false;
            // 
            // txt_game_ex_2
            // 
            this.txt_game_ex_2.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_2.Location = new System.Drawing.Point(283, 253);
            this.txt_game_ex_2.Multiline = true;
            this.txt_game_ex_2.Name = "txt_game_ex_2";
            this.txt_game_ex_2.ReadOnly = true;
            this.txt_game_ex_2.Size = new System.Drawing.Size(430, 76);
            this.txt_game_ex_2.TabIndex = 38;
            this.txt_game_ex_2.Text = "3개의 퍼즐을 모두 풀어야 탈출이 가능하다.\r\n푸는 동안에도 시간은 지나간다.\r\n";
            this.txt_game_ex_2.Visible = false;
            // 
            // txt_game_ex_3
            // 
            this.txt_game_ex_3.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_3.Location = new System.Drawing.Point(283, 395);
            this.txt_game_ex_3.Multiline = true;
            this.txt_game_ex_3.Name = "txt_game_ex_3";
            this.txt_game_ex_3.ReadOnly = true;
            this.txt_game_ex_3.Size = new System.Drawing.Size(418, 50);
            this.txt_game_ex_3.TabIndex = 39;
            this.txt_game_ex_3.Text = "주인공은 방향키를 이용해 이동할 수 있다.";
            this.txt_game_ex_3.Visible = false;
            // 
            // auditorium
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.txt_game_ex_3);
            this.Controls.Add(this.txt_game_ex_2);
            this.Controls.Add(this.pic_game_ex_2_1);
            this.Controls.Add(this.pic_game_ex_1_2);
            this.Controls.Add(this.pic_game_ex_1_1);
            this.Controls.Add(this.txt_game_ex_1);
            this.Controls.Add(this.txt_game_ex);
            this.Controls.Add(this.btn_maze_explain);
            this.Controls.Add(this.pic_maze_game);
            this.Controls.Add(this.maze_Start);
            this.Controls.Add(this.maze_no_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "auditorium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_maze_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer maze_timer;
        private System.Windows.Forms.Button maze_Start;
        private System.Windows.Forms.Button maze_no_start;
        private System.Windows.Forms.PictureBox pic_maze_game;
        private System.Windows.Forms.TextBox txt_game_ex;
        private System.Windows.Forms.Button btn_maze_explain;
        private System.Windows.Forms.PictureBox pic_game_ex_1_1;
        private System.Windows.Forms.TextBox txt_game_ex_1;
        private System.Windows.Forms.PictureBox pic_game_ex_1_2;
        private System.Windows.Forms.PictureBox pic_game_ex_2_1;
        private System.Windows.Forms.TextBox txt_game_ex_2;
        private System.Windows.Forms.TextBox txt_game_ex_3;
    }
}



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
            this.maze_timer = new System.Windows.Forms.Timer(this.components);
            this.maze_Start = new System.Windows.Forms.Button();
            this.maze_no_start = new System.Windows.Forms.Button();
            this.pic_maze_game = new System.Windows.Forms.PictureBox();
            this.btn_left_ex = new System.Windows.Forms.Button();
            this.btn_right_ex = new System.Windows.Forms.Button();
            this.txt_game_ex = new System.Windows.Forms.TextBox();
            this.btn_maze_explain = new System.Windows.Forms.Button();
            this.pic_game_ex_1_1 = new System.Windows.Forms.PictureBox();
            this.pic_game_ex_1_2 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_1_1 = new System.Windows.Forms.TextBox();
            this.txt_game_ex_1_2 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_1_3 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_1_3 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_2_1 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_2_1 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_2_2 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_2_2 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_2_3 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_2_3 = new System.Windows.Forms.TextBox();
            this.txt_game_ex_3 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maze_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_3)).BeginInit();
            this.SuspendLayout();
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
            this.maze_Start.TabIndex = 14;
            this.maze_Start.Text = "\r\n미로 탈출을 한다\r\n";
            this.maze_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maze_Start.UseVisualStyleBackColor = true;
            this.maze_Start.Click += new System.EventHandler(this.maze_Start_Click);
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
            this.maze_no_start.TabIndex = 13;
            this.maze_no_start.Text = "\r\n문을 닫는다";
            this.maze_no_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maze_no_start.UseVisualStyleBackColor = true;
            this.maze_no_start.Click += new System.EventHandler(this.maze_no_start_Click);
            // 
            // pic_maze_game
            // 
            this.pic_maze_game.BackColor = System.Drawing.Color.White;
            this.pic_maze_game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_maze_game.BackgroundImage")));
            this.pic_maze_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_maze_game.Location = new System.Drawing.Point(0, 0);
            this.pic_maze_game.Name = "pic_maze_game";
            this.pic_maze_game.Size = new System.Drawing.Size(900, 600);
            this.pic_maze_game.TabIndex = 15;
            this.pic_maze_game.TabStop = false;
            this.pic_maze_game.Visible = false;
            // 
            // btn_left_ex
            // 
            this.btn_left_ex.FlatAppearance.BorderSize = 0;
            this.btn_left_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left_ex.Location = new System.Drawing.Point(60, 250);
            this.btn_left_ex.Name = "btn_left_ex";
            this.btn_left_ex.Size = new System.Drawing.Size(50, 50);
            this.btn_left_ex.TabIndex = 20;
            this.btn_left_ex.Text = "◀";
            this.btn_left_ex.UseVisualStyleBackColor = true;
            this.btn_left_ex.Visible = false;
            this.btn_left_ex.Click += new System.EventHandler(this.btn_left_ex_Click);
            // 
            // btn_right_ex
            // 
            this.btn_right_ex.FlatAppearance.BorderSize = 0;
            this.btn_right_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right_ex.Location = new System.Drawing.Point(737, 250);
            this.btn_right_ex.Name = "btn_right_ex";
            this.btn_right_ex.Size = new System.Drawing.Size(50, 50);
            this.btn_right_ex.TabIndex = 19;
            this.btn_right_ex.Text = "▶";
            this.btn_right_ex.UseVisualStyleBackColor = true;
            this.btn_right_ex.Visible = false;
            this.btn_right_ex.Click += new System.EventHandler(this.btn_right_ex_Click);
            // 
            // txt_game_ex
            // 
            this.txt_game_ex.BackColor = System.Drawing.Color.White;
            this.txt_game_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_game_ex.Location = new System.Drawing.Point(340, 44);
            this.txt_game_ex.Name = "txt_game_ex";
            this.txt_game_ex.ReadOnly = true;
            this.txt_game_ex.Size = new System.Drawing.Size(150, 53);
            this.txt_game_ex.TabIndex = 18;
            this.txt_game_ex.Text = "미로 탈출";
            this.txt_game_ex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_game_ex.Visible = false;
            // 
            // btn_maze_explain
            // 
            this.btn_maze_explain.BackColor = System.Drawing.Color.White;
            this.btn_maze_explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_maze_explain.Location = new System.Drawing.Point(350, 493);
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
            this.pic_game_ex_1_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_1_1.BackgroundImage")));
            this.pic_game_ex_1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_1.Location = new System.Drawing.Point(119, 168);
            this.pic_game_ex_1_1.Name = "pic_game_ex_1_1";
            this.pic_game_ex_1_1.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_1_1.TabIndex = 21;
            this.pic_game_ex_1_1.TabStop = false;
            this.pic_game_ex_1_1.Visible = false;
            // 
            // pic_game_ex_1_2
            // 
            this.pic_game_ex_1_2.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_1_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_1_2.BackgroundImage")));
            this.pic_game_ex_1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_2.InitialImage = null;
            this.pic_game_ex_1_2.Location = new System.Drawing.Point(119, 281);
            this.pic_game_ex_1_2.Name = "pic_game_ex_1_2";
            this.pic_game_ex_1_2.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_1_2.TabIndex = 22;
            this.pic_game_ex_1_2.TabStop = false;
            this.pic_game_ex_1_2.Visible = false;
            // 
            // txt_game_ex_1_1
            // 
            this.txt_game_ex_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_1_1.Location = new System.Drawing.Point(207, 143);
            this.txt_game_ex_1_1.Multiline = true;
            this.txt_game_ex_1_1.Name = "txt_game_ex_1_1";
            this.txt_game_ex_1_1.ReadOnly = true;
            this.txt_game_ex_1_1.Size = new System.Drawing.Size(500, 107);
            this.txt_game_ex_1_1.TabIndex = 33;
            this.txt_game_ex_1_1.Text = "주인공입니다. \r\n주인공을 방향키를 이용해 미로를 탈줄하면 됩니다.\r\n미로 탈출은 뚫려있는 부분으로 탈출을 하면됩니다.";
            this.txt_game_ex_1_1.Visible = false;
            // 
            // txt_game_ex_1_2
            // 
            this.txt_game_ex_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_1_2.Location = new System.Drawing.Point(202, 273);
            this.txt_game_ex_1_2.Multiline = true;
            this.txt_game_ex_1_2.Name = "txt_game_ex_1_2";
            this.txt_game_ex_1_2.ReadOnly = true;
            this.txt_game_ex_1_2.Size = new System.Drawing.Size(531, 78);
            this.txt_game_ex_1_2.TabIndex = 34;
            this.txt_game_ex_1_2.Text = "적입니다.\r\n주인공이 적에게 잡히게 되면, 처음 위치로 이동합니다.";
            this.txt_game_ex_1_2.Visible = false;
            // 
            // pic_game_ex_1_3
            // 
            this.pic_game_ex_1_3.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_1_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_1_3.BackgroundImage")));
            this.pic_game_ex_1_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_3.InitialImage = null;
            this.pic_game_ex_1_3.Location = new System.Drawing.Point(119, 407);
            this.pic_game_ex_1_3.Name = "pic_game_ex_1_3";
            this.pic_game_ex_1_3.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_1_3.TabIndex = 35;
            this.pic_game_ex_1_3.TabStop = false;
            this.pic_game_ex_1_3.Visible = false;
            // 
            // txt_game_ex_1_3
            // 
            this.txt_game_ex_1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_1_3.Location = new System.Drawing.Point(198, 415);
            this.txt_game_ex_1_3.Multiline = true;
            this.txt_game_ex_1_3.Name = "txt_game_ex_1_3";
            this.txt_game_ex_1_3.ReadOnly = true;
            this.txt_game_ex_1_3.Size = new System.Drawing.Size(532, 43);
            this.txt_game_ex_1_3.TabIndex = 36;
            this.txt_game_ex_1_3.Text = "주인공은 뚫려있는 부분으로 미로를 탈출하면 됩니다.";
            this.txt_game_ex_1_3.Visible = false;
            // 
            // pic_game_ex_2_1
            // 
            this.pic_game_ex_2_1.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_2_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_2_1.BackgroundImage")));
            this.pic_game_ex_2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_2_1.Location = new System.Drawing.Point(119, 168);
            this.pic_game_ex_2_1.Name = "pic_game_ex_2_1";
            this.pic_game_ex_2_1.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_2_1.TabIndex = 37;
            this.pic_game_ex_2_1.TabStop = false;
            this.pic_game_ex_2_1.Visible = false;
            // 
            // txt_game_ex_2_1
            // 
            this.txt_game_ex_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_2_1.Location = new System.Drawing.Point(197, 161);
            this.txt_game_ex_2_1.Multiline = true;
            this.txt_game_ex_2_1.Name = "txt_game_ex_2_1";
            this.txt_game_ex_2_1.ReadOnly = true;
            this.txt_game_ex_2_1.Size = new System.Drawing.Size(532, 74);
            this.txt_game_ex_2_1.TabIndex = 38;
            this.txt_game_ex_2_1.Text = "미로를 탈출하면서 테블릿으로 가서 퍼즐을 풀면됩니다.\r\n모든 퍼즐을 한 번씩 해야 탈출이 가능합니다.";
            this.txt_game_ex_2_1.Visible = false;
            // 
            // pic_game_ex_2_2
            // 
            this.pic_game_ex_2_2.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_2_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_2_2.BackgroundImage")));
            this.pic_game_ex_2_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_2_2.Location = new System.Drawing.Point(119, 281);
            this.pic_game_ex_2_2.Name = "pic_game_ex_2_2";
            this.pic_game_ex_2_2.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_2_2.TabIndex = 39;
            this.pic_game_ex_2_2.TabStop = false;
            this.pic_game_ex_2_2.Visible = false;
            // 
            // txt_game_ex_2_2
            // 
            this.txt_game_ex_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_2_2.Location = new System.Drawing.Point(198, 273);
            this.txt_game_ex_2_2.Multiline = true;
            this.txt_game_ex_2_2.Name = "txt_game_ex_2_2";
            this.txt_game_ex_2_2.ReadOnly = true;
            this.txt_game_ex_2_2.Size = new System.Drawing.Size(482, 74);
            this.txt_game_ex_2_2.TabIndex = 40;
            this.txt_game_ex_2_2.Text = "길입니다. \r\n주인공과 적은 길을 통해서만 이동이 가능합니다.";
            this.txt_game_ex_2_2.Visible = false;
            // 
            // pic_game_ex_2_3
            // 
            this.pic_game_ex_2_3.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_2_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_2_3.BackgroundImage")));
            this.pic_game_ex_2_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_2_3.Location = new System.Drawing.Point(119, 407);
            this.pic_game_ex_2_3.Name = "pic_game_ex_2_3";
            this.pic_game_ex_2_3.Size = new System.Drawing.Size(60, 60);
            this.pic_game_ex_2_3.TabIndex = 41;
            this.pic_game_ex_2_3.TabStop = false;
            this.pic_game_ex_2_3.Visible = false;
            // 
            // txt_game_ex_2_3
            // 
            this.txt_game_ex_2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_2_3.Location = new System.Drawing.Point(198, 396);
            this.txt_game_ex_2_3.Multiline = true;
            this.txt_game_ex_2_3.Name = "txt_game_ex_2_3";
            this.txt_game_ex_2_3.ReadOnly = true;
            this.txt_game_ex_2_3.Size = new System.Drawing.Size(482, 77);
            this.txt_game_ex_2_3.TabIndex = 42;
            this.txt_game_ex_2_3.Text = "벽입니다.\r\n주인공과 적은 벽을 통과해서 이동할 수 없습니다.";
            this.txt_game_ex_2_3.Visible = false;
            // 
            // txt_game_ex_3
            // 
            this.txt_game_ex_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_3.Location = new System.Drawing.Point(194, 292);
            this.txt_game_ex_3.Multiline = true;
            this.txt_game_ex_3.Name = "txt_game_ex_3";
            this.txt_game_ex_3.ReadOnly = true;
            this.txt_game_ex_3.Size = new System.Drawing.Size(486, 78);
            this.txt_game_ex_3.TabIndex = 44;
            this.txt_game_ex_3.Text = "시간이 600이 되면 미로 탈출에 실패하게 됩니다.\r\n시간이 모두 지나기 전에 탈출하세요.";
            this.txt_game_ex_3.Visible = false;
            // 
            // pic_game_ex_3
            // 
            this.pic_game_ex_3.BackColor = System.Drawing.Color.White;
            this.pic_game_ex_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_game_ex_3.BackgroundImage")));
            this.pic_game_ex_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_3.Location = new System.Drawing.Point(340, 207);
            this.pic_game_ex_3.Name = "pic_game_ex_3";
            this.pic_game_ex_3.Size = new System.Drawing.Size(139, 60);
            this.pic_game_ex_3.TabIndex = 43;
            this.pic_game_ex_3.TabStop = false;
            this.pic_game_ex_3.Visible = false;
            // 
            // auditorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.txt_game_ex_3);
            this.Controls.Add(this.pic_game_ex_3);
            this.Controls.Add(this.txt_game_ex_2_3);
            this.Controls.Add(this.pic_game_ex_2_3);
            this.Controls.Add(this.txt_game_ex_2_2);
            this.Controls.Add(this.pic_game_ex_2_2);
            this.Controls.Add(this.txt_game_ex_2_1);
            this.Controls.Add(this.pic_game_ex_2_1);
            this.Controls.Add(this.txt_game_ex_1_3);
            this.Controls.Add(this.pic_game_ex_1_3);
            this.Controls.Add(this.txt_game_ex_1_2);
            this.Controls.Add(this.txt_game_ex_1_1);
            this.Controls.Add(this.pic_game_ex_1_2);
            this.Controls.Add(this.pic_game_ex_1_1);
            this.Controls.Add(this.btn_left_ex);
            this.Controls.Add(this.btn_right_ex);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer maze_timer;
        private System.Windows.Forms.Button maze_Start;
        private System.Windows.Forms.Button maze_no_start;
        private System.Windows.Forms.PictureBox pic_maze_game;
        private System.Windows.Forms.Button btn_left_ex;
        private System.Windows.Forms.Button btn_right_ex;
        private System.Windows.Forms.TextBox txt_game_ex;
        private System.Windows.Forms.Button btn_maze_explain;
        private System.Windows.Forms.PictureBox pic_game_ex_1_1;
        private System.Windows.Forms.PictureBox pic_game_ex_1_2;
        private System.Windows.Forms.TextBox txt_game_ex_1_1;
        private System.Windows.Forms.TextBox txt_game_ex_1_2;
        private System.Windows.Forms.PictureBox pic_game_ex_1_3;
        private System.Windows.Forms.TextBox txt_game_ex_1_3;
        private System.Windows.Forms.PictureBox pic_game_ex_2_1;
        private System.Windows.Forms.TextBox txt_game_ex_2_1;
        private System.Windows.Forms.PictureBox pic_game_ex_2_2;
        private System.Windows.Forms.TextBox txt_game_ex_2_2;
        private System.Windows.Forms.PictureBox pic_game_ex_2_3;
        private System.Windows.Forms.TextBox txt_game_ex_2_3;
        private System.Windows.Forms.TextBox txt_game_ex_3;
        private System.Windows.Forms.PictureBox pic_game_ex_3;
    }
}


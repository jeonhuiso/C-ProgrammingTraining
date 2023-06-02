
namespace auditorium
{
    partial class maze
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maze));
            this.maze_timer = new System.Windows.Forms.Timer(this.components);
            this.maze_image = new System.Windows.Forms.ImageList(this.components);
            this.total_timer = new System.Windows.Forms.Label();
            this.main_character_img = new System.Windows.Forms.ImageList(this.components);
            this.enemy_image = new System.Windows.Forms.ImageList(this.components);
            this.puzzle_timer = new System.Windows.Forms.Timer(this.components);
            this.pan_maze = new System.Windows.Forms.Panel();
            this.maze_all_puzzle = new System.Windows.Forms.Button();
            this.key_btn_9 = new System.Windows.Forms.Button();
            this.key_btn_8 = new System.Windows.Forms.Button();
            this.key_btn_7 = new System.Windows.Forms.Button();
            this.key_btn_6 = new System.Windows.Forms.Button();
            this.key_btn_5 = new System.Windows.Forms.Button();
            this.key_btn_4 = new System.Windows.Forms.Button();
            this.key_btn_3 = new System.Windows.Forms.Button();
            this.key_btn_2 = new System.Windows.Forms.Button();
            this.key_btn_1 = new System.Windows.Forms.Button();
            this.btn_key_third = new System.Windows.Forms.Button();
            this.btn_key_second = new System.Windows.Forms.Button();
            this.btn_key_first = new System.Windows.Forms.Button();
            this.puzzle_key = new System.Windows.Forms.Button();
            this.maze_no_all_puzzle = new System.Windows.Forms.Button();
            this.time_over = new System.Windows.Forms.Button();
            this.fail_maze = new System.Windows.Forms.Button();
            this.enemy_deteching = new System.Windows.Forms.Timer(this.components);
            this.open_door_timer = new System.Windows.Forms.Timer(this.components);
            this.pan_maze.SuspendLayout();
            this.SuspendLayout();
            // 
            // maze_timer
            // 
            this.maze_timer.Enabled = true;
            this.maze_timer.Interval = 1000;
            this.maze_timer.Tick += new System.EventHandler(this.maze_tick);
            // 
            // maze_image
            // 
            this.maze_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("maze_image.ImageStream")));
            this.maze_image.TransparentColor = System.Drawing.Color.Transparent;
            this.maze_image.Images.SetKeyName(0, "road.png");
            this.maze_image.Images.SetKeyName(1, "wall.png");
            this.maze_image.Images.SetKeyName(2, "game.png");
            this.maze_image.Images.SetKeyName(3, "check_open.png");
            this.maze_image.Images.SetKeyName(4, "check_close.png");
            // 
            // total_timer
            // 
            this.total_timer.AutoSize = true;
            this.total_timer.BackColor = System.Drawing.Color.White;
            this.total_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_timer.Location = new System.Drawing.Point(54, 40);
            this.total_timer.Name = "total_timer";
            this.total_timer.Size = new System.Drawing.Size(107, 36);
            this.total_timer.TabIndex = 4;
            this.total_timer.Text = "600 / 0";
            // 
            // main_character_img
            // 
            this.main_character_img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("main_character_img.ImageStream")));
            this.main_character_img.TransparentColor = System.Drawing.Color.Transparent;
            this.main_character_img.Images.SetKeyName(0, "me(e).png");
            this.main_character_img.Images.SetKeyName(1, "me(w).png");
            this.main_character_img.Images.SetKeyName(2, "me(s).png");
            this.main_character_img.Images.SetKeyName(3, "me(n).png");
            // 
            // enemy_image
            // 
            this.enemy_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("enemy_image.ImageStream")));
            this.enemy_image.TransparentColor = System.Drawing.Color.Transparent;
            this.enemy_image.Images.SetKeyName(0, "enemy(e).png");
            this.enemy_image.Images.SetKeyName(1, "enemy(w).png");
            this.enemy_image.Images.SetKeyName(2, "enemy(s).png");
            this.enemy_image.Images.SetKeyName(3, "enemy(n).png");
            // 
            // puzzle_timer
            // 
            this.puzzle_timer.Enabled = true;
            this.puzzle_timer.Interval = 1000;
            this.puzzle_timer.Tick += new System.EventHandler(this.puzzle_timer_Tick);
            // 
            // pan_maze
            // 
            this.pan_maze.BackgroundImage = global::auditorium.Properties.Resources.tablet;
            this.pan_maze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_maze.Controls.Add(this.maze_all_puzzle);
            this.pan_maze.Controls.Add(this.key_btn_9);
            this.pan_maze.Controls.Add(this.key_btn_8);
            this.pan_maze.Controls.Add(this.key_btn_7);
            this.pan_maze.Controls.Add(this.key_btn_6);
            this.pan_maze.Controls.Add(this.key_btn_5);
            this.pan_maze.Controls.Add(this.key_btn_4);
            this.pan_maze.Controls.Add(this.key_btn_3);
            this.pan_maze.Controls.Add(this.key_btn_2);
            this.pan_maze.Controls.Add(this.key_btn_1);
            this.pan_maze.Controls.Add(this.btn_key_third);
            this.pan_maze.Controls.Add(this.btn_key_second);
            this.pan_maze.Controls.Add(this.btn_key_first);
            this.pan_maze.Controls.Add(this.puzzle_key);
            this.pan_maze.Controls.Add(this.maze_no_all_puzzle);
            this.pan_maze.Controls.Add(this.time_over);
            this.pan_maze.Controls.Add(this.fail_maze);
            this.pan_maze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_maze.Location = new System.Drawing.Point(0, 0);
            this.pan_maze.Name = "pan_maze";
            this.pan_maze.Size = new System.Drawing.Size(900, 600);
            this.pan_maze.TabIndex = 57;
            this.pan_maze.Visible = false;
            // 
            // maze_all_puzzle
            // 
            this.maze_all_puzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.maze_all_puzzle.Location = new System.Drawing.Point(110, 49);
            this.maze_all_puzzle.Name = "maze_all_puzzle";
            this.maze_all_puzzle.Size = new System.Drawing.Size(641, 159);
            this.maze_all_puzzle.TabIndex = 58;
            this.maze_all_puzzle.Text = "모든 퍼즐을 풀었습니다.\r\n암호를 입력하시오.";
            this.maze_all_puzzle.UseVisualStyleBackColor = true;
            this.maze_all_puzzle.Visible = false;
            this.maze_all_puzzle.Click += new System.EventHandler(this.maze_all_puzzle_Click);
            // 
            // key_btn_9
            // 
            this.key_btn_9.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_9.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_9.Location = new System.Drawing.Point(480, 485);
            this.key_btn_9.Name = "key_btn_9";
            this.key_btn_9.Size = new System.Drawing.Size(70, 70);
            this.key_btn_9.TabIndex = 79;
            this.key_btn_9.Text = "9";
            this.key_btn_9.UseVisualStyleBackColor = false;
            this.key_btn_9.Visible = false;
            this.key_btn_9.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_8
            // 
            this.key_btn_8.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_8.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_8.Location = new System.Drawing.Point(380, 485);
            this.key_btn_8.Name = "key_btn_8";
            this.key_btn_8.Size = new System.Drawing.Size(70, 70);
            this.key_btn_8.TabIndex = 78;
            this.key_btn_8.Text = "8";
            this.key_btn_8.UseVisualStyleBackColor = false;
            this.key_btn_8.Visible = false;
            this.key_btn_8.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_7
            // 
            this.key_btn_7.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_7.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_7.Location = new System.Drawing.Point(280, 485);
            this.key_btn_7.Name = "key_btn_7";
            this.key_btn_7.Size = new System.Drawing.Size(70, 70);
            this.key_btn_7.TabIndex = 77;
            this.key_btn_7.Text = "7";
            this.key_btn_7.UseVisualStyleBackColor = false;
            this.key_btn_7.Visible = false;
            this.key_btn_7.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_6
            // 
            this.key_btn_6.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_6.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_6.Location = new System.Drawing.Point(480, 400);
            this.key_btn_6.Name = "key_btn_6";
            this.key_btn_6.Size = new System.Drawing.Size(70, 70);
            this.key_btn_6.TabIndex = 76;
            this.key_btn_6.Text = "6";
            this.key_btn_6.UseVisualStyleBackColor = false;
            this.key_btn_6.Visible = false;
            this.key_btn_6.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_5
            // 
            this.key_btn_5.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_5.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_5.Location = new System.Drawing.Point(380, 400);
            this.key_btn_5.Name = "key_btn_5";
            this.key_btn_5.Size = new System.Drawing.Size(70, 70);
            this.key_btn_5.TabIndex = 75;
            this.key_btn_5.Text = "5";
            this.key_btn_5.UseVisualStyleBackColor = false;
            this.key_btn_5.Visible = false;
            this.key_btn_5.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_4
            // 
            this.key_btn_4.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_4.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_4.Location = new System.Drawing.Point(280, 400);
            this.key_btn_4.Name = "key_btn_4";
            this.key_btn_4.Size = new System.Drawing.Size(70, 70);
            this.key_btn_4.TabIndex = 74;
            this.key_btn_4.Text = "4";
            this.key_btn_4.UseVisualStyleBackColor = false;
            this.key_btn_4.Visible = false;
            this.key_btn_4.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_3
            // 
            this.key_btn_3.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_3.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_3.Location = new System.Drawing.Point(480, 310);
            this.key_btn_3.Name = "key_btn_3";
            this.key_btn_3.Size = new System.Drawing.Size(70, 70);
            this.key_btn_3.TabIndex = 73;
            this.key_btn_3.Text = "3";
            this.key_btn_3.UseVisualStyleBackColor = false;
            this.key_btn_3.Visible = false;
            this.key_btn_3.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_2
            // 
            this.key_btn_2.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_2.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_2.Location = new System.Drawing.Point(380, 310);
            this.key_btn_2.Name = "key_btn_2";
            this.key_btn_2.Size = new System.Drawing.Size(70, 70);
            this.key_btn_2.TabIndex = 72;
            this.key_btn_2.Text = "2";
            this.key_btn_2.UseVisualStyleBackColor = false;
            this.key_btn_2.Visible = false;
            this.key_btn_2.Click += new System.EventHandler(this.key_insert);
            // 
            // key_btn_1
            // 
            this.key_btn_1.BackColor = System.Drawing.SystemColors.Control;
            this.key_btn_1.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.key_btn_1.Location = new System.Drawing.Point(280, 310);
            this.key_btn_1.Name = "key_btn_1";
            this.key_btn_1.Size = new System.Drawing.Size(70, 70);
            this.key_btn_1.TabIndex = 71;
            this.key_btn_1.Text = "1";
            this.key_btn_1.UseVisualStyleBackColor = false;
            this.key_btn_1.Visible = false;
            this.key_btn_1.Click += new System.EventHandler(this.key_insert);
            // 
            // btn_key_third
            // 
            this.btn_key_third.BackColor = System.Drawing.SystemColors.Control;
            this.btn_key_third.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.btn_key_third.Location = new System.Drawing.Point(530, 230);
            this.btn_key_third.Name = "btn_key_third";
            this.btn_key_third.Size = new System.Drawing.Size(140, 60);
            this.btn_key_third.TabIndex = 70;
            this.btn_key_third.Text = "third";
            this.btn_key_third.UseVisualStyleBackColor = false;
            this.btn_key_third.Visible = false;
            this.btn_key_third.Click += new System.EventHandler(this.key_btn_click);
            // 
            // btn_key_second
            // 
            this.btn_key_second.BackColor = System.Drawing.SystemColors.Control;
            this.btn_key_second.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.btn_key_second.Location = new System.Drawing.Point(345, 230);
            this.btn_key_second.Name = "btn_key_second";
            this.btn_key_second.Size = new System.Drawing.Size(140, 60);
            this.btn_key_second.TabIndex = 69;
            this.btn_key_second.Text = "second";
            this.btn_key_second.UseVisualStyleBackColor = false;
            this.btn_key_second.Visible = false;
            this.btn_key_second.Click += new System.EventHandler(this.key_btn_click);
            // 
            // btn_key_first
            // 
            this.btn_key_first.BackColor = System.Drawing.SystemColors.Control;
            this.btn_key_first.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.btn_key_first.Location = new System.Drawing.Point(170, 230);
            this.btn_key_first.Name = "btn_key_first";
            this.btn_key_first.Size = new System.Drawing.Size(140, 60);
            this.btn_key_first.TabIndex = 68;
            this.btn_key_first.Text = "first";
            this.btn_key_first.UseVisualStyleBackColor = false;
            this.btn_key_first.Visible = false;
            this.btn_key_first.Click += new System.EventHandler(this.key_btn_click);
            // 
            // puzzle_key
            // 
            this.puzzle_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.puzzle_key.Location = new System.Drawing.Point(110, 158);
            this.puzzle_key.Name = "puzzle_key";
            this.puzzle_key.Size = new System.Drawing.Size(641, 253);
            this.puzzle_key.TabIndex = 67;
            this.puzzle_key.UseVisualStyleBackColor = true;
            this.puzzle_key.Visible = false;
            this.puzzle_key.Click += new System.EventHandler(this.puzzle_key_Click);
            // 
            // maze_no_all_puzzle
            // 
            this.maze_no_all_puzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.maze_no_all_puzzle.Location = new System.Drawing.Point(92, 158);
            this.maze_no_all_puzzle.Name = "maze_no_all_puzzle";
            this.maze_no_all_puzzle.Size = new System.Drawing.Size(674, 203);
            this.maze_no_all_puzzle.TabIndex = 60;
            this.maze_no_all_puzzle.Text = "퍼즐을 모두 성공하지 못 했습니다.\r\nSin : xx9x";
            this.maze_no_all_puzzle.UseVisualStyleBackColor = true;
            this.maze_no_all_puzzle.Visible = false;
            this.maze_no_all_puzzle.Click += new System.EventHandler(this.maze_no_all_puzzle_Click);
            // 
            // time_over
            // 
            this.time_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.time_over.Location = new System.Drawing.Point(110, 214);
            this.time_over.Name = "time_over";
            this.time_over.Size = new System.Drawing.Size(641, 133);
            this.time_over.TabIndex = 59;
            this.time_over.Text = "시간 초과";
            this.time_over.UseVisualStyleBackColor = true;
            this.time_over.Click += new System.EventHandler(this.time_over_Click);
            // 
            // fail_maze
            // 
            this.fail_maze.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.fail_maze.Location = new System.Drawing.Point(122, 214);
            this.fail_maze.Name = "fail_maze";
            this.fail_maze.Size = new System.Drawing.Size(605, 133);
            this.fail_maze.TabIndex = 57;
            this.fail_maze.Text = "퍼즐을 모두 풀지 않았습니다.";
            this.fail_maze.UseVisualStyleBackColor = true;
            this.fail_maze.Click += new System.EventHandler(this.fail_maze_Click);
            // 
            // enemy_deteching
            // 
            this.enemy_deteching.Enabled = true;
            this.enemy_deteching.Tick += new System.EventHandler(this.enemy_deteching_Tick);
            // 
            // open_door_timer
            // 
            this.open_door_timer.Enabled = true;
            this.open_door_timer.Interval = 1000;
            this.open_door_timer.Tick += new System.EventHandler(this.open_door_timer_Tick);
            // 
            // maze
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::auditorium.Properties.Resources.tablet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pan_maze);
            this.Controls.Add(this.total_timer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.maze_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maze_keydown);
            this.pan_maze.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer maze_timer;
        private System.Windows.Forms.ImageList maze_image;
        private System.Windows.Forms.Label total_timer;
        private System.Windows.Forms.ImageList main_character_img;
        private System.Windows.Forms.ImageList enemy_image;
        private System.Windows.Forms.Timer puzzle_timer;
        private System.Windows.Forms.Panel pan_maze;
        private System.Windows.Forms.Button fail_maze;
        private System.Windows.Forms.Button maze_all_puzzle;
        private System.Windows.Forms.Button time_over;
        private System.Windows.Forms.Button maze_no_all_puzzle;
        private System.Windows.Forms.Timer enemy_deteching;
        private System.Windows.Forms.Button puzzle_key;
        private System.Windows.Forms.Timer open_door_timer;
        private System.Windows.Forms.Button btn_key_third;
        private System.Windows.Forms.Button btn_key_second;
        private System.Windows.Forms.Button btn_key_first;
        private System.Windows.Forms.Button key_btn_9;
        private System.Windows.Forms.Button key_btn_8;
        private System.Windows.Forms.Button key_btn_7;
        private System.Windows.Forms.Button key_btn_6;
        private System.Windows.Forms.Button key_btn_5;
        private System.Windows.Forms.Button key_btn_4;
        private System.Windows.Forms.Button key_btn_3;
        private System.Windows.Forms.Button key_btn_2;
        private System.Windows.Forms.Button key_btn_1;
    }
}
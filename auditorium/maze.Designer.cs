
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
            this.maze_no_all_puzzle = new System.Windows.Forms.Button();
            this.time_over = new System.Windows.Forms.Button();
            this.maze_all_puzzle = new System.Windows.Forms.Button();
            this.fail_maze = new System.Windows.Forms.Button();
            this.enemy_deteching = new System.Windows.Forms.Timer(this.components);
            this.txt_result_1 = new System.Windows.Forms.TextBox();
            this.txt_result_2 = new System.Windows.Forms.TextBox();
            this.txt_result_3 = new System.Windows.Forms.TextBox();
            this.lbl_result_1 = new System.Windows.Forms.Label();
            this.lbl_result_2 = new System.Windows.Forms.Label();
            this.lbl_result_3 = new System.Windows.Forms.Label();
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
            this.pan_maze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_maze.BackgroundImage")));
            this.pan_maze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_maze.Controls.Add(this.lbl_result_3);
            this.pan_maze.Controls.Add(this.lbl_result_2);
            this.pan_maze.Controls.Add(this.lbl_result_1);
            this.pan_maze.Controls.Add(this.txt_result_3);
            this.pan_maze.Controls.Add(this.txt_result_2);
            this.pan_maze.Controls.Add(this.txt_result_1);
            this.pan_maze.Controls.Add(this.maze_no_all_puzzle);
            this.pan_maze.Controls.Add(this.time_over);
            this.pan_maze.Controls.Add(this.maze_all_puzzle);
            this.pan_maze.Controls.Add(this.fail_maze);
            this.pan_maze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_maze.Location = new System.Drawing.Point(0, 0);
            this.pan_maze.Name = "pan_maze";
            this.pan_maze.Size = new System.Drawing.Size(900, 600);
            this.pan_maze.TabIndex = 57;
            // 
            // maze_no_all_puzzle
            // 
            this.maze_no_all_puzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.maze_no_all_puzzle.Location = new System.Drawing.Point(92, 214);
            this.maze_no_all_puzzle.Name = "maze_no_all_puzzle";
            this.maze_no_all_puzzle.Size = new System.Drawing.Size(674, 133);
            this.maze_no_all_puzzle.TabIndex = 60;
            this.maze_no_all_puzzle.Text = "퍼즐을 모두 성공하지 못 했습니다.";
            this.maze_no_all_puzzle.UseVisualStyleBackColor = true;
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
            // maze_all_puzzle
            // 
            this.maze_all_puzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.maze_all_puzzle.Location = new System.Drawing.Point(110, 156);
            this.maze_all_puzzle.Name = "maze_all_puzzle";
            this.maze_all_puzzle.Size = new System.Drawing.Size(641, 203);
            this.maze_all_puzzle.TabIndex = 58;
            this.maze_all_puzzle.Text = "모든 퍼즐을 풀었습니다.\r\n암호를 입력하시오.";
            this.maze_all_puzzle.UseVisualStyleBackColor = true;
            this.maze_all_puzzle.Click += new System.EventHandler(this.maze_all_puzzle_Click);
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
            // txt_result_1
            // 
            this.txt_result_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_result_1.Location = new System.Drawing.Point(158, 423);
            this.txt_result_1.Name = "txt_result_1";
            this.txt_result_1.Size = new System.Drawing.Size(100, 53);
            this.txt_result_1.TabIndex = 61;
            this.txt_result_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_result_1.Visible = false;
            // 
            // txt_result_2
            // 
            this.txt_result_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_result_2.Location = new System.Drawing.Point(368, 423);
            this.txt_result_2.Name = "txt_result_2";
            this.txt_result_2.Size = new System.Drawing.Size(100, 53);
            this.txt_result_2.TabIndex = 62;
            this.txt_result_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_result_2.Visible = false;
            // 
            // txt_result_3
            // 
            this.txt_result_3.AcceptsReturn = true;
            this.txt_result_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_result_3.Location = new System.Drawing.Point(576, 423);
            this.txt_result_3.Name = "txt_result_3";
            this.txt_result_3.Size = new System.Drawing.Size(100, 53);
            this.txt_result_3.TabIndex = 63;
            this.txt_result_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_result_3.Visible = false;
            // 
            // lbl_result_1
            // 
            this.lbl_result_1.AutoSize = true;
            this.lbl_result_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_1.Location = new System.Drawing.Point(177, 388);
            this.lbl_result_1.Name = "lbl_result_1";
            this.lbl_result_1.Size = new System.Drawing.Size(61, 32);
            this.lbl_result_1.TabIndex = 64;
            this.lbl_result_1.Text = "first";
            this.lbl_result_1.Visible = false;
            // 
            // lbl_result_2
            // 
            this.lbl_result_2.AutoSize = true;
            this.lbl_result_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_2.Location = new System.Drawing.Point(363, 388);
            this.lbl_result_2.Name = "lbl_result_2";
            this.lbl_result_2.Size = new System.Drawing.Size(107, 32);
            this.lbl_result_2.TabIndex = 65;
            this.lbl_result_2.Text = "second";
            this.lbl_result_2.Visible = false;
            // 
            // lbl_result_3
            // 
            this.lbl_result_3.AutoSize = true;
            this.lbl_result_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_3.Location = new System.Drawing.Point(591, 388);
            this.lbl_result_3.Name = "lbl_result_3";
            this.lbl_result_3.Size = new System.Drawing.Size(71, 32);
            this.lbl_result_3.TabIndex = 66;
            this.lbl_result_3.Text = "third";
            this.lbl_result_3.Visible = false;
            // 
            // maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pan_maze);
            this.Controls.Add(this.total_timer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.maze_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maze_keydown);
            this.pan_maze.ResumeLayout(false);
            this.pan_maze.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_result_3;
        private System.Windows.Forms.TextBox txt_result_2;
        private System.Windows.Forms.TextBox txt_result_1;
        private System.Windows.Forms.Label lbl_result_3;
        private System.Windows.Forms.Label lbl_result_2;
        private System.Windows.Forms.Label lbl_result_1;
    }
}
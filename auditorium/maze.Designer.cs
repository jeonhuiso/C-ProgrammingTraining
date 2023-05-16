
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
            // maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.total_timer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maze_keydown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer maze_timer;
        private System.Windows.Forms.ImageList maze_image;
        private System.Windows.Forms.Label total_timer;
        private System.Windows.Forms.ImageList main_character_img;
        private System.Windows.Forms.ImageList enemy_image;
    }
}
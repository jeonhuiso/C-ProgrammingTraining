
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
            this.check_timer = new System.Windows.Forms.Label();
            this.total_timer = new System.Windows.Forms.Label();
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
            this.maze_image.Images.SetKeyName(2, "enemy.png");
            this.maze_image.Images.SetKeyName(3, "exit.png");
            this.maze_image.Images.SetKeyName(4, "first_quiz.png");
            this.maze_image.Images.SetKeyName(5, "second_quiz.png");
            this.maze_image.Images.SetKeyName(6, "third_quiz.png");
            this.maze_image.Images.SetKeyName(7, "me.png");
            // 
            // check_timer
            // 
            this.check_timer.AutoSize = true;
            this.check_timer.BackColor = System.Drawing.Color.White;
            this.check_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_timer.Location = new System.Drawing.Point(143, 50);
            this.check_timer.Name = "check_timer";
            this.check_timer.Size = new System.Drawing.Size(26, 29);
            this.check_timer.TabIndex = 5;
            this.check_timer.Text = "0";
            // 
            // total_timer
            // 
            this.total_timer.AutoSize = true;
            this.total_timer.BackColor = System.Drawing.Color.White;
            this.total_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_timer.Location = new System.Drawing.Point(70, 50);
            this.total_timer.Name = "total_timer";
            this.total_timer.Size = new System.Drawing.Size(65, 29);
            this.total_timer.TabIndex = 4;
            this.total_timer.Text = "600 /";
            // 
            // maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.check_timer);
            this.Controls.Add(this.total_timer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.maze_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maze_keydown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer maze_timer;
        private System.Windows.Forms.ImageList maze_image;
        private System.Windows.Forms.Label check_timer;
        private System.Windows.Forms.Label total_timer;
    }
}
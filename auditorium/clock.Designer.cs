
namespace auditorium
{
    partial class clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clock));
            this.lbl_clock_level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_clock_level
            // 
            this.lbl_clock_level.AutoSize = true;
            this.lbl_clock_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_clock_level.Location = new System.Drawing.Point(75, 55);
            this.lbl_clock_level.Name = "lbl_clock_level";
            this.lbl_clock_level.Size = new System.Drawing.Size(73, 36);
            this.lbl_clock_level.TabIndex = 7;
            this.lbl_clock_level.Text = "2 / 1";
            // 
            // clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lbl_clock_level);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clock_level;
    }
}
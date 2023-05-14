
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
            this.lbl_clock_life = new System.Windows.Forms.Label();
            this.pan_clock_explain = new System.Windows.Forms.Panel();
            this.txt_clock_explain = new System.Windows.Forms.TextBox();
            this.btn_clock_explain = new System.Windows.Forms.Button();
            this.pan_clock_explain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_clock_level
            // 
            this.lbl_clock_level.AutoSize = true;
            this.lbl_clock_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_clock_level.Location = new System.Drawing.Point(54, 40);
            this.lbl_clock_level.Name = "lbl_clock_level";
            this.lbl_clock_level.Size = new System.Drawing.Size(168, 36);
            this.lbl_clock_level.TabIndex = 7;
            this.lbl_clock_level.Text = "Level : 2 / 1";
            // 
            // lbl_clock_life
            // 
            this.lbl_clock_life.AutoSize = true;
            this.lbl_clock_life.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock_life.Location = new System.Drawing.Point(54, 87);
            this.lbl_clock_life.Name = "lbl_clock_life";
            this.lbl_clock_life.Size = new System.Drawing.Size(107, 36);
            this.lbl_clock_life.TabIndex = 8;
            this.lbl_clock_life.Text = "♥ x  4";
            // 
            // pan_clock_explain
            // 
            this.pan_clock_explain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_clock_explain.BackgroundImage")));
            this.pan_clock_explain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_clock_explain.Controls.Add(this.txt_clock_explain);
            this.pan_clock_explain.Controls.Add(this.btn_clock_explain);
            this.pan_clock_explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_clock_explain.Location = new System.Drawing.Point(0, 0);
            this.pan_clock_explain.Name = "pan_clock_explain";
            this.pan_clock_explain.Size = new System.Drawing.Size(900, 600);
            this.pan_clock_explain.TabIndex = 15;
            // 
            // txt_clock_explain
            // 
            this.txt_clock_explain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_clock_explain.Location = new System.Drawing.Point(73, 56);
            this.txt_clock_explain.Multiline = true;
            this.txt_clock_explain.Name = "txt_clock_explain";
            this.txt_clock_explain.Size = new System.Drawing.Size(700, 430);
            this.txt_clock_explain.TabIndex = 1;
            // 
            // btn_clock_explain
            // 
            this.btn_clock_explain.Location = new System.Drawing.Point(380, 500);
            this.btn_clock_explain.Name = "btn_clock_explain";
            this.btn_clock_explain.Size = new System.Drawing.Size(80, 40);
            this.btn_clock_explain.TabIndex = 0;
            this.btn_clock_explain.Text = "확인";
            this.btn_clock_explain.UseVisualStyleBackColor = true;
            this.btn_clock_explain.Click += new System.EventHandler(this.btn_clock_explain_Click);
            // 
            // clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pan_clock_explain);
            this.Controls.Add(this.lbl_clock_life);
            this.Controls.Add(this.lbl_clock_level);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "clock";
            this.pan_clock_explain.ResumeLayout(false);
            this.pan_clock_explain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clock_level;
        private System.Windows.Forms.Label lbl_clock_life;
        private System.Windows.Forms.Panel pan_clock_explain;
        private System.Windows.Forms.TextBox txt_clock_explain;
        private System.Windows.Forms.Button btn_clock_explain;
    }
}
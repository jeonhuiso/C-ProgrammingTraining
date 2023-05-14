
namespace auditorium
{
    partial class nono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nono));
            this.lbl_nono_level = new System.Windows.Forms.Label();
            this.lbl_life = new System.Windows.Forms.Label();
            this.btn_nono_explain = new System.Windows.Forms.Button();
            this.txt_nono_explain = new System.Windows.Forms.TextBox();
            this.pan_nono_explain = new System.Windows.Forms.Panel();
            this.pan_nono_explain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nono_level
            // 
            this.lbl_nono_level.AutoSize = true;
            this.lbl_nono_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_nono_level.Location = new System.Drawing.Point(54, 40);
            this.lbl_nono_level.Name = "lbl_nono_level";
            this.lbl_nono_level.Size = new System.Drawing.Size(168, 36);
            this.lbl_nono_level.TabIndex = 6;
            this.lbl_nono_level.Text = "Level : 4 / 1";
            // 
            // lbl_life
            // 
            this.lbl_life.AutoSize = true;
            this.lbl_life.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_life.Location = new System.Drawing.Point(54, 87);
            this.lbl_life.Name = "lbl_life";
            this.lbl_life.Size = new System.Drawing.Size(107, 36);
            this.lbl_life.TabIndex = 7;
            this.lbl_life.Text = "♥ x  9";
            // 
            // btn_nono_explain
            // 
            this.btn_nono_explain.Location = new System.Drawing.Point(380, 500);
            this.btn_nono_explain.Name = "btn_nono_explain";
            this.btn_nono_explain.Size = new System.Drawing.Size(80, 40);
            this.btn_nono_explain.TabIndex = 0;
            this.btn_nono_explain.Text = "확인";
            this.btn_nono_explain.UseVisualStyleBackColor = true;
            this.btn_nono_explain.Click += new System.EventHandler(this.btn_nono_explain_Click);
            // 
            // txt_nono_explain
            // 
            this.txt_nono_explain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nono_explain.Location = new System.Drawing.Point(73, 56);
            this.txt_nono_explain.Multiline = true;
            this.txt_nono_explain.Name = "txt_nono_explain";
            this.txt_nono_explain.Size = new System.Drawing.Size(700, 430);
            this.txt_nono_explain.TabIndex = 1;
            // 
            // pan_nono_explain
            // 
            this.pan_nono_explain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_nono_explain.BackgroundImage")));
            this.pan_nono_explain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_nono_explain.Controls.Add(this.txt_nono_explain);
            this.pan_nono_explain.Controls.Add(this.btn_nono_explain);
            this.pan_nono_explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_nono_explain.Location = new System.Drawing.Point(0, 0);
            this.pan_nono_explain.Name = "pan_nono_explain";
            this.pan_nono_explain.Size = new System.Drawing.Size(900, 600);
            this.pan_nono_explain.TabIndex = 13;
            // 
            // nono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pan_nono_explain);
            this.Controls.Add(this.lbl_life);
            this.Controls.Add(this.lbl_nono_level);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "nono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.pan_nono_explain.ResumeLayout(false);
            this.pan_nono_explain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nono_level;
        private System.Windows.Forms.Label lbl_life;
        private System.Windows.Forms.Button btn_nono_explain;
        private System.Windows.Forms.TextBox txt_nono_explain;
        private System.Windows.Forms.Panel pan_nono_explain;
    }
}
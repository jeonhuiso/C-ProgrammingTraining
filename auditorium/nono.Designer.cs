
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
            this.lbl_nono_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nono_level
            // 
            this.lbl_nono_level.AutoSize = true;
            this.lbl_nono_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_nono_level.Location = new System.Drawing.Point(146, 63);
            this.lbl_nono_level.Name = "lbl_nono_level";
            this.lbl_nono_level.Size = new System.Drawing.Size(32, 36);
            this.lbl_nono_level.TabIndex = 7;
            this.lbl_nono_level.Text = "1";
            // 
            // lbl_nono_total
            // 
            this.lbl_nono_total.AutoSize = true;
            this.lbl_nono_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_nono_total.Location = new System.Drawing.Point(77, 63);
            this.lbl_nono_total.Name = "lbl_nono_total";
            this.lbl_nono_total.Size = new System.Drawing.Size(64, 36);
            this.lbl_nono_total.TabIndex = 6;
            this.lbl_nono_total.Text = "4   /";
            // 
            // nono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lbl_nono_level);
            this.Controls.Add(this.lbl_nono_total);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "nono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nono_level;
        private System.Windows.Forms.Label lbl_nono_total;
    }
}
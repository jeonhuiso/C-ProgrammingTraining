
namespace auditorium
{
    partial class make_shape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(make_shape));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_third_num = new System.Windows.Forms.Button();
            this.btn_second_num = new System.Windows.Forms.Button();
            this.btn_first_num = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_reset.Location = new System.Drawing.Point(90, 40);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 54);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "♥ x  6";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_third_num
            // 
            this.btn_third_num.Enabled = false;
            this.btn_third_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_third_num.Location = new System.Drawing.Point(77, 459);
            this.btn_third_num.Name = "btn_third_num";
            this.btn_third_num.Size = new System.Drawing.Size(75, 49);
            this.btn_third_num.TabIndex = 10;
            this.btn_third_num.Text = "0";
            this.btn_third_num.UseVisualStyleBackColor = true;
            // 
            // btn_second_num
            // 
            this.btn_second_num.Enabled = false;
            this.btn_second_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_second_num.Location = new System.Drawing.Point(77, 401);
            this.btn_second_num.Name = "btn_second_num";
            this.btn_second_num.Size = new System.Drawing.Size(75, 52);
            this.btn_second_num.TabIndex = 9;
            this.btn_second_num.Text = "0";
            this.btn_second_num.UseVisualStyleBackColor = true;
            // 
            // btn_first_num
            // 
            this.btn_first_num.Enabled = false;
            this.btn_first_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_first_num.Location = new System.Drawing.Point(77, 352);
            this.btn_first_num.Name = "btn_first_num";
            this.btn_first_num.Size = new System.Drawing.Size(75, 43);
            this.btn_first_num.TabIndex = 8;
            this.btn_first_num.Text = "0";
            this.btn_first_num.UseVisualStyleBackColor = true;
            // 
            // make_shape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_third_num);
            this.Controls.Add(this.btn_second_num);
            this.Controls.Add(this.btn_first_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "make_shape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "make_shape";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_third_num;
        private System.Windows.Forms.Button btn_second_num;
        private System.Windows.Forms.Button btn_first_num;
    }
}
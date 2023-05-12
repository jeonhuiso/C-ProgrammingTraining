namespace SWGame
{
    partial class sci_screen
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
            this.sci_hint = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sci_hint
            // 
            this.sci_hint.AutoSize = true;
            this.sci_hint.Location = new System.Drawing.Point(265, 144);
            this.sci_hint.Name = "sci_hint";
            this.sci_hint.Size = new System.Drawing.Size(97, 12);
            this.sci_hint.TabIndex = 0;
            this.sci_hint.Text = "7, 4, 10, 11, 3, 6 ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sci_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sci_hint);
            this.Name = "sci_screen";
            this.Text = "sci_screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sci_hint;
        private System.Windows.Forms.TextBox textBox1;
    }
}
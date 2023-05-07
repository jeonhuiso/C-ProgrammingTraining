
namespace StageLibrary
{
    partial class Level1
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
            this.Book_Of_Truth = new System.Windows.Forms.Button();
            this.Book_Of_Lie = new System.Windows.Forms.Button();
            this.Book_Of_Dumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Book_Of_Truth
            // 
            this.Book_Of_Truth.Location = new System.Drawing.Point(391, 280);
            this.Book_Of_Truth.Name = "Book_Of_Truth";
            this.Book_Of_Truth.Size = new System.Drawing.Size(75, 108);
            this.Book_Of_Truth.TabIndex = 0;
            this.Book_Of_Truth.Text = "Truth";
            this.Book_Of_Truth.UseVisualStyleBackColor = true;
            this.Book_Of_Truth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookMouseDown);
            this.Book_Of_Truth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookMouseMove);
            this.Book_Of_Truth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookMouseUp);
            // 
            // Book_Of_Lie
            // 
            this.Book_Of_Lie.Location = new System.Drawing.Point(572, 280);
            this.Book_Of_Lie.Name = "Book_Of_Lie";
            this.Book_Of_Lie.Size = new System.Drawing.Size(75, 108);
            this.Book_Of_Lie.TabIndex = 0;
            this.Book_Of_Lie.Text = "Lie";
            this.Book_Of_Lie.UseVisualStyleBackColor = true;
            this.Book_Of_Lie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookMouseDown);
            this.Book_Of_Lie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookMouseMove);
            this.Book_Of_Lie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookMouseUp);
            // 
            // Book_Of_Dumb
            // 
            this.Book_Of_Dumb.Location = new System.Drawing.Point(735, 280);
            this.Book_Of_Dumb.Name = "Book_Of_Dumb";
            this.Book_Of_Dumb.Size = new System.Drawing.Size(75, 108);
            this.Book_Of_Dumb.TabIndex = 0;
            this.Book_Of_Dumb.Text = "Dumb";
            this.Book_Of_Dumb.UseVisualStyleBackColor = true;
            this.Book_Of_Dumb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookMouseDown);
            this.Book_Of_Dumb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookMouseMove);
            this.Book_Of_Dumb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookMouseUp);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 590);
            this.Controls.Add(this.Book_Of_Truth);
            this.Controls.Add(this.Book_Of_Dumb);
            this.Controls.Add(this.Book_Of_Lie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Book_Of_Truth;
        private System.Windows.Forms.Button Book_Of_Lie;
        private System.Windows.Forms.Button Book_Of_Dumb;
    }
}
using System.Drawing;

namespace ComputerRoom
{
    partial class Comp_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comp_Room));
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComputer
            // 
            this.btnComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComputer.BackgroundImage")));
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnComputer.Image")));
            this.btnComputer.Location = new System.Drawing.Point(248, 208);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(135, 82);
            this.btnComputer.TabIndex = 0;
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(273, 502);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(94, 39);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "나가기";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Comp_Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comp_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Computer Room";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnComputer;
        private Button btnGoBack;
    }
}
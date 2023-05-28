
namespace Prologue
{
    partial class MainMenu
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
            this.btnScienceClass = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnComputerRoom = new System.Windows.Forms.Button();
            this.btnAuditorium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScienceClass
            // 
            this.btnScienceClass.Location = new System.Drawing.Point(161, 118);
            this.btnScienceClass.Name = "btnScienceClass";
            this.btnScienceClass.Size = new System.Drawing.Size(93, 40);
            this.btnScienceClass.TabIndex = 0;
            this.btnScienceClass.Text = "scienceClass";
            this.btnScienceClass.UseVisualStyleBackColor = true;
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(161, 236);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(93, 47);
            this.btnLibrary.TabIndex = 0;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // btnComputerRoom
            // 
            this.btnComputerRoom.Location = new System.Drawing.Point(422, 236);
            this.btnComputerRoom.Name = "btnComputerRoom";
            this.btnComputerRoom.Size = new System.Drawing.Size(96, 47);
            this.btnComputerRoom.TabIndex = 0;
            this.btnComputerRoom.Text = "ComputerRoom";
            this.btnComputerRoom.UseVisualStyleBackColor = true;
            // 
            // btnAuditorium
            // 
            this.btnAuditorium.Location = new System.Drawing.Point(687, 300);
            this.btnAuditorium.Name = "btnAuditorium";
            this.btnAuditorium.Size = new System.Drawing.Size(102, 42);
            this.btnAuditorium.TabIndex = 0;
            this.btnAuditorium.Text = "Auditorium";
            this.btnAuditorium.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.btnAuditorium);
            this.Controls.Add(this.btnComputerRoom);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnScienceClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScienceClass;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnComputerRoom;
        private System.Windows.Forms.Button btnAuditorium;
    }
}

namespace auditorium
{
    partial class Context
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtSpeaker = new System.Windows.Forms.TextBox();
            this.CharactoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharactoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtComment.Location = new System.Drawing.Point(191, 32);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(709, 168);
            this.txtComment.TabIndex = 6;
            // 
            // txtSpeaker
            // 
            this.txtSpeaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSpeaker.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSpeaker.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSpeaker.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSpeaker.Location = new System.Drawing.Point(191, 0);
            this.txtSpeaker.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpeaker.Name = "txtSpeaker";
            this.txtSpeaker.ReadOnly = true;
            this.txtSpeaker.Size = new System.Drawing.Size(709, 32);
            this.txtSpeaker.TabIndex = 5;
            // 
            // CharactoPicture
            // 
            this.CharactoPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.CharactoPicture.Location = new System.Drawing.Point(0, 0);
            this.CharactoPicture.Margin = new System.Windows.Forms.Padding(4);
            this.CharactoPicture.Name = "CharactoPicture";
            this.CharactoPicture.Size = new System.Drawing.Size(191, 200);
            this.CharactoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharactoPicture.TabIndex = 4;
            this.CharactoPicture.TabStop = false;
            // 
            // Context
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 200);
            this.ControlBox = false;
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtSpeaker);
            this.Controls.Add(this.CharactoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Context";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Context";
            ((System.ComponentModel.ISupportInitialize)(this.CharactoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtSpeaker;
        private System.Windows.Forms.PictureBox CharactoPicture;
    }
}
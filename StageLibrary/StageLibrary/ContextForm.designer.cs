
namespace StageLibrary
{
    partial class ContextForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CharactoPicture = new System.Windows.Forms.PictureBox();
            this.txtSpeaker = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharactoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CharactoPicture
            // 
            this.CharactoPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CharactoPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.CharactoPicture.Location = new System.Drawing.Point(0, 0);
            this.CharactoPicture.Name = "CharactoPicture";
            this.CharactoPicture.Size = new System.Drawing.Size(153, 200);
            this.CharactoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharactoPicture.TabIndex = 0;
            this.CharactoPicture.TabStop = false;
            // 
            // txtSpeaker
            // 
            this.txtSpeaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSpeaker.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSpeaker.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSpeaker.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSpeaker.Location = new System.Drawing.Point(153, 0);
            this.txtSpeaker.Name = "txtSpeaker";
            this.txtSpeaker.ReadOnly = true;
            this.txtSpeaker.Size = new System.Drawing.Size(742, 28);
            this.txtSpeaker.TabIndex = 2;
            this.txtSpeaker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScript_KeyDown);
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtComment.Location = new System.Drawing.Point(153, 28);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(742, 172);
            this.txtComment.TabIndex = 3;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScript_KeyDown);
            // 
            // ContextForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(895, 200);
            this.ControlBox = false;
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtSpeaker);
            this.Controls.Add(this.CharactoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContextForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ContextForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScript_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CharactoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CharactoPicture;
        private System.Windows.Forms.TextBox txtSpeaker;
        private System.Windows.Forms.TextBox txtComment;
    }
}


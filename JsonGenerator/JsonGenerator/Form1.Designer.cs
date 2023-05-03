
namespace JsonGenerator
{
    partial class Form1
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
            this.txtObject = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.btnMakeJson = new System.Windows.Forms.Button();
            this.btnJsonCheck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObjectCheck = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSpeaker = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(6, 24);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(308, 25);
            this.txtObject.TabIndex = 0;
            this.txtObject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownCheck2);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(123, 111);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(647, 86);
            this.txtComment.TabIndex = 0;
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(123, 203);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScript.Size = new System.Drawing.Size(647, 174);
            this.txtScript.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(6, 24);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(126, 25);
            this.txtJson.TabIndex = 0;
            this.txtJson.TextChanged += new System.EventHandler(this.txtJson_TextChanged);
            this.txtJson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownCheck);
            // 
            // btnMakeJson
            // 
            this.btnMakeJson.Location = new System.Drawing.Point(776, 343);
            this.btnMakeJson.Name = "btnMakeJson";
            this.btnMakeJson.Size = new System.Drawing.Size(142, 34);
            this.btnMakeJson.TabIndex = 1;
            this.btnMakeJson.Text = "Json제작";
            this.btnMakeJson.UseVisualStyleBackColor = true;
            this.btnMakeJson.Click += new System.EventHandler(this.btnMakeJson_Click);
            // 
            // btnJsonCheck
            // 
            this.btnJsonCheck.Location = new System.Drawing.Point(6, 55);
            this.btnJsonCheck.Name = "btnJsonCheck";
            this.btnJsonCheck.Size = new System.Drawing.Size(142, 34);
            this.btnJsonCheck.TabIndex = 1;
            this.btnJsonCheck.Text = "Json중복확인";
            this.btnJsonCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJson);
            this.groupBox1.Controls.Add(this.btnJsonCheck);
            this.groupBox1.Location = new System.Drawing.Point(392, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Json파일 이름 작성";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObject);
            this.groupBox2.Controls.Add(this.btnObjectCheck);
            this.groupBox2.Location = new System.Drawing.Point(598, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 99);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "객체 이름 설정";
            // 
            // btnObjectCheck
            // 
            this.btnObjectCheck.Location = new System.Drawing.Point(6, 54);
            this.btnObjectCheck.Name = "btnObjectCheck";
            this.btnObjectCheck.Size = new System.Drawing.Size(142, 34);
            this.btnObjectCheck.TabIndex = 1;
            this.btnObjectCheck.Text = "객체 중복 확인";
            this.btnObjectCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSpeaker);
            this.groupBox3.Location = new System.Drawing.Point(123, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "화자";
            // 
            // txtSpeaker
            // 
            this.txtSpeaker.Location = new System.Drawing.Point(6, 24);
            this.txtSpeaker.Name = "txtSpeaker";
            this.txtSpeaker.Size = new System.Drawing.Size(126, 25);
            this.txtSpeaker.TabIndex = 0;
            this.txtSpeaker.TextChanged += new System.EventHandler(this.txtJson_TextChanged);
            this.txtSpeaker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownCheck3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 389);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMakeJson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.txtComment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.Button btnMakeJson;
        private System.Windows.Forms.Button btnJsonCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObjectCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSpeaker;
    }
}


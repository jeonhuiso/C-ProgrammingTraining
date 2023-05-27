namespace ComputerRoom
{
    partial class MailLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailLogin));
            panel1 = new Panel();
            lblHint = new Label();
            lblLogin = new Label();
            boxLoginLogo = new PictureBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxLoginLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(lblHint);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(boxLoginLogo);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(184, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 209);
            panel1.TabIndex = 0;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.ForeColor = Color.Red;
            lblHint.Location = new Point(30, 150);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(82, 20);
            lblHint.TabIndex = 7;
            lblHint.Text = "힌트 : 점수";
            lblHint.Visible = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = Color.Red;
            lblLogin.Location = new Point(30, 179);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(64, 20);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "lblLogin";
            lblLogin.Visible = false;
            // 
            // boxLoginLogo
            // 
            boxLoginLogo.Image = (Image)resources.GetObject("boxLoginLogo.Image");
            boxLoginLogo.Location = new Point(120, 3);
            boxLoginLogo.Name = "boxLoginLogo";
            boxLoginLogo.Size = new Size(125, 62);
            boxLoginLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            boxLoginLogo.TabIndex = 5;
            boxLoginLogo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(224, 141);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 71);
            txtID.Name = "txtID";
            txtID.Size = new Size(198, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 115);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 74);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // MailLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(732, 403);
            Controls.Add(panel1);
            Name = "MailLogin";
            Text = "Mail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boxLoginLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private PictureBox boxLoginLogo;
        private Button btnLogin;
        private Label lblLogin;
        private Label lblHint;
    }
}
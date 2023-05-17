namespace ComputerRoom
{
    partial class mail
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
            pnlBanner = new Panel();
            pnlMailList = new Panel();
            pnlReceive = new Panel();
            splitter1 = new Splitter();
            lblRecieve = new Label();
            lblSend = new Label();
            lblSpam = new Label();
            lblTrash = new Label();
            pnlUser = new Panel();
            pnlMailList.SuspendLayout();
            pnlReceive.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = SystemColors.ControlDark;
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Location = new Point(0, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(800, 66);
            pnlBanner.TabIndex = 0;
            // 
            // pnlMailList
            // 
            pnlMailList.Controls.Add(pnlUser);
            pnlMailList.Controls.Add(lblTrash);
            pnlMailList.Controls.Add(lblSpam);
            pnlMailList.Controls.Add(lblSend);
            pnlMailList.Controls.Add(lblRecieve);
            pnlMailList.Dock = DockStyle.Left;
            pnlMailList.Location = new Point(0, 66);
            pnlMailList.Name = "pnlMailList";
            pnlMailList.Size = new Size(150, 384);
            pnlMailList.TabIndex = 0;
            // 
            // pnlReceive
            // 
            pnlReceive.Controls.Add(splitter1);
            pnlReceive.Dock = DockStyle.Fill;
            pnlReceive.Location = new Point(150, 66);
            pnlReceive.Name = "pnlReceive";
            pnlReceive.Size = new Size(650, 384);
            pnlReceive.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 384);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // lblRecieve
            // 
            lblRecieve.AutoSize = true;
            lblRecieve.Location = new Point(12, 30);
            lblRecieve.Name = "lblRecieve";
            lblRecieve.Size = new Size(74, 20);
            lblRecieve.TabIndex = 0;
            lblRecieve.Text = "받은 편지";
            // 
            // lblSend
            // 
            lblSend.AutoSize = true;
            lblSend.Location = new Point(12, 61);
            lblSend.Name = "lblSend";
            lblSend.Size = new Size(74, 20);
            lblSend.TabIndex = 1;
            lblSend.Text = "보낸 편지";
            // 
            // lblSpam
            // 
            lblSpam.AutoSize = true;
            lblSpam.Location = new Point(12, 94);
            lblSpam.Name = "lblSpam";
            lblSpam.Size = new Size(54, 20);
            lblSpam.TabIndex = 2;
            lblSpam.Text = "스팸함";
            // 
            // lblTrash
            // 
            lblTrash.AutoSize = true;
            lblTrash.Location = new Point(12, 125);
            lblTrash.Name = "lblTrash";
            lblTrash.Size = new Size(54, 20);
            lblTrash.TabIndex = 3;
            lblTrash.Text = "휴지통";
            // 
            // pnlUser
            // 
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.Location = new Point(0, 241);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(150, 143);
            pnlUser.TabIndex = 4;
            // 
            // mail
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReceive);
            Controls.Add(pnlMailList);
            Controls.Add(pnlBanner);
            Name = "mail";
            Text = "mail";
            pnlMailList.ResumeLayout(false);
            pnlMailList.PerformLayout();
            pnlReceive.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBanner;
        private Panel pnlMailList;
        private Panel pnlUser;
        private Label lblTrash;
        private Label lblSpam;
        private Label lblSend;
        private Label lblRecieve;
        private Panel pnlReceive;
        private Splitter splitter1;
    }
}
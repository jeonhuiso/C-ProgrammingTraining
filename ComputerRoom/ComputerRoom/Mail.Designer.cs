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
            pnlUser = new Panel();
            lblTrash = new Label();
            lblSpam = new Label();
            lblSend = new Label();
            lblRecieve = new Label();
            pnlReceive = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMail1 = new Label();
            lblMail1Date = new Label();
            lblMail2 = new Label();
            lblMail2Date = new Label();
            lblMail3 = new Label();
            lblMail3Date = new Label();
            lblMail4 = new Label();
            lblMail4Date = new Label();
            splitter1 = new Splitter();
            boxProfile = new PictureBox();
            lblId = new Label();
            lblMailId = new Label();
            pnlMailList.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlReceive.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxProfile).BeginInit();
            SuspendLayout();
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = SystemColors.ControlDark;
            pnlBanner.BorderStyle = BorderStyle.FixedSingle;
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Location = new Point(0, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(732, 66);
            pnlBanner.TabIndex = 0;
            // 
            // pnlMailList
            // 
            pnlMailList.BackColor = SystemColors.ControlDark;
            pnlMailList.Controls.Add(pnlUser);
            pnlMailList.Controls.Add(lblTrash);
            pnlMailList.Controls.Add(lblSpam);
            pnlMailList.Controls.Add(lblSend);
            pnlMailList.Controls.Add(lblRecieve);
            pnlMailList.Dock = DockStyle.Left;
            pnlMailList.Location = new Point(0, 66);
            pnlMailList.Name = "pnlMailList";
            pnlMailList.Size = new Size(126, 337);
            pnlMailList.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = SystemColors.ControlDark;
            pnlUser.BorderStyle = BorderStyle.FixedSingle;
            pnlUser.Controls.Add(lblMailId);
            pnlUser.Controls.Add(lblId);
            pnlUser.Controls.Add(boxProfile);
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.Location = new Point(0, 185);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(126, 152);
            pnlUser.TabIndex = 4;
            // 
            // lblTrash
            // 
            lblTrash.AutoSize = true;
            lblTrash.Location = new Point(66, 124);
            lblTrash.Name = "lblTrash";
            lblTrash.Size = new Size(54, 20);
            lblTrash.TabIndex = 3;
            lblTrash.Text = "휴지통";
            // 
            // lblSpam
            // 
            lblSpam.AutoSize = true;
            lblSpam.Location = new Point(66, 90);
            lblSpam.Name = "lblSpam";
            lblSpam.Size = new Size(54, 20);
            lblSpam.TabIndex = 2;
            lblSpam.Text = "스팸함";
            // 
            // lblSend
            // 
            lblSend.AutoSize = true;
            lblSend.Location = new Point(46, 57);
            lblSend.Name = "lblSend";
            lblSend.Size = new Size(74, 20);
            lblSend.TabIndex = 1;
            lblSend.Text = "보낸 편지";
            // 
            // lblRecieve
            // 
            lblRecieve.AutoSize = true;
            lblRecieve.Location = new Point(46, 24);
            lblRecieve.Name = "lblRecieve";
            lblRecieve.Size = new Size(74, 20);
            lblRecieve.TabIndex = 0;
            lblRecieve.Text = "받은 편지";
            lblRecieve.Click += lblRecieve_Click;
            // 
            // pnlReceive
            // 
            pnlReceive.BackColor = SystemColors.Control;
            pnlReceive.BorderStyle = BorderStyle.FixedSingle;
            pnlReceive.Controls.Add(tableLayoutPanel1);
            pnlReceive.Controls.Add(splitter1);
            pnlReceive.Dock = DockStyle.Fill;
            pnlReceive.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnlReceive.ForeColor = Color.Blue;
            pnlReceive.Location = new Point(126, 66);
            pnlReceive.Name = "pnlReceive";
            pnlReceive.Size = new Size(606, 337);
            pnlReceive.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblMail1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblMail1Date, 1, 0);
            tableLayoutPanel1.Controls.Add(lblMail2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblMail2Date, 1, 1);
            tableLayoutPanel1.Controls.Add(lblMail3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMail3Date, 1, 2);
            tableLayoutPanel1.Controls.Add(lblMail4, 0, 3);
            tableLayoutPanel1.Controls.Add(lblMail4Date, 1, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(605, 147);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMail1
            // 
            lblMail1.AutoSize = true;
            lblMail1.Dock = DockStyle.Fill;
            lblMail1.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail1.Location = new Point(6, 3);
            lblMail1.Name = "lblMail1";
            lblMail1.Size = new Size(470, 33);
            lblMail1.TabIndex = 2;
            lblMail1.Text = "1번메일";
            lblMail1.Click += lblMail1_Click;
            // 
            // lblMail1Date
            // 
            lblMail1Date.AutoSize = true;
            lblMail1Date.Dock = DockStyle.Fill;
            lblMail1Date.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail1Date.ForeColor = Color.Blue;
            lblMail1Date.Location = new Point(485, 3);
            lblMail1Date.Name = "lblMail1Date";
            lblMail1Date.Size = new Size(114, 33);
            lblMail1Date.TabIndex = 3;
            lblMail1Date.Text = "label1";
            lblMail1Date.Click += lblMail1_Click;
            // 
            // lblMail2
            // 
            lblMail2.AutoSize = true;
            lblMail2.Dock = DockStyle.Fill;
            lblMail2.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail2.ForeColor = Color.Blue;
            lblMail2.Location = new Point(6, 39);
            lblMail2.Name = "lblMail2";
            lblMail2.Size = new Size(470, 33);
            lblMail2.TabIndex = 4;
            lblMail2.Text = "label2";
            lblMail2.Click += lblMail2_Click;
            // 
            // lblMail2Date
            // 
            lblMail2Date.AutoSize = true;
            lblMail2Date.Dock = DockStyle.Fill;
            lblMail2Date.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail2Date.ForeColor = Color.Blue;
            lblMail2Date.Location = new Point(485, 39);
            lblMail2Date.Name = "lblMail2Date";
            lblMail2Date.Size = new Size(114, 33);
            lblMail2Date.TabIndex = 5;
            lblMail2Date.Text = "label3";
            lblMail2Date.Click += lblMail2_Click;
            // 
            // lblMail3
            // 
            lblMail3.AutoSize = true;
            lblMail3.Dock = DockStyle.Fill;
            lblMail3.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail3.ForeColor = Color.Blue;
            lblMail3.Location = new Point(6, 75);
            lblMail3.Name = "lblMail3";
            lblMail3.Size = new Size(470, 33);
            lblMail3.TabIndex = 6;
            lblMail3.Text = "label4";
            lblMail3.Click += lblMail3_Click;
            // 
            // lblMail3Date
            // 
            lblMail3Date.AutoSize = true;
            lblMail3Date.Dock = DockStyle.Fill;
            lblMail3Date.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail3Date.ForeColor = Color.Blue;
            lblMail3Date.Location = new Point(485, 75);
            lblMail3Date.Name = "lblMail3Date";
            lblMail3Date.Size = new Size(114, 33);
            lblMail3Date.TabIndex = 7;
            lblMail3Date.Text = "label5";
            lblMail3Date.Click += lblMail3_Click;
            // 
            // lblMail4
            // 
            lblMail4.AutoSize = true;
            lblMail4.Dock = DockStyle.Fill;
            lblMail4.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail4.ForeColor = Color.Blue;
            lblMail4.Location = new Point(6, 111);
            lblMail4.Name = "lblMail4";
            lblMail4.Size = new Size(470, 33);
            lblMail4.TabIndex = 8;
            lblMail4.Text = "label6";
            lblMail4.Click += lblMail4_Click;
            // 
            // lblMail4Date
            // 
            lblMail4Date.AutoSize = true;
            lblMail4Date.Dock = DockStyle.Fill;
            lblMail4Date.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail4Date.ForeColor = Color.Blue;
            lblMail4Date.Location = new Point(485, 111);
            lblMail4Date.Name = "lblMail4Date";
            lblMail4Date.Size = new Size(114, 33);
            lblMail4Date.TabIndex = 9;
            lblMail4Date.Text = "label7";
            lblMail4Date.Click += lblMail4_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 335);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // boxProfile
            // 
            boxProfile.Location = new Point(0, -1);
            boxProfile.Name = "boxProfile";
            boxProfile.Size = new Size(125, 62);
            boxProfile.TabIndex = 2;
            boxProfile.TabStop = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(38, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(81, 20);
            lblId.TabIndex = 3;
            lblId.Text = "freeman75";
            // 
            // lblMailId
            // 
            lblMailId.AutoSize = true;
            lblMailId.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMailId.Location = new Point(48, 99);
            lblMailId.Name = "lblMailId";
            lblMailId.Size = new Size(71, 34);
            lblMailId.TabIndex = 4;
            lblMailId.Text = "freeman75\r\n@hmail.cs";
            // 
            // mail
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(732, 403);
            Controls.Add(pnlReceive);
            Controls.Add(pnlMailList);
            Controls.Add(pnlBanner);
            Name = "mail";
            Text = "mail";
            pnlMailList.ResumeLayout(false);
            pnlMailList.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            pnlReceive.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boxProfile).EndInit();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMail1;
        private Label lblMail1Date;
        private Label lblMail2;
        private Label lblMail2Date;
        private Label lblMail3;
        private Label lblMail3Date;
        private Label lblMail4;
        private Label lblMail4Date;
        private Label lblId;
        private PictureBox boxProfile;
        private Label lblMailId;
    }
}
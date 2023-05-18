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
            pnlNothing = new Panel();
            label5 = new Label();
            pnlMailList = new Panel();
            pnlUser = new Panel();
            lblMailId = new Label();
            lblId = new Label();
            boxProfile = new PictureBox();
            lblTrash = new Label();
            lblSpam = new Label();
            lblSend = new Label();
            lblRecieve = new Label();
            pnlReceive = new Panel();
            pnlMailIn = new Panel();
            txtMailContext = new TextBox();
            pnlMailInfo = new Panel();
            lblAtt = new Label();
            label6 = new Label();
            txtSubject = new TextBox();
            lblDate = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
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
            pnlBanner.SuspendLayout();
            pnlNothing.SuspendLayout();
            pnlMailList.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxProfile).BeginInit();
            pnlReceive.SuspendLayout();
            pnlMailIn.SuspendLayout();
            pnlMailInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = SystemColors.ControlDark;
            pnlBanner.BorderStyle = BorderStyle.FixedSingle;
            pnlBanner.Controls.Add(pnlNothing);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Location = new Point(0, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(732, 66);
            pnlBanner.TabIndex = 0;
            // 
            // pnlNothing
            // 
            pnlNothing.BackColor = SystemColors.Control;
            pnlNothing.Controls.Add(label5);
            pnlNothing.Location = new Point(125, 61);
            pnlNothing.Name = "pnlNothing";
            pnlNothing.Size = new Size(605, 337);
            pnlNothing.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(199, 12);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 0;
            label5.Text = "메일함이 비어있습니다.";
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
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(38, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(81, 20);
            lblId.TabIndex = 3;
            lblId.Text = "freeman75";
            // 
            // boxProfile
            // 
            boxProfile.Location = new Point(0, -1);
            boxProfile.Name = "boxProfile";
            boxProfile.Size = new Size(125, 62);
            boxProfile.TabIndex = 2;
            boxProfile.TabStop = false;
            // 
            // lblTrash
            // 
            lblTrash.AutoSize = true;
            lblTrash.Location = new Point(66, 124);
            lblTrash.Name = "lblTrash";
            lblTrash.Size = new Size(54, 20);
            lblTrash.TabIndex = 3;
            lblTrash.Text = "휴지통";
            lblTrash.Click += lblTrash_Click;
            // 
            // lblSpam
            // 
            lblSpam.AutoSize = true;
            lblSpam.Location = new Point(66, 90);
            lblSpam.Name = "lblSpam";
            lblSpam.Size = new Size(54, 20);
            lblSpam.TabIndex = 2;
            lblSpam.Text = "스팸함";
            lblSpam.Click += lblSpam_Click;
            // 
            // lblSend
            // 
            lblSend.AutoSize = true;
            lblSend.Location = new Point(46, 57);
            lblSend.Name = "lblSend";
            lblSend.Size = new Size(74, 20);
            lblSend.TabIndex = 1;
            lblSend.Text = "보낸 편지";
            lblSend.Click += lblSend_Click;
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
            pnlReceive.Controls.Add(pnlMailIn);
            pnlReceive.Controls.Add(tableLayoutPanel1);
            pnlReceive.Controls.Add(splitter1);
            pnlReceive.Dock = DockStyle.Fill;
            pnlReceive.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnlReceive.ForeColor = Color.Blue;
            pnlReceive.Location = new Point(126, 66);
            pnlReceive.Name = "pnlReceive";
            pnlReceive.Size = new Size(606, 337);
            pnlReceive.TabIndex = 0;
            pnlReceive.Visible = false;
            // 
            // pnlMailIn
            // 
            pnlMailIn.Controls.Add(txtMailContext);
            pnlMailIn.Controls.Add(pnlMailInfo);
            pnlMailIn.Dock = DockStyle.Fill;
            pnlMailIn.Location = new Point(4, 0);
            pnlMailIn.Name = "pnlMailIn";
            pnlMailIn.Size = new Size(600, 335);
            pnlMailIn.TabIndex = 2;
            // 
            // txtMailContext
            // 
            txtMailContext.Enabled = false;
            txtMailContext.Location = new Point(0, 153);
            txtMailContext.Multiline = true;
            txtMailContext.Name = "txtMailContext";
            txtMailContext.ScrollBars = ScrollBars.Both;
            txtMailContext.Size = new Size(600, 182);
            txtMailContext.TabIndex = 1;
            // 
            // pnlMailInfo
            // 
            pnlMailInfo.BackColor = SystemColors.ControlDark;
            pnlMailInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlMailInfo.Controls.Add(lblAtt);
            pnlMailInfo.Controls.Add(label6);
            pnlMailInfo.Controls.Add(txtSubject);
            pnlMailInfo.Controls.Add(lblDate);
            pnlMailInfo.Controls.Add(lblTo);
            pnlMailInfo.Controls.Add(lblFrom);
            pnlMailInfo.Controls.Add(label4);
            pnlMailInfo.Controls.Add(label2);
            pnlMailInfo.Controls.Add(label1);
            pnlMailInfo.Controls.Add(label3);
            pnlMailInfo.Dock = DockStyle.Top;
            pnlMailInfo.Location = new Point(0, 0);
            pnlMailInfo.Name = "pnlMailInfo";
            pnlMailInfo.Size = new Size(600, 160);
            pnlMailInfo.TabIndex = 0;
            // 
            // lblAtt
            // 
            lblAtt.AutoSize = true;
            lblAtt.Location = new Point(131, 117);
            lblAtt.Name = "lblAtt";
            lblAtt.Size = new Size(60, 25);
            lblAtt.TabIndex = 10;
            lblAtt.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(9, 120);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 9;
            label6.Text = "Attachment:";
            // 
            // txtSubject
            // 
            txtSubject.Enabled = false;
            txtSubject.Location = new Point(131, 84);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(445, 31);
            txtSubject.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(131, 29);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 23);
            lblDate.TabIndex = 7;
            lblDate.Text = "From:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTo.ForeColor = SystemColors.ControlText;
            lblTo.Location = new Point(131, 58);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(57, 23);
            lblTo.TabIndex = 6;
            lblTo.Text = "From:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrom.ForeColor = SystemColors.ControlText;
            lblFrom.Location = new Point(131, 4);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(57, 23);
            lblFrom.TabIndex = 3;
            lblFrom.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(9, 86);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 1;
            label4.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(9, 29);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 2;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(9, 58);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 1;
            label1.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(9, 1);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 0;
            label3.Text = "From:";
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
            // mail
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(732, 403);
            Controls.Add(pnlReceive);
            Controls.Add(pnlMailList);
            Controls.Add(pnlBanner);
            Name = "mail";
            Text = "mail";
            pnlBanner.ResumeLayout(false);
            pnlNothing.ResumeLayout(false);
            pnlNothing.PerformLayout();
            pnlMailList.ResumeLayout(false);
            pnlMailList.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boxProfile).EndInit();
            pnlReceive.ResumeLayout(false);
            pnlMailIn.ResumeLayout(false);
            pnlMailIn.PerformLayout();
            pnlMailInfo.ResumeLayout(false);
            pnlMailInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label lblId;
        private PictureBox boxProfile;
        private Label lblMailId;
        private Panel pnlMailIn;
        private Panel pnlMailInfo;
        private TextBox txtMailContext;
        private TextBox txtSubject;
        private Label lblDate;
        private Label lblTo;
        private Label lblFrom;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel pnlNothing;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMail1;
        private Label lblMail1Date;
        private Label lblMail2;
        private Label lblMail2Date;
        private Label lblMail3;
        private Label lblMail3Date;
        private Label lblMail4;
        private Label lblMail4Date;
        private Label lblAtt;
        private Label label6;
    }
}
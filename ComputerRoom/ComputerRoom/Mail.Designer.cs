using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mail));
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNothing = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMailList = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblMailId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.boxProfile = new System.Windows.Forms.PictureBox();
            this.lblTrash = new System.Windows.Forms.Label();
            this.lblSpam = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblRecieve = new System.Windows.Forms.Label();
            this.pnlReceive = new System.Windows.Forms.Panel();
            this.pnlMailIn = new System.Windows.Forms.Panel();
            this.pnlMailInfo = new System.Windows.Forms.Panel();
            this.lblAtt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailContext = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail1 = new System.Windows.Forms.Label();
            this.lblMail1Date = new System.Windows.Forms.Label();
            this.lblMail2 = new System.Windows.Forms.Label();
            this.lblMail2Date = new System.Windows.Forms.Label();
            this.lblMail3 = new System.Windows.Forms.Label();
            this.lblMail3Date = new System.Windows.Forms.Label();
            this.lblMail4 = new System.Windows.Forms.Label();
            this.lblMail4Date = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNothing.SuspendLayout();
            this.pnlMailList.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxProfile)).BeginInit();
            this.pnlReceive.SuspendLayout();
            this.pnlMailIn.SuspendLayout();
            this.pnlMailInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBanner.Controls.Add(this.pictureBox1);
            this.pnlBanner.Controls.Add(this.pnlNothing);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(732, 66);
            this.pnlBanner.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNothing
            // 
            this.pnlNothing.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNothing.Controls.Add(this.label5);
            this.pnlNothing.Location = new System.Drawing.Point(125, 61);
            this.pnlNothing.Name = "pnlNothing";
            this.pnlNothing.Size = new System.Drawing.Size(605, 337);
            this.pnlNothing.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(199, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "메일함이 비어있습니다.";
            // 
            // pnlMailList
            // 
            this.pnlMailList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMailList.Controls.Add(this.pnlUser);
            this.pnlMailList.Controls.Add(this.lblTrash);
            this.pnlMailList.Controls.Add(this.lblSpam);
            this.pnlMailList.Controls.Add(this.lblSend);
            this.pnlMailList.Controls.Add(this.lblRecieve);
            this.pnlMailList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMailList.Location = new System.Drawing.Point(0, 66);
            this.pnlMailList.Name = "pnlMailList";
            this.pnlMailList.Size = new System.Drawing.Size(126, 337);
            this.pnlMailList.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUser.Controls.Add(this.lblMailId);
            this.pnlUser.Controls.Add(this.lblId);
            this.pnlUser.Controls.Add(this.boxProfile);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser.Location = new System.Drawing.Point(0, 185);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(126, 152);
            this.pnlUser.TabIndex = 4;
            // 
            // lblMailId
            // 
            this.lblMailId.AutoSize = true;
            this.lblMailId.Font = new System.Drawing.Font("맑은 고딕", 7.8F);
            this.lblMailId.Location = new System.Drawing.Point(48, 99);
            this.lblMailId.Name = "lblMailId";
            this.lblMailId.Size = new System.Drawing.Size(71, 34);
            this.lblMailId.TabIndex = 4;
            this.lblMailId.Text = "freeman75\r\n@hmail.cs";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(38, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "freeman75";
            // 
            // boxProfile
            // 
            this.boxProfile.Location = new System.Drawing.Point(0, -1);
            this.boxProfile.Name = "boxProfile";
            this.boxProfile.Size = new System.Drawing.Size(125, 62);
            this.boxProfile.TabIndex = 2;
            this.boxProfile.TabStop = false;
            // 
            // lblTrash
            // 
            this.lblTrash.AutoSize = true;
            this.lblTrash.Location = new System.Drawing.Point(39, 124);
            this.lblTrash.Name = "lblTrash";
            this.lblTrash.Size = new System.Drawing.Size(52, 15);
            this.lblTrash.TabIndex = 3;
            this.lblTrash.Text = "휴지통";
            this.lblTrash.Click += new System.EventHandler(this.lblTrash_Click);
            // 
            // lblSpam
            // 
            this.lblSpam.AutoSize = true;
            this.lblSpam.Location = new System.Drawing.Point(39, 90);
            this.lblSpam.Name = "lblSpam";
            this.lblSpam.Size = new System.Drawing.Size(52, 15);
            this.lblSpam.TabIndex = 2;
            this.lblSpam.Text = "스팸함";
            this.lblSpam.Click += new System.EventHandler(this.lblSpam_Click);
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(19, 57);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(72, 15);
            this.lblSend.TabIndex = 1;
            this.lblSend.Text = "보낸 편지";
            this.lblSend.Click += new System.EventHandler(this.lblSend_Click);
            // 
            // lblRecieve
            // 
            this.lblRecieve.AutoSize = true;
            this.lblRecieve.Location = new System.Drawing.Point(19, 24);
            this.lblRecieve.Name = "lblRecieve";
            this.lblRecieve.Size = new System.Drawing.Size(72, 15);
            this.lblRecieve.TabIndex = 0;
            this.lblRecieve.Text = "받은 편지";
            this.lblRecieve.Click += new System.EventHandler(this.lblRecieve_Click);
            // 
            // pnlReceive
            // 
            this.pnlReceive.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReceive.Controls.Add(this.pnlMailIn);
            this.pnlReceive.Controls.Add(this.tableLayoutPanel1);
            this.pnlReceive.Controls.Add(this.splitter1);
            this.pnlReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceive.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.pnlReceive.ForeColor = System.Drawing.Color.Blue;
            this.pnlReceive.Location = new System.Drawing.Point(126, 66);
            this.pnlReceive.Name = "pnlReceive";
            this.pnlReceive.Size = new System.Drawing.Size(606, 337);
            this.pnlReceive.TabIndex = 0;
            this.pnlReceive.Visible = false;
            // 
            // pnlMailIn
            // 
            this.pnlMailIn.Controls.Add(this.pnlMailInfo);
            this.pnlMailIn.Controls.Add(this.txtMailContext);
            this.pnlMailIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMailIn.Location = new System.Drawing.Point(4, 0);
            this.pnlMailIn.Name = "pnlMailIn";
            this.pnlMailIn.Size = new System.Drawing.Size(600, 335);
            this.pnlMailIn.TabIndex = 2;
            // 
            // pnlMailInfo
            // 
            this.pnlMailInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMailInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMailInfo.Controls.Add(this.lblAtt);
            this.pnlMailInfo.Controls.Add(this.label6);
            this.pnlMailInfo.Controls.Add(this.txtSubject);
            this.pnlMailInfo.Controls.Add(this.lblDate);
            this.pnlMailInfo.Controls.Add(this.lblTo);
            this.pnlMailInfo.Controls.Add(this.lblFrom);
            this.pnlMailInfo.Controls.Add(this.label4);
            this.pnlMailInfo.Controls.Add(this.label2);
            this.pnlMailInfo.Controls.Add(this.label1);
            this.pnlMailInfo.Controls.Add(this.label3);
            this.pnlMailInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMailInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMailInfo.Name = "pnlMailInfo";
            this.pnlMailInfo.Size = new System.Drawing.Size(600, 160);
            this.pnlMailInfo.TabIndex = 0;
            // 
            // lblAtt
            // 
            this.lblAtt.AutoSize = true;
            this.lblAtt.Location = new System.Drawing.Point(131, 120);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(60, 25);
            this.lblAtt.TabIndex = 10;
            this.lblAtt.Text = "label7";
            this.lblAtt.Click += new System.EventHandler(this.lblAtt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(9, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Attachment:";
            // 
            // txtSubject
            // 
            this.txtSubject.Enabled = false;
            this.txtSubject.Location = new System.Drawing.Point(131, 84);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(445, 31);
            this.txtSubject.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(131, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 23);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTo.Location = new System.Drawing.Point(131, 58);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(57, 23);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "From:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrom.Location = new System.Drawing.Point(131, 4);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(57, 23);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "From:";
            // 
            // txtMailContext
            // 
            this.txtMailContext.Enabled = false;
            this.txtMailContext.Location = new System.Drawing.Point(0, 160);
            this.txtMailContext.Multiline = true;
            this.txtMailContext.Name = "txtMailContext";
            this.txtMailContext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMailContext.Size = new System.Drawing.Size(600, 182);
            this.txtMailContext.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblMail1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMail1Date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMail2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMail2Date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMail3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMail3Date, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMail4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMail4Date, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 147);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMail1
            // 
            this.lblMail1.AutoSize = true;
            this.lblMail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail1.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail1.Location = new System.Drawing.Point(6, 3);
            this.lblMail1.Name = "lblMail1";
            this.lblMail1.Size = new System.Drawing.Size(470, 33);
            this.lblMail1.TabIndex = 2;
            this.lblMail1.Text = "1번메일";
            this.lblMail1.Click += new System.EventHandler(this.lblMail1_Click);
            // 
            // lblMail1Date
            // 
            this.lblMail1Date.AutoSize = true;
            this.lblMail1Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail1Date.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail1Date.ForeColor = System.Drawing.Color.Blue;
            this.lblMail1Date.Location = new System.Drawing.Point(485, 3);
            this.lblMail1Date.Name = "lblMail1Date";
            this.lblMail1Date.Size = new System.Drawing.Size(114, 33);
            this.lblMail1Date.TabIndex = 3;
            this.lblMail1Date.Text = "label1";
            // 
            // lblMail2
            // 
            this.lblMail2.AutoSize = true;
            this.lblMail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail2.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail2.ForeColor = System.Drawing.Color.Blue;
            this.lblMail2.Location = new System.Drawing.Point(6, 39);
            this.lblMail2.Name = "lblMail2";
            this.lblMail2.Size = new System.Drawing.Size(470, 33);
            this.lblMail2.TabIndex = 4;
            this.lblMail2.Text = "label2";
            this.lblMail2.Click += new System.EventHandler(this.lblMail2_Click);
            // 
            // lblMail2Date
            // 
            this.lblMail2Date.AutoSize = true;
            this.lblMail2Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail2Date.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail2Date.ForeColor = System.Drawing.Color.Blue;
            this.lblMail2Date.Location = new System.Drawing.Point(485, 39);
            this.lblMail2Date.Name = "lblMail2Date";
            this.lblMail2Date.Size = new System.Drawing.Size(114, 33);
            this.lblMail2Date.TabIndex = 5;
            this.lblMail2Date.Text = "label3";
            // 
            // lblMail3
            // 
            this.lblMail3.AutoSize = true;
            this.lblMail3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail3.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail3.ForeColor = System.Drawing.Color.Blue;
            this.lblMail3.Location = new System.Drawing.Point(6, 75);
            this.lblMail3.Name = "lblMail3";
            this.lblMail3.Size = new System.Drawing.Size(470, 33);
            this.lblMail3.TabIndex = 6;
            this.lblMail3.Text = "label4";
            this.lblMail3.Click += new System.EventHandler(this.lblMail3_Click);
            // 
            // lblMail3Date
            // 
            this.lblMail3Date.AutoSize = true;
            this.lblMail3Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail3Date.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail3Date.ForeColor = System.Drawing.Color.Blue;
            this.lblMail3Date.Location = new System.Drawing.Point(485, 75);
            this.lblMail3Date.Name = "lblMail3Date";
            this.lblMail3Date.Size = new System.Drawing.Size(114, 33);
            this.lblMail3Date.TabIndex = 7;
            this.lblMail3Date.Text = "label5";
            // 
            // lblMail4
            // 
            this.lblMail4.AutoSize = true;
            this.lblMail4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail4.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail4.ForeColor = System.Drawing.Color.Blue;
            this.lblMail4.Location = new System.Drawing.Point(6, 111);
            this.lblMail4.Name = "lblMail4";
            this.lblMail4.Size = new System.Drawing.Size(470, 33);
            this.lblMail4.TabIndex = 8;
            this.lblMail4.Text = "label6";
            this.lblMail4.Click += new System.EventHandler(this.lblMail4_Click);
            // 
            // lblMail4Date
            // 
            this.lblMail4Date.AutoSize = true;
            this.lblMail4Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail4Date.Font = new System.Drawing.Font("맑은 고딕", 10.8F);
            this.lblMail4Date.ForeColor = System.Drawing.Color.Blue;
            this.lblMail4Date.Location = new System.Drawing.Point(485, 111);
            this.lblMail4Date.Name = "lblMail4Date";
            this.lblMail4Date.Size = new System.Drawing.Size(114, 33);
            this.lblMail4Date.TabIndex = 9;
            this.lblMail4Date.Text = "label7";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 335);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // mail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.pnlReceive);
            this.Controls.Add(this.pnlMailList);
            this.Controls.Add(this.pnlBanner);
            this.Name = "mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mail";
            this.pnlBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNothing.ResumeLayout(false);
            this.pnlNothing.PerformLayout();
            this.pnlMailList.ResumeLayout(false);
            this.pnlMailList.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxProfile)).EndInit();
            this.pnlReceive.ResumeLayout(false);
            this.pnlMailIn.ResumeLayout(false);
            this.pnlMailIn.PerformLayout();
            this.pnlMailInfo.ResumeLayout(false);
            this.pnlMailInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private PictureBox pictureBox1;
    }
}
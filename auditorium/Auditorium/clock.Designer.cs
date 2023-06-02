
namespace auditorium
{
    partial class clock
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
            this.components = new System.ComponentModel.Container();
            this.lbl_clock_level = new System.Windows.Forms.Label();
            this.lbl_clock_life = new System.Windows.Forms.Label();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.clock_time = new System.Windows.Forms.Label();
            this.pan_clock_explain = new System.Windows.Forms.Panel();
            this.cur_explain = new System.Windows.Forms.Label();
            this.fail_txt = new System.Windows.Forms.Button();
            this.clock_game_success = new System.Windows.Forms.Button();
            this.txt_game_ex_5 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_5_2 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_4 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_4 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_3_2 = new System.Windows.Forms.TextBox();
            this.txt_game_ex_3_1 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_3_1 = new System.Windows.Forms.PictureBox();
            this.pic_game_ex_3_2 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_2 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_2_2 = new System.Windows.Forms.PictureBox();
            this.pic_game_ex_2_1 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_12 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_1_2 = new System.Windows.Forms.PictureBox();
            this.txt_game_ex_1 = new System.Windows.Forms.TextBox();
            this.pic_game_ex_1_1 = new System.Windows.Forms.PictureBox();
            this.btn_left_ex = new System.Windows.Forms.Button();
            this.btn_right_ex = new System.Windows.Forms.Button();
            this.txt_game_ex = new System.Windows.Forms.TextBox();
            this.btn_clock_explain = new System.Windows.Forms.Button();
            this.pan_clock_explain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_clock_level
            // 
            this.lbl_clock_level.AutoSize = true;
            this.lbl_clock_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_clock_level.Location = new System.Drawing.Point(54, 40);
            this.lbl_clock_level.Name = "lbl_clock_level";
            this.lbl_clock_level.Size = new System.Drawing.Size(168, 36);
            this.lbl_clock_level.TabIndex = 7;
            this.lbl_clock_level.Text = "Level : 2 / 1";
            // 
            // lbl_clock_life
            // 
            this.lbl_clock_life.AutoSize = true;
            this.lbl_clock_life.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock_life.Location = new System.Drawing.Point(54, 87);
            this.lbl_clock_life.Name = "lbl_clock_life";
            this.lbl_clock_life.Size = new System.Drawing.Size(107, 36);
            this.lbl_clock_life.TabIndex = 8;
            this.lbl_clock_life.Text = "♥ x  4";
            // 
            // clock_timer
            // 
            this.clock_timer.Interval = 1000;
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // clock_time
            // 
            this.clock_time.AutoSize = true;
            this.clock_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clock_time.Location = new System.Drawing.Point(655, 40);
            this.clock_time.Name = "clock_time";
            this.clock_time.Size = new System.Drawing.Size(90, 36);
            this.clock_time.TabIndex = 9;
            this.clock_time.Text = "600 / ";
            // 
            // pan_clock_explain
            // 
            this.pan_clock_explain.BackgroundImage = global::auditorium.Properties.Resources.tablet;
            this.pan_clock_explain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_clock_explain.Controls.Add(this.cur_explain);
            this.pan_clock_explain.Controls.Add(this.fail_txt);
            this.pan_clock_explain.Controls.Add(this.clock_game_success);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_5);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_5_2);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_4);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_4);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_3_2);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_3_1);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_3_1);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_3_2);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_2);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_2_2);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_2_1);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_12);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_1_2);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex_1);
            this.pan_clock_explain.Controls.Add(this.pic_game_ex_1_1);
            this.pan_clock_explain.Controls.Add(this.btn_left_ex);
            this.pan_clock_explain.Controls.Add(this.btn_right_ex);
            this.pan_clock_explain.Controls.Add(this.txt_game_ex);
            this.pan_clock_explain.Controls.Add(this.btn_clock_explain);
            this.pan_clock_explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_clock_explain.Location = new System.Drawing.Point(0, 0);
            this.pan_clock_explain.Name = "pan_clock_explain";
            this.pan_clock_explain.Size = new System.Drawing.Size(900, 600);
            this.pan_clock_explain.TabIndex = 19;
            // 
            // cur_explain
            // 
            this.cur_explain.AutoSize = true;
            this.cur_explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cur_explain.Location = new System.Drawing.Point(376, 504);
            this.cur_explain.Name = "cur_explain";
            this.cur_explain.Size = new System.Drawing.Size(97, 46);
            this.cur_explain.TabIndex = 56;
            this.cur_explain.Text = "5 / 1";
            // 
            // fail_txt
            // 
            this.fail_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.fail_txt.Location = new System.Drawing.Point(122, 214);
            this.fail_txt.Name = "fail_txt";
            this.fail_txt.Size = new System.Drawing.Size(605, 133);
            this.fail_txt.TabIndex = 55;
            this.fail_txt.Text = "실패했습니다.";
            this.fail_txt.UseVisualStyleBackColor = true;
            this.fail_txt.Click += new System.EventHandler(this.fail_txt_Click);
            // 
            // clock_game_success
            // 
            this.clock_game_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.clock_game_success.Location = new System.Drawing.Point(120, 166);
            this.clock_game_success.Name = "clock_game_success";
            this.clock_game_success.Size = new System.Drawing.Size(605, 229);
            this.clock_game_success.TabIndex = 54;
            this.clock_game_success.Text = "성공했습니다!!!\r\nsecond = 4";
            this.clock_game_success.UseVisualStyleBackColor = true;
            this.clock_game_success.Click += new System.EventHandler(this.clock_game_success_Click);
            // 
            // txt_game_ex_5
            // 
            this.txt_game_ex_5.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_5.Location = new System.Drawing.Point(79, 356);
            this.txt_game_ex_5.Multiline = true;
            this.txt_game_ex_5.Name = "txt_game_ex_5";
            this.txt_game_ex_5.ReadOnly = true;
            this.txt_game_ex_5.Size = new System.Drawing.Size(690, 136);
            this.txt_game_ex_5.TabIndex = 53;
            this.txt_game_ex_5.Text = "퍼즐은 총 2단계로 이루어져 있다.\r\n♥는 4개가 주어지고, 모두 소진시 게임은 종료된다.\r\n";
            this.txt_game_ex_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_game_ex_5_2
            // 
            this.pic_game_ex_5_2.BackgroundImage = global::auditorium.Properties.Resources.clock8;
            this.pic_game_ex_5_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_5_2.Location = new System.Drawing.Point(300, 153);
            this.pic_game_ex_5_2.Name = "pic_game_ex_5_2";
            this.pic_game_ex_5_2.Size = new System.Drawing.Size(250, 100);
            this.pic_game_ex_5_2.TabIndex = 52;
            this.pic_game_ex_5_2.TabStop = false;
            // 
            // txt_game_ex_4
            // 
            this.txt_game_ex_4.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_4.Location = new System.Drawing.Point(122, 372);
            this.txt_game_ex_4.Multiline = true;
            this.txt_game_ex_4.Name = "txt_game_ex_4";
            this.txt_game_ex_4.ReadOnly = true;
            this.txt_game_ex_4.Size = new System.Drawing.Size(603, 117);
            this.txt_game_ex_4.TabIndex = 50;
            this.txt_game_ex_4.Text = "왼쪽과 오른쪽을 같은 모양으로 만들면 된다.\r\n똑같이 만들었다면 왼쪽의 확인버튼을 눌러라.\r\n실패시 ♥가 차감된다.";
            this.txt_game_ex_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_game_ex_4
            // 
            this.pic_game_ex_4.BackgroundImage = global::auditorium.Properties.Resources.clock5;
            this.pic_game_ex_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_4.Location = new System.Drawing.Point(174, 117);
            this.pic_game_ex_4.Name = "pic_game_ex_4";
            this.pic_game_ex_4.Size = new System.Drawing.Size(500, 250);
            this.pic_game_ex_4.TabIndex = 49;
            this.pic_game_ex_4.TabStop = false;
            // 
            // txt_game_ex_3_2
            // 
            this.txt_game_ex_3_2.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_3_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_3_2.Location = new System.Drawing.Point(197, 393);
            this.txt_game_ex_3_2.Multiline = true;
            this.txt_game_ex_3_2.Name = "txt_game_ex_3_2";
            this.txt_game_ex_3_2.ReadOnly = true;
            this.txt_game_ex_3_2.Size = new System.Drawing.Size(434, 81);
            this.txt_game_ex_3_2.TabIndex = 48;
            this.txt_game_ex_3_2.Text = "시간을 누르면 색상으로\r\n색상을 누르면 시간으로 변경할 수 있다.";
            this.txt_game_ex_3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_game_ex_3_1
            // 
            this.txt_game_ex_3_1.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_3_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_3_1.Location = new System.Drawing.Point(399, 243);
            this.txt_game_ex_3_1.Multiline = true;
            this.txt_game_ex_3_1.Name = "txt_game_ex_3_1";
            this.txt_game_ex_3_1.ReadOnly = true;
            this.txt_game_ex_3_1.Size = new System.Drawing.Size(50, 50);
            this.txt_game_ex_3_1.TabIndex = 47;
            this.txt_game_ex_3_1.Text = "↔";
            this.txt_game_ex_3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_game_ex_3_1
            // 
            this.pic_game_ex_3_1.BackgroundImage = global::auditorium.Properties.Resources.clock6;
            this.pic_game_ex_3_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_3_1.Location = new System.Drawing.Point(216, 195);
            this.pic_game_ex_3_1.Name = "pic_game_ex_3_1";
            this.pic_game_ex_3_1.Size = new System.Drawing.Size(150, 150);
            this.pic_game_ex_3_1.TabIndex = 46;
            this.pic_game_ex_3_1.TabStop = false;
            // 
            // pic_game_ex_3_2
            // 
            this.pic_game_ex_3_2.BackgroundImage = global::auditorium.Properties.Resources.clock7;
            this.pic_game_ex_3_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_3_2.Location = new System.Drawing.Point(481, 195);
            this.pic_game_ex_3_2.Name = "pic_game_ex_3_2";
            this.pic_game_ex_3_2.Size = new System.Drawing.Size(150, 150);
            this.pic_game_ex_3_2.TabIndex = 45;
            this.pic_game_ex_3_2.TabStop = false;
            // 
            // txt_game_ex_2
            // 
            this.txt_game_ex_2.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_2.Location = new System.Drawing.Point(232, 408);
            this.txt_game_ex_2.Multiline = true;
            this.txt_game_ex_2.Name = "txt_game_ex_2";
            this.txt_game_ex_2.ReadOnly = true;
            this.txt_game_ex_2.Size = new System.Drawing.Size(386, 81);
            this.txt_game_ex_2.TabIndex = 43;
            this.txt_game_ex_2.Text = "색상인 상태에서 버튼을 누르게 되면\r\n해당 버튼의 색으로 변경되게 된다.";
            this.txt_game_ex_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_game_ex_2_2
            // 
            this.pic_game_ex_2_2.BackgroundImage = global::auditorium.Properties.Resources.clock4;
            this.pic_game_ex_2_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_2_2.Location = new System.Drawing.Point(481, 137);
            this.pic_game_ex_2_2.Name = "pic_game_ex_2_2";
            this.pic_game_ex_2_2.Size = new System.Drawing.Size(250, 250);
            this.pic_game_ex_2_2.TabIndex = 42;
            this.pic_game_ex_2_2.TabStop = false;
            // 
            // pic_game_ex_2_1
            // 
            this.pic_game_ex_2_1.BackgroundImage = global::auditorium.Properties.Resources.clock3;
            this.pic_game_ex_2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_2_1.Location = new System.Drawing.Point(116, 137);
            this.pic_game_ex_2_1.Name = "pic_game_ex_2_1";
            this.pic_game_ex_2_1.Size = new System.Drawing.Size(250, 250);
            this.pic_game_ex_2_1.TabIndex = 41;
            this.pic_game_ex_2_1.TabStop = false;
            // 
            // txt_game_ex_12
            // 
            this.txt_game_ex_12.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_12.Location = new System.Drawing.Point(399, 243);
            this.txt_game_ex_12.Multiline = true;
            this.txt_game_ex_12.Name = "txt_game_ex_12";
            this.txt_game_ex_12.ReadOnly = true;
            this.txt_game_ex_12.Size = new System.Drawing.Size(50, 50);
            this.txt_game_ex_12.TabIndex = 40;
            this.txt_game_ex_12.Text = "→";
            this.txt_game_ex_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_game_ex_1_2
            // 
            this.pic_game_ex_1_2.BackgroundImage = global::auditorium.Properties.Resources.clock2;
            this.pic_game_ex_1_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_2.Location = new System.Drawing.Point(481, 137);
            this.pic_game_ex_1_2.Name = "pic_game_ex_1_2";
            this.pic_game_ex_1_2.Size = new System.Drawing.Size(250, 250);
            this.pic_game_ex_1_2.TabIndex = 39;
            this.pic_game_ex_1_2.TabStop = false;
            // 
            // txt_game_ex_1
            // 
            this.txt_game_ex_1.BackColor = System.Drawing.Color.White;
            this.txt_game_ex_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_game_ex_1.Location = new System.Drawing.Point(228, 408);
            this.txt_game_ex_1.Multiline = true;
            this.txt_game_ex_1.Name = "txt_game_ex_1";
            this.txt_game_ex_1.ReadOnly = true;
            this.txt_game_ex_1.Size = new System.Drawing.Size(386, 81);
            this.txt_game_ex_1.TabIndex = 38;
            this.txt_game_ex_1.Text = "시간인 상태에서 버튼을 누르게 되면, \r\n해당 줄에 1:00을 더하게 된다.";
            this.txt_game_ex_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_game_ex_1_1
            // 
            this.pic_game_ex_1_1.BackgroundImage = global::auditorium.Properties.Resources.clock1;
            this.pic_game_ex_1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_game_ex_1_1.Location = new System.Drawing.Point(116, 137);
            this.pic_game_ex_1_1.Name = "pic_game_ex_1_1";
            this.pic_game_ex_1_1.Size = new System.Drawing.Size(250, 250);
            this.pic_game_ex_1_1.TabIndex = 37;
            this.pic_game_ex_1_1.TabStop = false;
            // 
            // btn_left_ex
            // 
            this.btn_left_ex.FlatAppearance.BorderSize = 0;
            this.btn_left_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left_ex.Location = new System.Drawing.Point(122, 500);
            this.btn_left_ex.Name = "btn_left_ex";
            this.btn_left_ex.Size = new System.Drawing.Size(50, 50);
            this.btn_left_ex.TabIndex = 17;
            this.btn_left_ex.Text = "◀";
            this.btn_left_ex.UseVisualStyleBackColor = true;
            this.btn_left_ex.Click += new System.EventHandler(this.btn_left_ex_Click);
            // 
            // btn_right_ex
            // 
            this.btn_right_ex.FlatAppearance.BorderSize = 0;
            this.btn_right_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right_ex.Location = new System.Drawing.Point(675, 500);
            this.btn_right_ex.Name = "btn_right_ex";
            this.btn_right_ex.Size = new System.Drawing.Size(50, 50);
            this.btn_right_ex.TabIndex = 16;
            this.btn_right_ex.Text = "▶";
            this.btn_right_ex.UseVisualStyleBackColor = true;
            this.btn_right_ex.Click += new System.EventHandler(this.btn_right_ex_Click);
            // 
            // txt_game_ex
            // 
            this.txt_game_ex.BackColor = System.Drawing.Color.White;
            this.txt_game_ex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_game_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_game_ex.Location = new System.Drawing.Point(348, 53);
            this.txt_game_ex.Name = "txt_game_ex";
            this.txt_game_ex.ReadOnly = true;
            this.txt_game_ex.Size = new System.Drawing.Size(150, 46);
            this.txt_game_ex.TabIndex = 5;
            this.txt_game_ex.Text = "퍼즐 설명";
            this.txt_game_ex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clock_explain
            // 
            this.btn_clock_explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clock_explain.Location = new System.Drawing.Point(354, 495);
            this.btn_clock_explain.Name = "btn_clock_explain";
            this.btn_clock_explain.Size = new System.Drawing.Size(140, 60);
            this.btn_clock_explain.TabIndex = 1;
            this.btn_clock_explain.Text = "게임 시작";
            this.btn_clock_explain.UseVisualStyleBackColor = true;
            this.btn_clock_explain.Visible = false;
            this.btn_clock_explain.Click += new System.EventHandler(this.btn_clock_explain_Click);
            // 
            // clock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::auditorium.Properties.Resources.tablet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pan_clock_explain);
            this.Controls.Add(this.clock_time);
            this.Controls.Add(this.lbl_clock_life);
            this.Controls.Add(this.lbl_clock_level);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "clock";
            this.TopMost = true;
            this.pan_clock_explain.ResumeLayout(false);
            this.pan_clock_explain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_game_ex_1_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clock_level;
        private System.Windows.Forms.Label lbl_clock_life;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Label clock_time;
        private System.Windows.Forms.Panel pan_clock_explain;
        private System.Windows.Forms.Button fail_txt;
        private System.Windows.Forms.Button clock_game_success;
        private System.Windows.Forms.PictureBox pic_game_ex_4;
        private System.Windows.Forms.TextBox txt_game_ex_1;
        private System.Windows.Forms.Button btn_left_ex;
        private System.Windows.Forms.Button btn_right_ex;
        private System.Windows.Forms.TextBox txt_game_ex;
        private System.Windows.Forms.Button btn_clock_explain;
        private System.Windows.Forms.TextBox txt_game_ex_5;
        private System.Windows.Forms.PictureBox pic_game_ex_5_2;
        private System.Windows.Forms.TextBox txt_game_ex_4;
        private System.Windows.Forms.TextBox txt_game_ex_3_2;
        private System.Windows.Forms.TextBox txt_game_ex_3_1;
        private System.Windows.Forms.PictureBox pic_game_ex_3_1;
        private System.Windows.Forms.PictureBox pic_game_ex_3_2;
        private System.Windows.Forms.TextBox txt_game_ex_2;
        private System.Windows.Forms.PictureBox pic_game_ex_2_2;
        private System.Windows.Forms.PictureBox pic_game_ex_2_1;
        private System.Windows.Forms.TextBox txt_game_ex_12;
        private System.Windows.Forms.PictureBox pic_game_ex_1_2;
        private System.Windows.Forms.PictureBox pic_game_ex_1_1;
        private System.Windows.Forms.Label cur_explain;
    }
}
namespace ComputerRoom
{
    partial class Comp_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comp_Room));
            btnComputer = new Button();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // btnComputer
            // 
            btnComputer.BackgroundImage = (Image)resources.GetObject("btnComputer.BackgroundImage");
            btnComputer.FlatStyle = FlatStyle.Flat;
            btnComputer.Image = (Image)resources.GetObject("btnComputer.Image");
            btnComputer.Location = new Point(248, 208);
            btnComputer.Name = "btnComputer";
            btnComputer.Size = new Size(135, 82);
            btnComputer.TabIndex = 0;
            btnComputer.UseVisualStyleBackColor = true;
            btnComputer.Click += btnComputer_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(273, 502);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(94, 39);
            btnGoBack.TabIndex = 1;
            btnGoBack.Text = "나가기";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // Comp_Room
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 553);
            Controls.Add(btnGoBack);
            Controls.Add(btnComputer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Comp_Room";
            Text = "Computer Room";
            ResumeLayout(false);
        }

        #endregion

        private Button btnComputer;
        private Button btnGoBack;
    }
}
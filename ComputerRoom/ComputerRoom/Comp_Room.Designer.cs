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
            btnComputer = new Button();
            SuspendLayout();
            // 
            // btnComputer
            // 
            btnComputer.Location = new Point(369, 64);
            btnComputer.Name = "btnComputer";
            btnComputer.Size = new Size(108, 83);
            btnComputer.TabIndex = 0;
            btnComputer.Text = "button1";
            btnComputer.UseVisualStyleBackColor = true;
            btnComputer.Click += btnComputer_Click;
            // 
            // Comp_Room
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(882, 553);
            Controls.Add(btnComputer);
            Name = "Comp_Room";
            Text = "Computer Room";
            ResumeLayout(false);
        }

        #endregion

        private Button btnComputer;
    }
}
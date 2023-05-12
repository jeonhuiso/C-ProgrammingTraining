
namespace StageLibrary
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.Book_Of_Truth = new System.Windows.Forms.Button();
            this.Book_Of_Lie = new System.Windows.Forms.Button();
            this.Book_Of_Dumb = new System.Windows.Forms.Button();
            this.bookShelf1 = new System.Windows.Forms.GroupBox();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.bookShelf2 = new System.Windows.Forms.GroupBox();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.bookShelf3 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnProblemShow = new System.Windows.Forms.Button();
            this.Problem = new System.Windows.Forms.Panel();
            this.btnStoryNext = new System.Windows.Forms.Button();
            this.btnStoryBefore = new System.Windows.Forms.Button();
            this.storyPage2 = new System.Windows.Forms.Label();
            this.storyPage3 = new System.Windows.Forms.Label();
            this.storyPage1 = new System.Windows.Forms.Label();
            this.ProblemExit = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.bookShelf1.SuspendLayout();
            this.bookShelf2.SuspendLayout();
            this.bookShelf3.SuspendLayout();
            this.Problem.SuspendLayout();
            this.SuspendLayout();
            // 
            // Book_Of_Truth
            // 
            this.Book_Of_Truth.BackColor = System.Drawing.Color.Transparent;
            this.Book_Of_Truth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Book_Of_Truth.BackgroundImage")));
            this.Book_Of_Truth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Book_Of_Truth.FlatAppearance.BorderSize = 0;
            this.Book_Of_Truth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_Of_Truth.Location = new System.Drawing.Point(130, 376);
            this.Book_Of_Truth.Name = "Book_Of_Truth";
            this.Book_Of_Truth.Size = new System.Drawing.Size(100, 125);
            this.Book_Of_Truth.TabIndex = 0;
            this.Book_Of_Truth.Tag = "book";
            this.Book_Of_Truth.Text = "Truth";
            this.Book_Of_Truth.UseVisualStyleBackColor = false;
            this.Book_Of_Truth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookMouseDown);
            this.Book_Of_Truth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookMouseMove);
            this.Book_Of_Truth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookMouseUp);
            // 
            // Book_Of_Lie
            // 
            this.Book_Of_Lie.BackColor = System.Drawing.Color.Transparent;
            this.Book_Of_Lie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Book_Of_Lie.BackgroundImage")));
            this.Book_Of_Lie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Book_Of_Lie.FlatAppearance.BorderSize = 0;
            this.Book_Of_Lie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_Of_Lie.Location = new System.Drawing.Point(374, 376);
            this.Book_Of_Lie.Name = "Book_Of_Lie";
            this.Book_Of_Lie.Size = new System.Drawing.Size(100, 125);
            this.Book_Of_Lie.TabIndex = 0;
            this.Book_Of_Lie.Tag = "book";
            this.Book_Of_Lie.Text = "Lie";
            this.Book_Of_Lie.UseVisualStyleBackColor = false;
            this.Book_Of_Lie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookMouseDown);
            this.Book_Of_Lie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookMouseMove);
            this.Book_Of_Lie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookMouseUp);
            // 
            // Book_Of_Dumb
            // 
            this.Book_Of_Dumb.BackColor = System.Drawing.Color.Transparent;
            this.Book_Of_Dumb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Book_Of_Dumb.BackgroundImage")));
            this.Book_Of_Dumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Book_Of_Dumb.FlatAppearance.BorderSize = 0;
            this.Book_Of_Dumb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_Of_Dumb.Location = new System.Drawing.Point(619, 376);
            this.Book_Of_Dumb.Name = "Book_Of_Dumb";
            this.Book_Of_Dumb.Size = new System.Drawing.Size(100, 125);
            this.Book_Of_Dumb.TabIndex = 0;
            this.Book_Of_Dumb.Tag = "book";
            this.Book_Of_Dumb.Text = "Dumb";
            this.Book_Of_Dumb.UseVisualStyleBackColor = false;
            this.Book_Of_Dumb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookMouseDown);
            this.Book_Of_Dumb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookMouseMove);
            this.Book_Of_Dumb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookMouseUp);
            // 
            // bookShelf1
            // 
            this.bookShelf1.BackColor = System.Drawing.Color.Transparent;
            this.bookShelf1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookShelf1.BackgroundImage")));
            this.bookShelf1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookShelf1.Controls.Add(this.btnRemove1);
            this.bookShelf1.Location = new System.Drawing.Point(100, 100);
            this.bookShelf1.Name = "bookShelf1";
            this.bookShelf1.Size = new System.Drawing.Size(150, 200);
            this.bookShelf1.TabIndex = 1;
            this.bookShelf1.TabStop = false;
            this.bookShelf1.Tag = "bookshelf";
            // 
            // btnRemove1
            // 
            this.btnRemove1.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove1.Font = new System.Drawing.Font("굴림", 9F);
            this.btnRemove1.Location = new System.Drawing.Point(0, 171);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(150, 29);
            this.btnRemove1.TabIndex = 2;
            this.btnRemove1.Text = "빼기";
            this.btnRemove1.UseVisualStyleBackColor = false;
            this.btnRemove1.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // bookShelf2
            // 
            this.bookShelf2.BackColor = System.Drawing.Color.Transparent;
            this.bookShelf2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookShelf2.BackgroundImage")));
            this.bookShelf2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookShelf2.Controls.Add(this.btnRemove2);
            this.bookShelf2.Location = new System.Drawing.Point(350, 100);
            this.bookShelf2.Name = "bookShelf2";
            this.bookShelf2.Size = new System.Drawing.Size(150, 200);
            this.bookShelf2.TabIndex = 1;
            this.bookShelf2.TabStop = false;
            this.bookShelf2.Tag = "bookshelf";
            // 
            // btnRemove2
            // 
            this.btnRemove2.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove2.Font = new System.Drawing.Font("굴림", 9F);
            this.btnRemove2.Location = new System.Drawing.Point(0, 171);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(150, 29);
            this.btnRemove2.TabIndex = 2;
            this.btnRemove2.Text = "빼기";
            this.btnRemove2.UseVisualStyleBackColor = false;
            this.btnRemove2.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // bookShelf3
            // 
            this.bookShelf3.BackColor = System.Drawing.Color.Transparent;
            this.bookShelf3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookShelf3.BackgroundImage")));
            this.bookShelf3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookShelf3.Controls.Add(this.btnRemove);
            this.bookShelf3.Location = new System.Drawing.Point(600, 100);
            this.bookShelf3.Name = "bookShelf3";
            this.bookShelf3.Size = new System.Drawing.Size(150, 200);
            this.bookShelf3.TabIndex = 1;
            this.bookShelf3.TabStop = false;
            this.bookShelf3.Tag = "bookshelf";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.Location = new System.Drawing.Point(0, 171);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 29);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "빼기";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnProblemShow
            // 
            this.btnProblemShow.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnProblemShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProblemShow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProblemShow.Location = new System.Drawing.Point(780, 409);
            this.btnProblemShow.Name = "btnProblemShow";
            this.btnProblemShow.Size = new System.Drawing.Size(100, 45);
            this.btnProblemShow.TabIndex = 2;
            this.btnProblemShow.Text = "문제 보기";
            this.btnProblemShow.UseVisualStyleBackColor = false;
            this.btnProblemShow.Click += new System.EventHandler(this.btnProblemShow_Click);
            // 
            // Problem
            // 
            this.Problem.BackColor = System.Drawing.Color.White;
            this.Problem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Problem.BackgroundImage")));
            this.Problem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Problem.Controls.Add(this.btnStoryNext);
            this.Problem.Controls.Add(this.btnStoryBefore);
            this.Problem.Controls.Add(this.storyPage2);
            this.Problem.Controls.Add(this.storyPage3);
            this.Problem.Controls.Add(this.storyPage1);
            this.Problem.Controls.Add(this.ProblemExit);
            this.Problem.Location = new System.Drawing.Point(0, 10);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(896, 571);
            this.Problem.TabIndex = 3;
            this.Problem.Visible = false;
            // 
            // btnStoryNext
            // 
            this.btnStoryNext.BackColor = System.Drawing.Color.Transparent;
            this.btnStoryNext.FlatAppearance.BorderSize = 0;
            this.btnStoryNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryNext.Location = new System.Drawing.Point(602, 465);
            this.btnStoryNext.Name = "btnStoryNext";
            this.btnStoryNext.Size = new System.Drawing.Size(101, 46);
            this.btnStoryNext.TabIndex = 3;
            this.btnStoryNext.Text = "다음 페이지";
            this.btnStoryNext.UseVisualStyleBackColor = false;
            this.btnStoryNext.Click += new System.EventHandler(this.btnStoryNext_Click);
            // 
            // btnStoryBefore
            // 
            this.btnStoryBefore.BackColor = System.Drawing.Color.Transparent;
            this.btnStoryBefore.FlatAppearance.BorderSize = 0;
            this.btnStoryBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryBefore.Location = new System.Drawing.Point(19, 467);
            this.btnStoryBefore.Name = "btnStoryBefore";
            this.btnStoryBefore.Size = new System.Drawing.Size(101, 46);
            this.btnStoryBefore.TabIndex = 3;
            this.btnStoryBefore.Text = "이전 페이지";
            this.btnStoryBefore.UseVisualStyleBackColor = false;
            this.btnStoryBefore.Click += new System.EventHandler(this.btnStoryBefore_Click);
            // 
            // storyPage2
            // 
            this.storyPage2.AutoSize = true;
            this.storyPage2.Location = new System.Drawing.Point(466, 54);
            this.storyPage2.Name = "storyPage2";
            this.storyPage2.Size = new System.Drawing.Size(482, 180);
            this.storyPage2.TabIndex = 2;
            this.storyPage2.Text = resources.GetString("storyPage2.Text");
            this.storyPage2.Click += new System.EventHandler(this.storyPage2_Click);
            // 
            // storyPage3
            // 
            this.storyPage3.AutoSize = true;
            this.storyPage3.Location = new System.Drawing.Point(42, 54);
            this.storyPage3.Name = "storyPage3";
            this.storyPage3.Size = new System.Drawing.Size(477, 150);
            this.storyPage3.TabIndex = 2;
            this.storyPage3.Text = resources.GetString("storyPage3.Text");
            // 
            // storyPage1
            // 
            this.storyPage1.AutoSize = true;
            this.storyPage1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.storyPage1.Location = new System.Drawing.Point(45, 54);
            this.storyPage1.Name = "storyPage1";
            this.storyPage1.Size = new System.Drawing.Size(812, 323);
            this.storyPage1.TabIndex = 1;
            this.storyPage1.Text = resources.GetString("storyPage1.Text");
            this.storyPage1.UseCompatibleTextRendering = true;
            // 
            // ProblemExit
            // 
            this.ProblemExit.BackColor = System.Drawing.Color.Transparent;
            this.ProblemExit.FlatAppearance.BorderSize = 0;
            this.ProblemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProblemExit.Location = new System.Drawing.Point(732, 465);
            this.ProblemExit.Name = "ProblemExit";
            this.ProblemExit.Size = new System.Drawing.Size(100, 48);
            this.ProblemExit.TabIndex = 0;
            this.ProblemExit.Text = "나가기";
            this.ProblemExit.UseVisualStyleBackColor = false;
            this.ProblemExit.Click += new System.EventHandler(this.ProblemExit_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(780, 460);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 50);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "정답 제출";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // Level1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 590);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.Book_Of_Dumb);
            this.Controls.Add(this.Book_Of_Truth);
            this.Controls.Add(this.Book_Of_Lie);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnProblemShow);
            this.Controls.Add(this.bookShelf3);
            this.Controls.Add(this.bookShelf2);
            this.Controls.Add(this.bookShelf1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level1";
            this.Text = "Level1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Level1_Load);
            this.bookShelf1.ResumeLayout(false);
            this.bookShelf2.ResumeLayout(false);
            this.bookShelf3.ResumeLayout(false);
            this.Problem.ResumeLayout(false);
            this.Problem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Book_Of_Truth;
        private System.Windows.Forms.Button Book_Of_Lie;
        private System.Windows.Forms.Button Book_Of_Dumb;
        private System.Windows.Forms.GroupBox bookShelf1;
        private System.Windows.Forms.GroupBox bookShelf2;
        private System.Windows.Forms.GroupBox bookShelf3;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnProblemShow;
        private System.Windows.Forms.Panel Problem;
        private System.Windows.Forms.Button ProblemExit;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label storyPage1;
        private System.Windows.Forms.Label storyPage2;
        private System.Windows.Forms.Label storyPage3;
        private System.Windows.Forms.Button btnStoryNext;
        private System.Windows.Forms.Button btnStoryBefore;
    }
}
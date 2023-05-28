using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StageLibrary
{
    
    public partial class Level1 : Form
    {
        
        public delegate void SendStage1Clear(bool isClear);
        public event SendStage1Clear SendStage1Event;
        public delegate void Level1Load();
        public event Level1Load Level1LoadEvent;
        public Level1()
        {
            InitializeComponent();
        }

        bool[] bookMove = new bool[3] { false, false, false };//순서대로 진실 거짓 무지
        bool[] bookCorrect = new bool[3] { false, false, false };
        bool[] hiddenCorrect = new bool[3] { false, false, false };
        int storyPage =1;
        Label[] storyPageList;
        //문제 load
        private void Level1_Load(object sender, EventArgs e)
        {
            Book_Of_Truth.Location = new System.Drawing.Point(135, 300);
            Book_Of_Dumb.Location = new System.Drawing.Point(375, 300);
            Book_Of_Lie.Location = new System.Drawing.Point(625, 300);
            
                PrivateFontCollection fontCollection = new PrivateFontCollection();
                fontCollection.AddFontFile("강원교육현옥샘.ttf");
                foreach (Control c in this.Controls)
                {
                    c.Font = new Font(fontCollection.Families[0], 13f);
                    if (c is GroupBox)
                        foreach (Control c_1 in ((GroupBox)c).Controls)
                            c_1.Font = new Font(fontCollection.Families[0], 13f);

                    if (c is Panel)
                        foreach (Control c_1 in ((Panel)c).Controls)
                            c_1.Font = new Font(fontCollection.Families[0], 13f);
                }
            storyPageList = new Label[3] { storyPage1, storyPage2, storyPage3 };
            storyPage1.BackColor = Color.FromArgb(0, 0, 0, 0);
            storyPage2.BackColor = Color.FromArgb(0, 0, 0, 0);
            storyPage3.BackColor = Color.FromArgb(0, 0, 0, 0);
            Problem.BackColor = Color.FromArgb(0, 0, 0, 0);
            Level1LoadEvent();
            storyPage3.Visible = false;
        }

        System.Drawing.Point point;
        //책을 드래그하기 위해 마우스를 눌렀을 때
        public void BookMouseDown(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Left)
            {
                if (((Button)sender).Name == "Book_Of_Truth")
                    bookMove[0] = true;
                else
                    bookMove[0] = false;
                if (((Button)sender).Name == "Book_Of_Lie")
                    bookMove[1] = true;
                else if (((Button)sender).Name == "Book_Of_Dumb")
                    bookMove[2] = true;
                else
                    bookMove[2] = false;
                point = Cursor.Position;
            }
        }
        //마우스 클릭 버튼이 올라갈때 책의 위치확인 책받침대 위면 책받대로, 아니면 원래 위치로 전송
        public void BookMouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is GroupBox && (string)x.Tag == "bookshelf") {
                        if (((Control)sender).Bounds.IntersectsWith(x.Bounds)&&x.Controls.Count==1) {
                            x.Controls.Add((Control)sender);
                            ((Control)sender).Location = new Point(20, 30);

                            if (x.Name == "bookShelf1")
                            {
                                if (x.Controls[1].Name == "Book_Of_Truth")
                                {
                                    bookCorrect[0] = true;
                                    hiddenCorrect[0] = false;
                                }
                                else if(x.Controls[1].Name == "Book_Of_Dumb")
                                {
                                    bookCorrect[0] = false;
                                    hiddenCorrect[0] = true;
                                }
                                else
                                {
                                    bookCorrect[0] = false;
                                    hiddenCorrect[0] = false;
                                }
                            }
                            if (x.Name == "bookShelf2")
                            {
                                if (x.Controls[1].Name == "Book_Of_Dumb")
                                {
                                    bookCorrect[1] = true;
                                    hiddenCorrect[1] = false;
                                }
                                else if(x.Controls[1].Name == "Book_Of_Truth")
                                {
                                    bookCorrect[1] = false;
                                    hiddenCorrect[1] = true;
                                }
                                else
                                {
                                    bookCorrect[1] = false;
                                    hiddenCorrect[1] = false;
                                }


                            }
                            if (x.Name == "bookShelf3")
                            {
                                if (x.Controls[1].Name == "Book_Of_Lie")
                                {
                                    bookCorrect[2] = true;
                                    hiddenCorrect[2] = true;
                                }
                                else
                                {
                                    bookCorrect[2] = false;
                                    hiddenCorrect[2] = false;
                                }
                            }
                            break;
                        }
                    }
                }
                if ((string)(((Control)sender).Parent.Tag) != "bookshelf")
                {
                    if (((Button)sender).Name == "Book_Of_Truth")
                        ((Button)sender).Location = new System.Drawing.Point(135, 300);
                    else if (((Button)sender).Name == "Book_Of_Lie")
                        ((Button)sender).Location = new System.Drawing.Point(625, 300);
                    else if (((Button)sender).Name == "Book_Of_Dumb")
                        ((Button)sender).Location = new System.Drawing.Point(375, 300);
                }
                else 
                    ((Button)sender).Location = new Point(20, 14);
                // MessageBox.Show(point.X + ", " + point.Y);
                for (int i = 0; i < bookMove.Length; i++)
                    bookMove[i] = false;
            }
        }

        public void BookMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = Cursor.Position.X - point.X;
                int y = Cursor.Position.Y - point.Y;
                if (bookMove[0])
                {
                    Point tmp = Book_Of_Truth.Location;
                    tmp.Offset(x, y);
                    Book_Of_Truth.Location = tmp;
                }
                else if (bookMove[1])
                {
                    Point tmp = Book_Of_Lie.Location;
                    tmp.Offset(x, y);
                    Book_Of_Lie.Location = tmp;
                }
                else if (bookMove[2])
                {
                    Point tmp = Book_Of_Dumb.Location;
                    tmp.Offset(x, y);
                    Book_Of_Dumb.Location = tmp;
                }
                point = Cursor.Position;
            }
        }
        private void BtnRemove_Click(object sender, EventArgs e) {
            if (((Control)sender).Parent.Controls.Count==2) {
                for (int i = 0; i < ((Control)sender).Parent.Controls.Count; i++) {

                    if (((Control)sender).Parent.Controls[i].Tag == "book") {
                        if (((Control)sender).Parent.Name == "bookShelf1") 
                            bookCorrect[0] = false;
                        if (((Control)sender).Parent.Name == "bookShelf2")
                            bookCorrect[1] = false;
                        if (((Control)sender).Parent.Name == "bookShelf3")
                            bookCorrect[2] = false;
                        ((Control)sender).Parent.Controls[i].Parent = this;

                        if (Book_Of_Truth.Parent==this)
                            Book_Of_Truth.Location = new System.Drawing.Point(135, 300);
                        if (Book_Of_Lie.Parent == this)
                            Book_Of_Lie.Location = new System.Drawing.Point(625, 300);
                        if (Book_Of_Dumb.Parent == this)
                            Book_Of_Dumb.Location = new System.Drawing.Point(375, 300);
                    }
                }
            }
        }

        //문제 보기 버튼
        private void btnProblemShow_Click(object sender, EventArgs e)
        {
            Problem.Visible = true;
        }
        //문제 나가기 버튼
        private void ProblemExit_Click(object sender, EventArgs e)
        {
            Problem.Visible = false;
        }
        //문제 풀이버튼
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (hiddenCorrect[0] && hiddenCorrect[1] && hiddenCorrect[2]) {
                MessageBox.Show("Mat 0x:xx");
                SendStage1Event(true);
            }
            else if (bookCorrect[0]&& bookCorrect[1] && bookCorrect[2]) {
                SendStage1Event(true);
            }
            else
            {
                SendStage1Event(false);
            }
        }

        private void btnStoryNext_Click(object sender, EventArgs e)
        {
            if (storyPage == 1) {
                btnStoryBefore.Enabled = true;
            }
            storyPage++;
            if (storyPage >= 2) {
                storyPage = 2;
                btnStoryNext.Enabled = false;
            }

            if (2 == storyPage)
            {
                storyPageList[2].Visible = true;
                storyPageList[1].Visible = false;
                storyPageList[0].Visible = false;
            }
        }

        private void btnStoryBefore_Click(object sender, EventArgs e)
        {
            if (storyPage == 2)
            {
                btnStoryNext.Enabled = true;
            }
            storyPage--;
            if (storyPage <=1)
            {
                storyPage = 1;
                btnStoryBefore.Enabled = false;
            }
            if (1 == storyPage)
            {
                storyPageList[2].Visible = false;
                storyPageList[1].Visible = true;
                storyPageList[0].Visible = true;
            }
            
        }


        private void Problem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Level1_VisibleChanged(object sender, EventArgs e)
        {
                for (int i = 0; i < bookShelf1.Controls.Count; i++)
                {
                    if (bookShelf1.Controls[i].Tag == "book")
                    {
                        bookShelf1.Controls[i].Parent = this;
                    }
                }
                for (int i = 0; i < bookShelf2.Controls.Count; i++)
                {
                    if (bookShelf2.Controls[i].Tag == "book")
                    {
                        bookShelf2.Controls[i].Parent = this;
                    }
                }
                for (int i = 0; i < bookShelf3.Controls.Count; i++)
                {
                    if (bookShelf3.Controls[i].Tag == "book")
                    {
                        bookShelf3.Controls[i].Parent = this;
                    }
                }
                if (Book_Of_Truth.Parent == this)
                {
                    Book_Of_Truth.Location = new System.Drawing.Point(135, 300);
                }
                if (Book_Of_Lie.Parent == this)
                {
                    Book_Of_Lie.Location = new System.Drawing.Point(625, 300);
                }
                if (Book_Of_Dumb.Parent == this)
                {
                    Book_Of_Dumb.Location = new System.Drawing.Point(375, 300);
                }
            
        }
    }
}

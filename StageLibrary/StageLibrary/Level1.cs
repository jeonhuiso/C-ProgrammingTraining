﻿using System;
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
        public Level1()
        {
            InitializeComponent();
        }

        bool[] bookMove = new bool[3] { false, false, false };//순서대로 진실 거짓 무지
        bool[] bookCorrect = new bool[3] { false, false, false };
        int storyPage =1;
        Label[] storyPageList;
        private void Level1_Load(object sender, EventArgs e)
        {
            Book_Of_Truth.Location = new System.Drawing.Point(135, 300);
            Book_Of_Dumb.Location = new System.Drawing.Point(375, 300);
            Book_Of_Lie.Location = new System.Drawing.Point(625, 300);

            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("강원교육현옥샘.ttf");

            foreach (Control c in this.Controls) {
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
            
            storyPage3.Visible = false;
        }
        System.Drawing.Point point;
        public void BookMouseDown(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Left)
            {
                if (((Button)sender).Name == "Book_Of_Truth")
                {
                    //MessageBox.Show("this is Book_Of_Truth");
                    bookMove[0] = true;
                }
                else
                {
                    bookMove[0] = false;
                }
                if (((Button)sender).Name == "Book_Of_Lie")
                {
                    // MessageBox.Show("this is Book_Of_Lie");
                    bookMove[1] = true;
                }
                else
                {
                    bookMove[1] = false;
                }
                if (((Button)sender).Name == "Book_Of_Dumb")
                {
                    // MessageBox.Show("this is Book_Of_Dumb");
                    bookMove[2] = true;
                }
                else
                {
                    bookMove[2] = false;
                }
                point = Cursor.Position;
            }
        }
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
                                }
                                else
                                {
                                    bookCorrect[0] = false;
                                }
                            }
                            if (x.Name == "bookShelf2")
                            {
                                if (x.Controls[1].Name == "Book_Of_Dumb")
                                {
                                    bookCorrect[1] = true;
                                }
                                else
                                {
                                    bookCorrect[1] = false;
                                }
                            }
                            if (x.Name == "bookShelf3")
                            {
                                if (x.Controls[1].Name == "Book_Of_Lie")
                                {
                                    bookCorrect[2] = true;
                                }
                                else
                                {
                                    bookCorrect[2] = false;
                                }
                            }
                            break;
                        }
                    }
                }
                if ((string)(((Control)sender).Parent.Tag) != "bookshelf")
                {
                    if (((Button)sender).Name == "Book_Of_Truth")
                    {
                        ((Button)sender).Location = new System.Drawing.Point(135, 300);
                    }
                    else if (((Button)sender).Name == "Book_Of_Lie")
                    {
                        ((Button)sender).Location = new System.Drawing.Point(625, 300);
                    }
                    else if (((Button)sender).Name == "Book_Of_Dumb")
                    {
                        ((Button)sender).Location = new System.Drawing.Point(375, 300);
                    }
                }
                else { 
                    ((Button)sender).Location = new Point(20, 14);
                }
                // MessageBox.Show(point.X + ", " + point.Y);
                for (int i = 0; i < bookMove.Length; i++)
                {
                    bookMove[i] = false;
                    
                }
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
                        if (((Control)sender).Parent.Name == "bookShelf1") {
                            bookCorrect[0] = false;
                        }
                        if (((Control)sender).Parent.Name == "bookShelf2")
                        {
                            bookCorrect[1] = false;
                        }
                        if (((Control)sender).Parent.Name == "bookShelf3")
                        {
                            bookCorrect[2] = false;
                        }
                        ((Control)sender).Parent.Controls[i].Parent = this;

                        if (Book_Of_Truth.Parent==this)
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
        }

        private void btnProblemShow_Click(object sender, EventArgs e)
        {
            Problem.Visible = true;
        }

        private void ProblemExit_Click(object sender, EventArgs e)
        {
            Problem.Visible = false;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (bookCorrect[0]&& bookCorrect[1] && bookCorrect[2]) {
                SendStage1Event(true);
            }
            else
            {
                SendStage1Event(false);
            }
            this.Visible = false;
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

        private void storyPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

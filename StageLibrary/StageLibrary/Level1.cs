using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StageLibrary
{
    
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
        }
        bool[] bookMove = new bool[3] { false, false, false };//순서대로 진실 거짓 무지
        private void Level1_Load(object sender, EventArgs e)
        {
            Book_Of_Truth.Location = new System.Drawing.Point(300, 300);
            Book_Of_Dumb.Location = new System.Drawing.Point(450, 300);
            Book_Of_Lie.Location = new System.Drawing.Point(600, 300);
            

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
    }
}

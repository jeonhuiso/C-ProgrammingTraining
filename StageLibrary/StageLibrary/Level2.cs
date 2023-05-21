using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
namespace StageLibrary
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }
        public delegate void sendStage2Clear(bool isclear);
        public event sendStage2Clear sendStage2Event;
        public delegate void Level2Load();
        public event Level2Load level2LoadEvent;
        List<PictureBox> bookList = new List<PictureBox>(new PictureBox[6]);
        List<bool> bookchecked = new List<bool>(6){true,false,false,true,false,false};
        
        private void Level2_Load(object sender, EventArgs e)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("강원교육현옥샘.ttf");
           
            foreach (Control c in this.Controls) {
                c.Font = new Font(fontCollection.Families[0], 13f);
                if (c.Tag == "book")
                {
                    ((PictureBox)c).BackgroundImage = imageList1.Images[1];
                }
            }
            bookList[0] = book1;
            bookList[1] = book2;
            bookList[2] = book3;
            bookList[3] = book4;
            bookList[4] = book5;
            bookList[5] = book6;
            BookChange();

        }
        void BookChange() {
            for (int i = 0; i < bookchecked.Count; i++)
            {
                if (bookchecked[i])
                    bookList[i].BackgroundImage = imageList1.Images[0];
                else
                    bookList[i].BackgroundImage = imageList1.Images[1];
            }
        }
        private void bookMouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }
        private void bookMouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }
        private void bookClick(object sender, MouseEventArgs e)
        {
            for(int i=0;i<bookList.Count;i++)
            {
                if (bookList[i] == ((PictureBox)sender)) {
                    bookchecked[i] = !bookchecked[i];
                    bookchecked[(i + 1) % 6] = !bookchecked[(i + 1) % 6];
                    if (i > 0)
                    {
                        bookchecked[i - 1] = !bookchecked[i - 1];
                    }
                    else {
                        bookchecked[5] = !bookchecked[5];
                    }
                    break;
                }
            }
            BookChange();
            if(bookchecked[0]&& bookchecked[1] && bookchecked[2] && bookchecked[3] && bookchecked[4] && bookchecked[5])
            {
                sendStage2Event(true);
            }
        }

        private void Level2_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                bookchecked = new List<bool>(6) { true, false, false, true, false, false };
                level2LoadEvent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnBookExit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

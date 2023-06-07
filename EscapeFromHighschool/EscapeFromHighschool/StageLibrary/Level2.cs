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
namespace EscapeFromHighschool
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }
        //level2 클리어시 이벤트
        public delegate void sendStage2Clear(bool isclear);
        public event sendStage2Clear sendStage2Event;
        //level2 실행시 이벤트
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

        //책 이미지 변경 메서드
        void BookChange() {
            for (int i = 0; i < bookchecked.Count; i++)
            {
                if (bookchecked[i])
                    bookList[i].BackgroundImage = imageList1.Images[0];
                else
                    bookList[i].BackgroundImage = imageList1.Images[1];
            }
        }
        //책에 마우스 커서 진입시 테두리 켜지는 메서드
        private void bookMouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }
        //책에 마우스 커서 이탈시 테두리 켜지는 메서드
        private void bookMouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }
        //책 클릭시 관련된 책들이 들어가거나 나오는 메서드
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
            //모든 책이 전부 들어갈시 클리어 이벤트 실행
            if(bookchecked[0]&& bookchecked[1] && bookchecked[2] && bookchecked[3] && bookchecked[4] && bookchecked[5])
            {
                sendStage2Event(true);
            }
        }
        //visible이 바뀌면 생성 이벤트 실행
        private void Level2_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                bookchecked = new List<bool>(6) { true, false, false, true, false, false };
                level2LoadEvent();
            }
        }
        //히든 엔딩용 암호를 얻기위한 책 클릭시
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        //책을 다 보았을시
        private void btnBookExit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

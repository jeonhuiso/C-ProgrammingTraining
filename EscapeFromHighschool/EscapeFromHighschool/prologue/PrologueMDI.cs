using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EscapeFromHighschool
{
    public partial class PrologueMDI : Form
    {
        //각 스테이지 실행시 호출되는 이벤트
        public delegate void LibraryStageOpen();
        public event LibraryStageOpen LibraryStageOpenEvent;
        public delegate void AuditoriumStageOpen();
        public event AuditoriumStageOpen AuditoriumStageOpenEvent;
        public delegate void ComputerStageOpen();
        public event ComputerStageOpen ComputerStageOpenEvent;
        public delegate void ScienceStageOpen();
        public event ScienceStageOpen ScienceStageOpenEvent;

        const string address = "..\\..\\..\\..\\Image\\";
        ContextForm contextForm;
        int page = 0;
        public PrologueMDI()
        {
            InitializeComponent();
        }

        //프롤로그 실행시 사용하는 이벤트핸들러
        void StartCommentMain() {
            contextForm.Enabled = true;
        }
        void MainMenuLoad() {

        }
        //프롤로그 실행 메서드
        void EndCommentMain()
        {
            switch (++page) {
                case 1:
                    PrologueMain.BackgroundImage = Image.FromFile(address + "미술실.png");
                    contextForm.ScriptParse("prologue2", "prologue");
                    break;
                case 2:
                    PrologueMain.BackgroundImage = Image.FromFile(address + "밤길.png");
                    contextForm.ScriptParse("prologue3", "prologue");
                    break;
                case 3:
                    PrologueMain.BackgroundImage = Image.FromFile(address + "교실.png");
                    contextForm.ScriptParse("prologue4", "prologue");
                    break;
                case 4:
                    contextForm.ScriptParse("prologue5", "prologue");
                    break;
                default:
                    MainMenuLoad();
                    PrologueMain.Visible = false;
                    MainMenu.BackgroundImage = Image.FromFile(address + "칠판.png");
                    MainMenu.Visible = true;
                    break;
            }
        }
        private void MDIContainer_Load(object sender, EventArgs e)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("강원교육현옥샘.ttf");
            this.Font = new Font(fontCollection.Families[0], 17f);
            label1.Font = new Font(fontCollection.Families[0], 30f);
            contextForm = new ContextForm();
            contextForm.Show();
            contextForm.MdiParent = this;
            contextForm.Location = new Point(0, 595);
            contextForm.StartCommentEvent += new ContextForm.StartComment(StartCommentMain);
            contextForm.EndCommentEvent += new ContextForm.EndComment(EndCommentMain);

        }
        //해당 스테이지 클리어시 스테이지 진입버튼 사용 불가하게 하는 메서드
        public void BtnEnable(string what) { 
           /* if (what == "library")
            {
                btnLibrary.Enabled = false;
                btnLibrary.BackgroundImage = Image.FromFile(address + "x.png");
            }
            if (what == "auditorium")
            {
                    btnAuditorium.Enabled = false;
                    btnAuditorium.BackgroundImage = Image.FromFile(address + "x.png");
            
            }
            if (what == "computer")
            {
                btnComputer.Enabled = false;
                btnComputer.BackgroundImage = Image.FromFile(address + "x.png");
            }
            if (what == "science")
            {
                btnScience.Enabled = false;
                btnScience.BackgroundImage = Image.FromFile(address + "x.png");
            }*/

        }
        //시작화면에서 게임시작 버튼 클릭시 실행 이벤트핸들러
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartMain.Visible = false;
            contextForm.ScriptParse("prologue1", "prologue");
        }

        //시작 화면에서 나가기 버튼 클릭시 실행 이벤트핸들러
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //메인메뉴 보이게하기
        public void ShowMainMenu()
        {
            MainMenu.Visible = true;
        }

        //각 스테이지 버튼 클릭시 실행 이벤트핸들러
        private void btnLibrary_Click(object sender, EventArgs e)
        {
            LibraryStageOpenEvent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComputerStageOpenEvent();
        }

        private void btnAuditorium_Click(object sender, EventArgs e)
        {
            AuditoriumStageOpenEvent();
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            ScienceStageOpenEvent();
        }
    }
}

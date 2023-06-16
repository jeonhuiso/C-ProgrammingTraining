using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using auditorium;
using SWGame;
using ComputerRoom;
using System.Runtime.Remoting.Channels;
using System.Collections.Specialized;

namespace EscapeFromHighschool
{
    public partial class MDIparent : Form
    {

        public MDIparent()
        {
            InitializeComponent();
        }
        //prologue form
        PrologueMDI prologueMDI;
        //각 스테이지 form
        auditorium_MDI auditorium;
        science sciencRoom;
        LibraryStage libraryStage;
        Comp_Room CompRoom;
        //엔딩 form
        EndingMDI endingMDI;
        //대사창 form
        ContextForm contextform;
        //스테이지 확인용 string
        string[] stageMain = new string[4] { "library", "auditorium", "science", "computer" };
        //각 스테이지 클리어 여부를 나타내는 bool자료형 배열
        bool[] stageClearCheck = new bool[4] { false, false, false, false };  
        private void MDIparent_Load(object sender, EventArgs e)
        {
            //각 폼 객체 생성
            prologueMDI = new PrologueMDI();
            prologueMDI.Show();
            prologueMDI.LibraryStageOpenEvent += new PrologueMDI.LibraryStageOpen(libraryStageOpen);
            prologueMDI.AuditoriumStageOpenEvent += new PrologueMDI.AuditoriumStageOpen(AuditoriumOpen);
            prologueMDI.ScienceStageOpenEvent += new PrologueMDI.ScienceStageOpen(ScienceOpen);
               prologueMDI.ComputerStageOpenEvent += new PrologueMDI.ComputerStageOpen(CompOpen);

        }
        //방 클리어 확인용 메소드
        private void RoomClearCheck(string n) {
            for (int i = 0; i < 4; i++)
            {
                if (n == stageMain[i])
                {
                    stageClearCheck[i] = true;

                    // MessageBox.Show(stageMain[i] + "clear");
                }
                if (prologueMDI != null)
                {
                    if (stageMain[i] == "library" && stageClearCheck[i])
                    {
                        prologueMDI.BtnEnable("library");
                    }
                    else
                    if (stageMain[i] == "auditorium" && stageClearCheck[i])
                    {
                        prologueMDI.BtnEnable("auditorium");
                    }
                    else
                    if (stageMain[i] == "science" && stageClearCheck[i])
                    {
                        prologueMDI.BtnEnable("science");
                    }
                    else
                    if (stageMain[i] == "computer" && stageClearCheck[i])
                    {
                        prologueMDI.BtnEnable("computer");
                    }
                }
            }
            //모든 스테이지 클리어시 엔딩용 form 생성
            if (AllClearCheck()) {
                prologueMDI.Dispose();
                endingMDI = new EndingMDI();
                endingMDI.Show();
            }
           // MessageBox.Show("clear :"+ stageClearCheck[0].ToString()+ stageClearCheck[1].ToString()+stageClearCheck[2].ToString()+stageClearCheck[3].ToString());

        }
        //이벤트 핸들러
        void contextFormClosing(object sender, FormClosedEventArgs e) {
            contextform.Dispose();
        }
        //컴퓨터실 스테이지 클릭시 생성
        void CompOpen()
        {
            CompRoom =new Comp_Room();
            CompRoom.Location = prologueMDI.DesktopLocation;
            CompRoom.Show();
            CompRoom.ComClearEvent += new Comp_Room.CompClear(RoomClearCheck);
            CompRoom.ComClearEvent += new Comp_Room.CompClear((s) => { contextform.ScriptParse("CompEnd", "CompRoom"); });
            CompRoom.FormClosed += new FormClosedEventHandler(contextFormClosing);
            CompRoom.PCClickEvent += new Comp_Room.PCClick(() => contextform.ScriptParse("CompOn", "CompRoom"));
            
            contextform = new ContextForm();
            contextform.Location = new Point(CompRoom.DesktopLocation.X, CompRoom.DesktopLocation.Y + 600);
            contextform.StartCommentEvent += new ContextForm.StartComment(() => CompRoom.Enabled = false);
            contextform.EndCommentEvent += new ContextForm.EndComment(() => CompRoom.Enabled = true);
            contextform.Show();
            contextform.ScriptParse("CompRoomStart","CompRoom");
            
        }
        //과학실 스테이지 클릭시 생성
        void ScienceOpen()
        {
            sciencRoom = new science();
            sciencRoom.Show();
            sciencRoom.Location = prologueMDI.DesktopLocation;
            sciencRoom.scienceRoomclearEvent += new science.scienceRoomClear(RoomClearCheck);
            sciencRoom.FormClosed += new FormClosedEventHandler(contextFormClosing);
            sciencRoom.LaptopOpenEvent += new science.LaptopOpen(() => { contextform.ScriptParse("scienceCom", "science"); });
            sciencRoom.LockerOpenEvent += new science.LockerOpen(() =>contextform.ScriptParse("scienceLockOpen","science"));
            sciencRoom.LockerBoomEvent += new science.LockerBoom(() => contextform.ScriptParse("scienceBoom", "science"));
            sciencRoom.NaClickEvent += new science.NaClick(() => contextform.ScriptParse("scienceNaClick", "science"));
            sciencRoom.FormClosed += new FormClosedEventHandler(contextFormClosing);
            contextform = new ContextForm();
            contextform.StartCommentEvent += new ContextForm.StartComment(() => sciencRoom.Enabled = false);
            contextform.EndCommentEvent += new ContextForm.EndComment(() => sciencRoom.Enabled = true);
            contextform.Location = new Point(sciencRoom.DesktopLocation.X, sciencRoom.DesktopLocation.Y + 600);
            contextform.ScriptParse("scienceStart", "science");
            contextform.Show();
        }
        //도서관 스테이지 클릭시 생성
        void libraryStageOpen()
        {
            libraryStage = new LibraryStage();
            libraryStage.Show();
            libraryStage.libraryStageClearEvent += new LibraryStage.LibraryStageClear(RoomClearCheck);
        }
        //강당 클릭시 생성
        void AuditoriumOpen()
        {
            auditorium = new auditorium.auditorium_MDI();
            auditorium.Show();
            auditorium.Location = prologueMDI.DesktopLocation;
            auditorium.AuditoriumClearEvent += new auditorium_MDI.AuditoriumClear(RoomClearCheck);
            auditorium.FormClosed += new FormClosedEventHandler(contextFormClosing);
            
            auditorium.AuditoriumClearEvent += new auditorium_MDI.AuditoriumClear(s => {contextform.ScriptParse("Audiend", "Audi"); });
            contextform = new ContextForm();
            contextform.StartCommentEvent += new ContextForm.StartComment(() => { auditorium.Enabled = false;contextform.Visible = true; });
            contextform.EndCommentEvent += new ContextForm.EndComment(() => { auditorium.Enabled = true;contextform.Visible = false; });
            contextform.Location = new Point(auditorium.DesktopLocation.X, auditorium.DesktopLocation.Y + 600);
            contextform.ScriptParse("AudiStart", "Audi");
            contextform.Show();
        }
        //모든 스테이지가 클리어 되었는지 확인시켜주는 메소드
        bool AllClearCheck() {
            if (stageClearCheck[0] && stageClearCheck[1] && stageClearCheck[2] && stageClearCheck[3])
                return true;
            else
                return false;
        }
        //모든 form을 바로 종료시키기 위한 버튼 이벤트 핸들러
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

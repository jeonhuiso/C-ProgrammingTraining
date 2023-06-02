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
        auditorium_MDI auditorium;
        science sciencRoom;
        PrologueMDI prologueMDI;
        LibraryStage libraryStage;
        Comp_Room CompRoom;
        EndingMDI endingMDI;
        ContextForm contextform;
        string[] stageMain = new string[4] { "library", "auditorium", "science", "computer" };
        bool[] stageClearCheck = new bool[4] { false, false, false, false };  
        private void MDIparent_Load(object sender, EventArgs e)
        {
            prologueMDI = new PrologueMDI();
            prologueMDI.Show();
            prologueMDI.LibraryStageOpenEvent += new PrologueMDI.LibraryStageOpen(libraryStageOpen);
            prologueMDI.AuditoriumStageOpenEvent += new PrologueMDI.AuditoriumStageOpen(AuditoriumOpen);
            prologueMDI.ScienceStageOpenEvent += new PrologueMDI.ScienceStageOpen(ScienceOpen);
               prologueMDI.ComputerStageOpenEvent += new PrologueMDI.ComputerStageOpen(CompOpen);

        }
        private void RoomClearCheck(string n) {
            for (int i = 0; i < 4; i++) {
                if (n == stageMain[i])
                {
                    stageClearCheck[i] = true;
                    
                   // MessageBox.Show(stageMain[i] + "clear");
                }
                if (stageMain[i] == "library" && stageClearCheck[i])
                {
                    prologueMDI.BtnEnable("library");
                }else
                if (stageMain[i] == "auditorium" && stageClearCheck[i])
                {
                    prologueMDI.BtnEnable("auditorium");
                }else
                if (stageMain[i] == "science" && stageClearCheck[i])
                {
                    prologueMDI.BtnEnable("science");
                }else
                if (stageMain[i] == "computer" && stageClearCheck[i])
                {
                    prologueMDI.BtnEnable("computer");
                }
            }

            if (AllClearCheck()) {
                prologueMDI.Dispose();
                endingMDI = new EndingMDI();
                endingMDI.Show();
            }
           // MessageBox.Show("clear :"+ stageClearCheck[0].ToString()+ stageClearCheck[1].ToString()+stageClearCheck[2].ToString()+stageClearCheck[3].ToString());

        }
        void contextFormClosing(object sender, FormClosedEventArgs e) {
            contextform.Dispose();
        }
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
            contextform.Location = new Point(CompRoom.DesktopLocation.X, CompRoom.DesktopLocation.Y + 550);
            contextform.StartCommentEvent += new ContextForm.StartComment(() => CompRoom.Enabled = false);
            contextform.EndCommentEvent += new ContextForm.EndComment(() => CompRoom.Enabled = true);
            contextform.Show();
            contextform.ScriptParse("CompRoomStart","CompRoom");
            
        }
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
        void libraryStageOpen()
        {
            libraryStage = new LibraryStage();
            libraryStage.Show();
            libraryStage.libraryStageClearEvent += new LibraryStage.LibraryStageClear(RoomClearCheck);
        }
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
            contextform.Location = new Point(auditorium.DesktopLocation.X, auditorium.DesktopLocation.Y + 550);
            contextform.ScriptParse("AudiStart", "Audi");
            contextform.Show();
        }

        bool AllClearCheck() {
            if (stageClearCheck[0] && stageClearCheck[1] && stageClearCheck[2] && stageClearCheck[3])
                return true;
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}

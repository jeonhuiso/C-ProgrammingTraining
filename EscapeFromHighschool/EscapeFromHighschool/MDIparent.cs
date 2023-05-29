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
            }
            if (AllClearCheck()) {
                prologueMDI.Dispose();
                endingMDI = new EndingMDI();
                endingMDI.Show();
            }
            MessageBox.Show("clear :"+ stageClearCheck[0].ToString()+ stageClearCheck[1].ToString()+stageClearCheck[2].ToString()+stageClearCheck[3].ToString());

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
            CompRoom.FormClosed += new FormClosedEventHandler(contextFormClosing);
            contextform = new ContextForm();
            contextform.Location = new Point(CompRoom.DesktopLocation.X, CompRoom.DesktopLocation.Y + 550);
            contextform.Show();
        }
        void ScienceOpen()
        {
            sciencRoom = new science();
            sciencRoom.Show();
            sciencRoom.Location = prologueMDI.DesktopLocation;
            sciencRoom.scienceRoomclearEvent += new science.scienceRoomClear(RoomClearCheck);
            sciencRoom.FormClosed += new FormClosedEventHandler(contextFormClosing);
            contextform = new ContextForm();
            contextform.Location = new Point(sciencRoom.DesktopLocation.X, sciencRoom.DesktopLocation.Y + 550);
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
            contextform = new ContextForm();
            contextform.Location = new Point(auditorium.DesktopLocation.X, auditorium.DesktopLocation.Y + 550);
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

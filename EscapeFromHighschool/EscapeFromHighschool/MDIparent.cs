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
                    MessageBox.Show(stageMain[i] + "clear");
                }
            }
            if (AllClearCheck()) {
                prologueMDI.Dispose();
                endingMDI = new EndingMDI();
                endingMDI.Show();
            }

        }
        void CompOpen()
        {
            CompRoom =new Comp_Room();
            CompRoom.Show();
            CompRoom.ComClearEvent += new Comp_Room.CompClear(RoomClearCheck);
        }
        void ScienceOpen()
        {
            sciencRoom = new science();
            sciencRoom.Show();
            sciencRoom.scienceRoomclearEvent += new science.scienceRoomClear(RoomClearCheck);
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
            auditorium.AuditoriumClearEvent += new auditorium_MDI.AuditoriumClear(RoomClearCheck);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeFromHighschool
{
    public partial class MDIparent : Form
    {

        
        public MDIparent()
        {
            InitializeComponent();
        }
        PrologueMDI prologueMDI;
        LibraryStage libraryStage;
        EndingMDI endingMDI;
        string[] stageMain = new string[4] { "library", "auditorium", "science", "computer" };
        bool[] stageClearCheck = new bool[4] { false, true, true, true };  
        private void MDIparent_Load(object sender, EventArgs e)
        {
            prologueMDI = new PrologueMDI();
            prologueMDI.Show();
            prologueMDI.LibraryStageOpenEvent += new PrologueMDI.LibraryStageOpen(libraryStageOpen);
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
        void libraryStageOpen()
        {
            libraryStage = new LibraryStage();
            libraryStage.Show();
            libraryStage.libraryStageClearEvent += new LibraryStage.LibraryStageClear(RoomClearCheck);
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

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
        public delegate void LibraryStageOpen();
        public event LibraryStageOpen LibraryStageOpenEvent;
       
        public PrologueMDI()
        {
            InitializeComponent();
        }
        StreamReader sr;
        const string address = "..\\..\\..\\..\\Image\\";
        ContextForm contextForm;
        int page = 0;
        void StartCommentMain() {
            contextForm.Enabled = true;
        }
        void MainMenuLoad() {

        }
        void EndCommentMain()
        {
            switch (++page) {
                case 1:
                    contextForm.ScriptParse("prologue2", "prologue");
                    break;
                case 2:
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartMain.Visible = false;
            contextForm.ScriptParse("prologue1", "prologue");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            LibraryStageOpenEvent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

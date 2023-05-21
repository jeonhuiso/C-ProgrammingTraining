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
        bool[] stageClearCheck = new bool[4] { false, false, false, false };  
        private void MDIparent_Load(object sender, EventArgs e)
        {
            prologueMDI = new PrologueMDI();
            prologueMDI.Show();
            prologueMDI.LibraryStageOpenEvent += new PrologueMDI.LibraryStageOpen(libraryStageOpen);
        }
        void libraryStageOpen()
        {
            libraryStage = new LibraryStage();
            libraryStage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

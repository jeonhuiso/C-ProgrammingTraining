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
    public partial class EndingMDI : Form
    {
        public EndingMDI()
        {
            InitializeComponent();
        }
        EndingMain endingMain;
        ContextForm contextForm;

        public void commentStart() {
            endingMain.Enabled = false; 
            contextForm.Enabled = true;
        }
        public void CommentEnd() {
            endingMain.Enabled = true;
        }
        private void EndingMDI_Load(object sender, EventArgs e)
        {
            endingMain = new EndingMain();
            endingMain.MdiParent = this;
            endingMain.Location = new Point(0, 0);
            endingMain.Show();
            contextForm = new ContextForm();
            contextForm.MdiParent = this;
            contextForm.Show();
            contextForm.Location = new Point(0, 595);
            contextForm.StartCommentEvent += new ContextForm.StartComment(commentStart);
            contextForm.EndCommentEvent += new ContextForm.EndComment(CommentEnd);
            contextForm.ScriptParse("EndingStart", "ending");
        }
    }
}

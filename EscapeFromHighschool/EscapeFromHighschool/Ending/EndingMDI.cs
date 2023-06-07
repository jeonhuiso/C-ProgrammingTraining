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
        //대사 시작시 실행되는 이벤트 핸들러
        public void commentStart() {
            endingMain.Enabled = false; 
            contextForm.Enabled = true;
        }
        //대사 종료시 실행되는 이벤트 핸들러
        public void CommentEnd() {
            endingMain.Enabled = true;
        }
        //노말엔딩 실행 이벤트핸들러 추가 메서드
        public void NornalEnding() {
            contextForm.EndCommentEvent += new ContextForm.EndComment(() => { endingMain.EndingButtonShow(); });
            contextForm.ScriptParse("NormalEnding", "ending");

        }
        //히든엔딩 실행 이벤트핸들러 추가 메서드
        public void HiddenEnding() {
            contextForm.EndCommentEvent += new ContextForm.EndComment(() => { endingMain.EndingButtonShow(); });
            contextForm.ScriptParse("HiddenEnding", "ending");

        }
        private void EndingMDI_Load(object sender, EventArgs e)
        {
            endingMain = new EndingMain();
            endingMain.MdiParent = this;
            endingMain.Location = new Point(0, 0);
            endingMain.Show();
            endingMain.HiddenEndingEvent += new EndingMain.HiddenEnding(HiddenEnding);
            endingMain.NormalEndingEvent += new EndingMain.NormalEnding(NornalEnding);
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

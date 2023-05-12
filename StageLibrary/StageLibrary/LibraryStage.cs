using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
namespace StageLibrary
{
    public partial class MDIContainer : Form
    {
       
        public MDIContainer()
        {
            InitializeComponent();

        }

        ContextForm contextform;
        Level1 level1;
        StageMain stageMain;
        bool[] levelClear;
        static bool[] problemsolve = new bool[3] { false, false, false };

         void CheckProblem1Solve(bool isClear)
        {
            if (isClear)
            {
                problemsolve[0] = true;
                foreach (Control c in stageMain.Controls) {
                    if(c.Name is "btnLevel1")
                    {
                        c.Enabled = false;
                        c.Text = "완료";
                    }
                }
            }
            else {
                
            }
        }
        void CommentStart() {
            this.stageMain.Enabled = false;
        }
        void CommentEnd()
        {
            this.stageMain.Enabled = true;
        }
        void Level1Show() {
            level1.Visible = true;
            level1.Location = new System.Drawing.Point(0, 0);
        }
        private void MDIContainer_Load(object sender, EventArgs e)
        {
            //메인화면
            stageMain = new StageMain();
            stageMain.MdiParent = this;
            stageMain.Text = "";
            stageMain.Show();
            stageMain.Location = new System.Drawing.Point(0, 0);
            stageMain.Level1ShowEvent += new StageMain.Level1Show(Level1Show);
            levelClear = new bool[5] {false,false,false,false,false };
            // 퀴즈1
            level1 = new Level1();
            level1.MdiParent = this;
            level1.Text = "도서관";
            level1.Show();
            level1.Visible= false;
            level1.Location = new System.Drawing.Point(0, 0);
            level1.SendStage1Event += new Level1.SendStage1Clear(CheckProblem1Solve);
           
            //대화창
            contextform = new ContextForm();
            contextform.MdiParent = this;
            contextform.Text = "대화창";
            contextform.Show();
            contextform.Location = new System.Drawing.Point(0, 590);
            contextform.StartCommentEvent += new ContextForm.StartComment(CommentStart);
            contextform.EndCommentEvent += new ContextForm.EndComment(CommentEnd);
            contextform.ScriptParse("script", "prologue");
        }
    }
}

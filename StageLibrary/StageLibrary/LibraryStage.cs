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
    public partial class LibraryStage : Form
    {
       
        public LibraryStage()
        {
            InitializeComponent();

        }

        ContextForm contextform;
        Level1 level1;
        Level2 level2;
        StageMain stageMain;
        bool[] levelClear;
        static bool[] problemsolve = new bool[3] { false, false,false };

        void StageLibraryClear() {
            this.Close();
        }
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
                        levelClear[0] = true;
                        contextform.ScriptParse("stageLibrary_level1_end", "end");
                    }
                }
            }
            else {
                
            }
        }
        void CheckProblem2Solve(bool isClear)
        {
            if (isClear)
            {
                problemsolve[1] = true;
                foreach (Control c in stageMain.Controls)
                {
                    if (c.Name is "btnLevel2")
                    {
                        c.Enabled = false;
                        c.Text = "완료";
                        levelClear[1] = true;
                        contextform.ScriptParse("stageLibrary_level2_end", "end");
                    }
                }
            }
            else
            {

            }
        }
        void ShowLevel2StartComment() {
            contextform.ScriptParse("stageLibrary_level2_start", "start");
        }
        void ShowLevel1StartComment() {
            contextform.ScriptParse("stageLibrary_level1_start", "start");
        }
        void CommentStart() {
           // this.stageMain.Enabled = false;
            foreach(Form a in this.MdiChildren)
            {
                if (a == contextform)
                    continue;
                a.Enabled = false;
            }
        }
        void CommentEnd()
        {
            //this.stageMain.Enabled = true;
            foreach (Form a in this.MdiChildren)
            {
                a.Enabled = true;
            }
            if (problemsolve[0] && problemsolve[1])
            {
                if (problemsolve[2])
                    StageLibraryClear();
                else
                {
                    problemsolve[2] = true;
                    contextform.ScriptParse("stage2_out", "stage2");
                }
            }

        }
        void Level1Show() {
            level1 = new Level1();
            level1.MdiParent = this;
            level1.SendStage1Event += new Level1.SendStage1Clear(CheckProblem1Solve);
            level1.Level1LoadEvent += new Level1.Level1Load(ShowLevel1StartComment);
            level1.Text = "도서관";
            level1.Show();
            level1.Location = new System.Drawing.Point(0, 0);
        }
        void Level2Show() {
            level2 = new Level2();
            level2.sendStage2Event += new Level2.sendStage2Clear(CheckProblem2Solve);
            level2.level2LoadEvent += new Level2.Level2Load(ShowLevel2StartComment);
            level2.MdiParent = this;
            level2.Text = "";
            level2.Show();
            level2.Location = new System.Drawing.Point(0, 0);
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
            stageMain.Level2ShowEvent += new StageMain.Level2Show(Level2Show);
            levelClear = new bool[2] {false,false };
            //대화창
            contextform = new ContextForm();
            contextform.MdiParent = this;
            contextform.Text = "대화창";
            contextform.Show();
            contextform.Location = new System.Drawing.Point(0, 590);
            contextform.StartCommentEvent += new ContextForm.StartComment(CommentStart);
            contextform.EndCommentEvent += new ContextForm.EndComment(CommentEnd);
            contextform.ScriptParse("stage2_enter", "stage2");
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //메인화면
            stageMain = new StageMain();
            stageMain.MdiParent = this;
            stageMain.Text = "";
            stageMain.Show();
            stageMain.Location = new System.Drawing.Point(0, 0);
            stageMain.Level1ShowEvent += new StageMain.Level1Show(Level1Show);
            stageMain.Level2ShowEvent += new StageMain.Level2Show(Level2Show);
            levelClear = new bool[2] { false, false };
            //대화창
            contextform = new ContextForm();
            contextform.MdiParent = this;
            contextform.Text = "대화창";
            contextform.Show();
            contextform.Location = new System.Drawing.Point(0, 590);
            contextform.StartCommentEvent += new ContextForm.StartComment(CommentStart);
            contextform.EndCommentEvent += new ContextForm.EndComment(CommentEnd);
            contextform.ScriptParse("stage2_enter", "stage2");
            ((Button)sender).Location = Point.Empty;
            ((Button)sender).Size = Size.Empty;
        }
    }
}

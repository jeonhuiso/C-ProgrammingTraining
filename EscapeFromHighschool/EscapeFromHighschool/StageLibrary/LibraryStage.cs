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
namespace EscapeFromHighschool
{
    public partial class LibraryStage : Form
    {
       
        public LibraryStage()
        {
            InitializeComponent();

        }
        public delegate void LibraryStageClear(string n);
        public event LibraryStageClear libraryStageClearEvent;
        ContextForm contextform;
        Level1 level1;
        Level2 level2;
        StageMain stageMain;
        bool[] levelClear;
        static bool[] problemsolve = new bool[3] { false, false,false };
        //도서관 스테이지 클리어시 실행되는 이벤트핸들러
        void StageLibraryClear() {
            libraryStageClearEvent("library");
            stageMain.Dispose();
            this.Dispose();
        }
        //1번째 문제 클리어시 실행되는 이벤트 핸들러
         void CheckProblem1Solve(bool isClear)
        {
            level1.Dispose();
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
                MainReload();
            }
        }
        //2번째 문제 클리어시 실행되는 이벤트 핸들러
        void CheckProblem2Solve(bool isClear)
        {
            level2.Dispose();
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
                MainReload();
            }
        }
        //문제 시작 시 대사 출력
        void ShowLevel2StartComment() {
            contextform.ScriptParse("stageLibrary_level2_start", "start");
        }
        void ShowLevel1StartComment() {
            contextform.ScriptParse("stageLibrary_level1_start", "start");
        }
        //대사 출력시 이벤트
        void CommentStart() {
            foreach(Form a in this.MdiChildren)
            {
                if (a == contextform)
                    continue;
                a.Enabled = false;
            }
        }
        //모든 대사 출력 후 이벤트
        //문제 풀이 확인 후 풀었으면 종료대사 출력 후 종료
        void CommentEnd()
        {
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
        //level1 실행
        void Level1Show() {
            level1 = new Level1();
            level1.MdiParent = this;
            level1.SendStage1Event += new Level1.SendStage1Clear(CheckProblem1Solve);
            level1.Level1LoadEvent += new Level1.Level1Load(ShowLevel1StartComment);
            level1.Text = "도서관";
            level1.Show();
            level1.Location = new System.Drawing.Point(0, 0);
        }
        //level2 실행
        void Level2Show() {
            level2 = new Level2();
            level2.sendStage2Event += new Level2.sendStage2Clear(CheckProblem2Solve);
            level2.level2LoadEvent += new Level2.Level2Load(ShowLevel2StartComment);
            level2.MdiParent = this;
            level2.Text = "";
            level2.Show();
            level2.Location = new System.Drawing.Point(0, 0);
        }
        //도서관 스테이지 메인화면 다시 리로드하는 메서드
        private void MainReload() {
            stageMain.Dispose();
            contextform.Dispose();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainReload();
        }
    }
}

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
        bool[] levelClear;
        
        private void MDIContainer_Load(object sender, EventArgs e)
        {
            levelClear = new bool[5] {false,false,false,false,false };

            contextform = new ContextForm();
            contextform.MdiParent = this;
            contextform.Text = "대화창";
            contextform.Show();
            // contextform.Dock = DockStyle.Bottom;
            contextform.Location = new System.Drawing.Point(0, 470);
            level1 = new Level1();
            level1.MdiParent = this;
            level1.Text = "도서관";
            level1.Show();
            //level1.Dock = DockStyle.Top;
            level1.Location = new System.Drawing.Point(0, 0);
            
            contextform.ScriptParse("script", "prologue");
        }
    }
}

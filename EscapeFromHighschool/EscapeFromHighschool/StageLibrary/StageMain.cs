using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
namespace EscapeFromHighschool
{
    public partial class StageMain : Form
    {
        public StageMain()
        {
            InitializeComponent();
        }
        //level1 생성시 실행되는 이벤트
        public delegate void Level1Show();
        public event Level1Show Level1ShowEvent;
        //level2 생성시 실행되는 이벤트
        public delegate void Level2Show();
        public event Level2Show Level2ShowEvent;

       // public delegate void contextShow(string filename, string obj);
       // public event contextShow contextShowEvent;
       
        //level1 생성
        private void button1_Click(object sender, EventArgs e)
        {
            Level1ShowEvent();
        }
        //level2생성
        private void button2_Click(object sender, EventArgs e)
        {
            Level2ShowEvent();
        }


    }
}

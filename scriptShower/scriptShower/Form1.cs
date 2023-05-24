using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace scriptShower
{
    // 출력하고 싶은 json파일을 변경하고자 한다면
    //ScriptParse(json파일의 이름,json파일의 토큰)
    public partial class ContextForm : Form
    {
        JObject job;
        JToken jtkn;
        List<string> SpeakerList = new List<string>();
        List<string> CommentList = new List<string>();
        List<string> ImageList = new List<string>();
        public delegate void EndComment();
        public event EndComment EndCommentEvent;
        public delegate void StartComment();
        public event StartComment StartCommentEvent;
        int i;
        string ImageLink;
        public ContextForm()
        {
            InitializeComponent();
        }

        private void ContextForm_Load(object sender, EventArgs e)
        {
            i = 0;
            ScriptParse("script", "prologue");
        }

        public void ScriptParse(string jsonName,string token) {
            try
            {
                string jsonData = File.ReadAllText(Path.GetFullPath(@"..\..\..\..\scriptList") + "\\" + jsonName + ".json");
                ImageLink= Path.GetFullPath(@"..\..\..\..\Image");
                job = JObject.Parse(@jsonData);
                jtkn = job[token];
            foreach (JToken data in jtkn) {
                SpeakerList.Add((string)data["Speaker"]);
                CommentList.Add((string)data["Comment"]);
                ImageList.Add((string)data["Image"]);
            }
                if (SpeakerList.Count() != 0) {
                    txtComment.Text = CommentList[0];
                    txtSpeaker.Text = SpeakerList[0];
                    string link = ImageLink +"\\"+ ImageList[0] + ".png";
                    CharactoPicture.Image = Image.FromFile(@link);
                    i = 1;
                }
                StartCommentEvent();
            }
            catch (Exception e) {
                MessageBox.Show("대사파일 읽기 실패!!!"+e);
            }
            
        }
        public void ShowComment(KeyEventArgs e) {
            if (e.KeyCode == Keys.Space|| e.KeyCode == Keys.Enter)
            {
                if (i < SpeakerList.Count())
                {

                    txtSpeaker.Text = SpeakerList[i];
                    txtComment.Text = CommentList[i];
                    string link = ImageLink +"\\"+ ImageList[i] + ".png";
                    CharactoPicture.Image = Image.FromFile(@link);
                    i++;
                }
                else
                {
                    txtSpeaker.Text = "";
                    txtComment.Text = "";
                    CharactoPicture.Image = null;
                    EndCommentEvent();
                    SpeakerList.Clear();
                    CommentList.Clear();
                    ImageList.Clear();

                }
            }
        }

        private void txtScript_KeyDown(object sender, KeyEventArgs e)
        {
            ShowComment(e);

        }
    }
}

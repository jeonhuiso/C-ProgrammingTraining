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

namespace auditorium
{
    public partial class Context : Form
    {
        JObject job;
        JToken jtkn;
        List<string> SpeakerList = new List<string>();
        List<string> CommentList = new List<string>();
        List<string> ImageList = new List<string>();

        string ImageLink;


        public Context()
        {
            InitializeComponent();
        }

        public void print() // 여기부분은 조금 변형해서 사용했습니다.
        {
            txtSpeaker.Text = SpeakerList[0];
            txtComment.Text = CommentList[0];
            string link = ImageLink + "\\" + ImageList[0] + ".png";
            CharactoPicture.Image = Image.FromFile(@link);
            SpeakerList.Clear();
            CommentList.Clear();
            ImageList.Clear();
        }

        public void ScriptParse(string jsonName, string token) // 여기부분은 전휘소 조원의 코드를 재사용
        {
            try
            {
                string jsonData = File.ReadAllText(Path.GetFullPath(@"..\..\..\scriptList") + "\\" + jsonName + ".json");
                ImageLink = Path.GetFullPath(@"..\..\..\Image");

                job = JObject.Parse(@jsonData);
                jtkn = job[token];
                foreach (JToken data in jtkn)
                {
                    SpeakerList.Add((string)data["Speaker"]);
                    CommentList.Add((string)data["Comment"]);
                    ImageList.Add((string)data["Image"]);
                }
                if (SpeakerList.Count() != 0)
                {
                    txtComment.Text = CommentList[0];
                    txtSpeaker.Text = SpeakerList[0];
                    string link = ImageLink + "\\" + ImageList[0] + ".png";
                    CharactoPicture.Image = Image.FromFile(@link);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("대사파일 읽기 실패!!!" + e);
            }

        }
    }
}

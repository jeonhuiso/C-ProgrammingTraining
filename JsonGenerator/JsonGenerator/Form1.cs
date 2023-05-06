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
namespace JsonGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            send();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                send();
            }
        }
        private void KeyDownCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObject.Focus();
            }
        }
        private void KeyDownCheck2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSpeaker.Focus();
            }
        }
        private void KeyDownCheck3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComment.Focus();
            }
        }
        private void send() {
            string completeText = "";
            if (txtScript.Text.Length == 0)
            {
                completeText = "{\"Speaker\":" + "\"" + txtSpeaker.Text + "\"," + "\"Comment\":" + "\"" + txtComment.Text + "\"}\n";
            }
            else {
                completeText = ",{\"Speaker\":" + "\"" + txtSpeaker.Text + "\"," + "\"Comment\":" + "\"" + txtComment.Text + "\"}";
            }

            txtScript.Text = txtScript.Text + completeText;
        }

        private void txtJson_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMakeJson_Click(object sender, EventArgs e)
        {
            if (txtJson.Text == "" || txtObject.Text == "" || txtScript.Text == "") {
                MessageBox.Show("오류 발생: json이름이나 객체이름, 대사 중 하나라도 비어있습니다!");
            }
            else {
                string JsonDirectory = Path.GetFullPath(@"..\..\..\..\scriptList") + "\\" + txtJson.Text + ".json";
                MessageBox.Show(JsonDirectory);
                string result = "{\"" + txtObject.Text + "\":[" + txtScript.Text + "]}";
                MessageBox.Show("파일 저장 주소: "+JsonDirectory);
                try
                {
                    StreamWriter sw;
                    if (File.Exists(JsonDirectory))
                    {
                        File.Delete(JsonDirectory);
                        sw = new StreamWriter(JsonDirectory, false);
                        sw.Write(result);
                        sw.Flush();
                        sw.Close();
                        
                    }
                    else if (!File.Exists(JsonDirectory))
                    {

                        sw = new StreamWriter(JsonDirectory, false);
                        sw.Write(result);
                        sw.Flush();
                        sw.Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("오류발생: json파일 저장 중 오류 발생 (" + ex + ")");
                }
                finally { 
                    
                }
                
            }
        }
    }
}

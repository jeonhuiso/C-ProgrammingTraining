using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ComputerRoom
{
    public partial class windows_bg : Form
    {
        public windows_bg()
        {
            InitializeComponent();
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..\\..");
            ofd.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void boxFolder_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.SafeFileName == "noname")
                {
                    FileOpen fo = new FileOpen();
                    fo.Owner = this;
                    fo.Show();
                }
                else
                {
                    MessageBox.Show("�ƹ��ϵ� �Ͼ�� �ʾҴ�!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void boxQuiz_Click(object sender, EventArgs e)
        {
            quiz qz = new quiz();
            qz.Owner = this;
            qz.Show();
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            //mail ml = new mail();
            //ml.Owner = this;
            //ml.Show();
            MailLogin mailLogin = new MailLogin();
            mailLogin.Owner = this;
            mailLogin.Show();
        }

        private void boxStartMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("�����Ͻðڽ��ϱ�?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
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
            Mail ml = new Mail();
            ml.Owner = this;
            ml.Show();
        }
    }
}
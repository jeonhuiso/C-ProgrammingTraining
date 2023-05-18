namespace _5_18_2
{
    public partial class Form1 : Form
    {
        int num_log = 1;
        Thread thread;
        public delegate void MethodInvoker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thread = new Thread(new ThreadStart(LabelPlus));
            //thread.Start();
            thread = new Thread(() =>
            {
                while (num_log < 1000)
                {
                    lblLog.Invoke((MethodInvoker)(() =>
                    {
                        lblLog.Text = (++num_log).ToString();
                    }));
                }
            });
            thread.Start();
        }

        public delegate void DelegatePlus();
        private void LabelPlus()
        {
            while (num_log < 1000)
            {
                lblLog.Invoke((MethodInvoker)(delegate () { lblLog.Text = (++num_log).ToString(); }), new object[] { });
            }
        }

        //public void lblLogPlus()
        //{
        //    lblLog.Text = (++num_log).ToString();
        //}
    }
}
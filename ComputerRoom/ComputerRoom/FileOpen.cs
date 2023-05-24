using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRoom
{
    public partial class FileOpen : Form
    {
        public FileOpen()
        {
            InitializeComponent();
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                this.Invoke(new Action(() =>
                {
                    var result = MessageBox.Show("으악! 홍진호다!\n으악! 홍진호다!", "KONG! KONG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        var res = MessageBox.Show("XX2X", "SOMETHING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (res == DialogResult.OK)
                        {
                            Close();
                        }
                        Close();
                    }
                }));
            });
        }
    }
}

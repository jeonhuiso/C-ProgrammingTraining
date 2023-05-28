using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week10_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet1 dataset;
        private void Form1_Load(object sender, EventArgs e)
        {
           dataset  = new DataSet1();
            dataset.Tables["Person"].Rows.Add(new object[] { 1, "Kim", 30 });
            dataset.Tables["Person"].Rows.Add(new object[] { 2, "Kong", 30 });
            dataset.Tables["Person"].Rows.Add(new object[] { 3, "Pack", 30 });
            dataset.Tables["Person"].Rows.Add(new object[] { 4, "Lee", 30 });

            dataGridView1.DataSource = dataset.Tables["Person"];

        }
        private void button_add_Click(object sender, EventArgs e)
        {
            dataset.Tables["Person"].Rows.Add(new object[]{
                dataset.Tables["Person"].Rows.Count+1,textBox_name.Text,Convert.ToInt32(textBox_age.Text)


            });
        }
    }
}

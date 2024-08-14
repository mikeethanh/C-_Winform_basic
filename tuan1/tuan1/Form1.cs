using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan1
{
    public partial class giaiphuongtrinh : Form
    {
        public giaiphuongtrinh()
        {
            InitializeComponent();
        }
        ptb2 pt;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngpt_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a =double.Parse(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            bool k;
            k = double.TryParse(txtc.Text, out c);
            if (k)
            {
                pt = new ptb2(a, b, c);
                var kq = pt.giaipt();
                txtkq.Text = kq;
                txtkq.ForeColor = Color.Red;
            }
            
        }
    }
}

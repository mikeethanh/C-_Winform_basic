using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan1_btvn
{
    public partial class Form1 : Form
    {
        private dayso ds;
        public Form1()
        {
            InitializeComponent();
            ds = new dayso();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.NhapDaySo(txt_input.Text);

            ds.SapXepDaySo();

            txt_output.Text = ds.InDaySo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            txt_input.Text = "";
            txt_output.Text = "";

            ds = new dayso();
        }
    }
}

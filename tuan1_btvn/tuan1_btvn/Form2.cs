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
    public partial class Form2 : Form
    {
        phanso ps1;
        phanso ps2;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_tich_Click(object sender, EventArgs e)
        {
            ps1 = new phanso(int.Parse(txt_ts_1.Text), int.Parse(txt_ms_1.Text));
            ps2 = new phanso(int.Parse(txt_ts_2.Text), int.Parse(txt_ms_2.Text));
            phanso tich = ps1.nhan(ps1, ps2);
            txt_out_tich.Text = tich.ToString();
        }

        private void txt_ts_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tong_Click(object sender, EventArgs e)
        {

        }

        private void btn_hieu_Click(object sender, EventArgs e)
        {

        }

        private void btn_thuong_Click(object sender, EventArgs e)
        {

        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {

        }
    }
}

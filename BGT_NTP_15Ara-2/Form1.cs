using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_NTP_15Ara_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<harcama> harcamalar = new List<harcama>();
        private void button1_Click(object sender, EventArgs e)
        {
            harcama _harcama1 = new harcama();
            _harcama1.IslemAdi = textBox1.Text;
            _harcama1.IslemTuru = textBox2.Text;    
            _harcama1.Tutar=Convert.ToInt32(textBox3.Text);
            harcamalar.Add(_harcama1);
            label6.Text = harcamalar.Count.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tutar = 0;
            for (int i = 0; i < harcamalar.Count; i++)
            {
                listBox1.Items.Add(harcamalar[i].IslemAdi + "  " + harcamalar[i].Tutar);
                tutar += harcamalar[i].Tutar;
            }
            label7.Text = tutar.ToString();
        }
    }
}

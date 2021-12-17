using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oppFormApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = textBox1.Text;
            o.Soyad = textBox2.Text;
            o.Tc = Convert.ToInt64(textBox3.Text);
            ListViewItem kayit = new ListViewItem();
            kayit.Text = o.Tc.ToString();
            kayit.SubItems.Add(o.Ad);
            kayit.SubItems.Add(o.Soyad);
            listView1.Items.Add(kayit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}

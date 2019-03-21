using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstOgrenciSinif
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

        private void sınıflarınTanımlanmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinif frm = new FormSinif();
            frm.Show();
        }

        private void ögrencilerinTanımlanmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenci frm2 = new FormOgrenci();
            frm2.Show();
        }
    }
}

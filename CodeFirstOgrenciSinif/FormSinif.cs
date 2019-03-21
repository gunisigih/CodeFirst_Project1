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
    public partial class FormSinif : Form
    {
        public FormSinif()
        {
            InitializeComponent();
        }

        OgrenciSinif db = new OgrenciSinif();
        private void Doldur()
        {
            dataGridView1.DataSource = db.Siniflar.Select(x => new
            {
                x.SinifID,
                x.Aciklama
            }).ToList();
        }
             
        private void FormSinif_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sinif snf = new Sinif();
            snf.Aciklama = textBox1.Text;
            db.Siniflar.Add(snf);
            db.SaveChanges();
            Doldur();
        }
    }
}

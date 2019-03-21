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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }

        OgrenciSinif db = new OgrenciSinif();
        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            Doldur();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = db.Ogrenciler.Select(x => new
            {
                x.SinifID,
                x.AdSoyad,
                x.sinif.Aciklama
            }).ToList();
        }

        private void cmbDoldur()
        {
           var combo = db.Siniflar.Select(x => new
           {
                   x.SinifID,
                   x.Aciklama

                }).ToList();
            comboBox1.DisplayMember = "Aciklama";
            comboBox1.ValueMember = "SinifID";

            comboBox1.DataSource = combo;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.AdSoyad = textBox1.Text;
            ogr.SinifID = (int)comboBox1.SelectedValue;
            db.Ogrenciler.Add(ogr);
            db.SaveChanges();
            Doldur();
        }
    }
}

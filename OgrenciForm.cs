using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foy5
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.tOgrenci.ToList();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbBolum.DataSource = db.tBolum.ToList();
            cmbBolum.DisplayMember = "bolumAd";
            cmbBolum.ValueMember = "bolumID";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txbOgrenciNo.Text = row.Cells["ogrenciID"].Value.ToString();
            txbAd.Text = row.Cells["ad"].Value.ToString();
            txbSoyad.Text = row.Cells["soyad"].Value.ToString();
            cmbBolum.SelectedValue = row.Cells["bolumID"].Value;
        }

        public void clearAll()
        {
            txbOgrenciNo.Clear();
            txbAd.Clear();
            txbSoyad.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            tOgrenci ogrenci = new tOgrenci();
            if (txbOgrenciNo.TextLength == 0)
            {
                ogrenci.ogrenciID = db.tOgrenci.Count() + 1;
            }
            else
            {
                ogrenci.ogrenciID = Int16.Parse(txbOgrenciNo.Text);
            }
            ogrenci.ogrenciAd = txbAd.Text;
            ogrenci.ogrenciSoyad = txbSoyad.Text;
            ogrenci.bolumID = (int)cmbBolum.SelectedValue;
            db.tOgrenci.Add(ogrenci);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_id = Int16.Parse(txbOgrenciNo.Text);
            tOgrenci guncellenecek_ogrenci = db.tOgrenci.SingleOrDefault(ogrenci => ogrenci.ogrenciID == guncellenecek_id);
            guncellenecek_ogrenci.ogrenciID = Int16.Parse(txbOgrenciNo.Text);
            guncellenecek_ogrenci.ogrenciAd = txbAd.Text;
            guncellenecek_ogrenci.ogrenciSoyad = txbSoyad.Text;
            guncellenecek_ogrenci.bolumID = (int)cmbBolum.SelectedValue;
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(txbOgrenciNo.Text);
            tOgrenci silinecek_ogrenci = db.tOgrenci.SingleOrDefault(ogrenci => ogrenci.ogrenciID == silinecek_id);
            db.tOgrenci.Remove(silinecek_ogrenci);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}

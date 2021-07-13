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
    public partial class DersForm : Form
    {
        public DersForm()
        {
            InitializeComponent();
        }

        private void DersForm_Load(object sender, EventArgs e)
        {
            VeriListele();
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.tDers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txbDersNo.Text = row.Cells["dersID"].Value.ToString();
            txbDers.Text = row.Cells["dersAd"].Value.ToString();
        }

        public void clearAll()
        {
            txbDersNo.Clear();
            txbDers.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            tDers ders = new tDers();
            if (txbDersNo.TextLength == 0)
            {
                ders.dersID = db.tDers.Count() + 1;
            }
            else
            {
                ders.dersID = Int16.Parse(txbDersNo.Text);
            }
            ders.dersAD = txbDers.Text;
            db.tDers.Add(ders);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_id = Int16.Parse(txbDersNo.Text);
            tDers guncellenecek_ders = db.tDers.SingleOrDefault(ders => ders.dersID == guncellenecek_id);
            guncellenecek_ders.dersID = Int16.Parse(txbDersNo.Text);
            guncellenecek_ders.dersAD = txbDers.Text;
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(txbDersNo.Text);
            tDers silinecek_ders = db.tDers.SingleOrDefault(ders => ders.dersID == silinecek_id);
            db.tDers.Remove(silinecek_ders);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}

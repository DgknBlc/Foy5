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
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.tOgrenciDers.ToList();
        }

        private void NotForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbDers.DataSource = db.tDers.ToList();
            cmbDers.DisplayMember = "dersAD";
            cmbDers.ValueMember = "dersID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            Id.Text = row.Cells["ogrenciDersID"].Value.ToString();
            txbOgrenciNo.Text = row.Cells["ogrenciID"].Value.ToString();
            txbYil.Text = row.Cells["yil"].Value.ToString();
            txbDonem.Text = row.Cells["yariyil"].Value.ToString();
            txbVize.Text = row.Cells["vize"].Value.ToString();
            txbFinal.Text = row.Cells["final"].Value.ToString();
            cmbDers.SelectedValue = row.Cells["dersID"].Value;
        }

        public void clearAll()
        {
            Id.Clear();
            txbOgrenciNo.Clear();
            txbYil.Clear();
            txbDonem.Clear();
            txbVize.Clear();
            txbFinal.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            tOgrenciDers ogrenciDers = new tOgrenciDers();
            if (Id.TextLength == 0)
            {
                ogrenciDers.ogrenciDersID = db.tOgrenciDers.Count() + 1;
            }
            else
            {
                ogrenciDers.ogrenciDersID = Int16.Parse(Id.Text);
            }  
            ogrenciDers.ogrenciID = Int16.Parse(txbOgrenciNo.Text);
            ogrenciDers.dersID = (int)cmbDers.SelectedValue;
            ogrenciDers.yil = txbYil.Text;
            ogrenciDers.yariyil = txbDonem.Text;
            ogrenciDers.vize = Int16.Parse(txbVize.Text);
            ogrenciDers.final = Int16.Parse(txbFinal.Text);
            db.tOgrenciDers.Add(ogrenciDers);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_Id = Int16.Parse(Id.Text);
            tOgrenciDers guncellenecek_ogrenciDers = db.tOgrenciDers.SingleOrDefault(ogrenciDers => ogrenciDers.ogrenciDersID == guncellenecek_Id);
            guncellenecek_ogrenciDers.ogrenciID = Int16.Parse(txbOgrenciNo.Text);
            guncellenecek_ogrenciDers.dersID = (int)cmbDers.SelectedValue;
            guncellenecek_ogrenciDers.yil = txbYil.Text;
            guncellenecek_ogrenciDers.yariyil = txbDonem.Text;
            guncellenecek_ogrenciDers.vize = Int16.Parse(txbVize.Text);
            guncellenecek_ogrenciDers.final = Int16.Parse(txbFinal.Text);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(Id.Text);
            tOgrenciDers silinecek_ogrenci = db.tOgrenciDers.SingleOrDefault(tOgrenciDers => tOgrenciDers.ogrenciDersID == silinecek_id);
            db.tOgrenciDers.Remove(silinecek_ogrenci);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}

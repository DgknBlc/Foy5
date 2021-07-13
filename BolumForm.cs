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
    public partial class BolumForm : Form
    {
        public BolumForm()
        {
            InitializeComponent();
        }

        private void BolumForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbFakulte.DataSource = db.tFakulte.ToList();
            cmbFakulte.DisplayMember = "fakulteAd";
            cmbFakulte.ValueMember = "fakulteID";
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.tBolum.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txbBolumNo.Text = row.Cells["bolumID"].Value.ToString();
            txbBolum.Text = row.Cells["bolumAd"].Value.ToString();
            cmbFakulte.SelectedValue = row.Cells["fakulteID"].Value;
        }

        public void clearAll()
        {
            txbBolumNo.Clear();
            txbBolum.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            tBolum bolum = new tBolum();
            if(txbBolumNo.TextLength == 0)
            {
                bolum.bolumID = db.tBolum.Count() + 1;
            }
            else
            {
                bolum.bolumID = Int16.Parse(txbBolumNo.Text);
            }
            bolum.bolumAd = txbBolum.Text;
            bolum.fakulteID = (int)cmbFakulte.SelectedValue;
            db.tBolum.Add(bolum);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_id = Int16.Parse(txbBolumNo.Text);
            tBolum guncellenecek_bolum = db.tBolum.SingleOrDefault(bolum => bolum.bolumID == guncellenecek_id);
            guncellenecek_bolum.bolumID = Int16.Parse(txbBolumNo.Text);
            guncellenecek_bolum.bolumAd = txbBolum.Text;
            guncellenecek_bolum.fakulteID = (int)cmbFakulte.SelectedValue;
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(txbBolumNo.Text);
            tBolum silinecek_bolum = db.tBolum.SingleOrDefault(bolum => bolum.bolumID == silinecek_id);
            db.tBolum.Remove(silinecek_bolum);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}

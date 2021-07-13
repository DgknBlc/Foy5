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
    public partial class FakulteForm : Form
    {
        public FakulteForm()
        {
            InitializeComponent();
        }

        private void FakulteForm_Load(object sender, EventArgs e)
        {
            VeriListele();
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.tFakulte.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txbFakulteNo.Text = row.Cells["fakulteID"].Value.ToString();
            txbFakulte.Text = row.Cells["fakulteAd"].Value.ToString();
        }

        public void clearAll()
        {
            txbFakulteNo.Clear();
            txbFakulte.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            tFakulte fakulte = new tFakulte();
            if (txbFakulteNo.TextLength == 0)
            {
                fakulte.fakulteID = db.tFakulte.Count() + 1;
            }
            else
            {
                fakulte.fakulteID = Int16.Parse(txbFakulteNo.Text);
            }
            fakulte.fakulteAd = txbFakulte.Text;
            db.tFakulte.Add(fakulte);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_id = Int16.Parse(txbFakulteNo.Text);
            tFakulte guncellenecek_fakulte = db.tFakulte.SingleOrDefault(fakulte => fakulte.fakulteID == guncellenecek_id);
            guncellenecek_fakulte.fakulteID = Int16.Parse(txbFakulteNo.Text);
            guncellenecek_fakulte.fakulteAd = txbFakulte.Text;
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(txbFakulteNo.Text);
            tFakulte silinecek_fakulte = db.tFakulte.SingleOrDefault(fakulte => fakulte.fakulteID == silinecek_id);
            db.tFakulte.Remove(silinecek_fakulte);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}

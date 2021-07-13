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
    public partial class ListeForm : Form
    {
        public ListeForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbDers.DataSource = db.tDers.ToList();
            cmbDers.DisplayMember = "dersAd";
            cmbDers.ValueMember = "dersID";
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.tOgrenciDers.ToList();
            dataGridView2.DataSource = db.tOgrenciDers.ToList();
        }

        private void button_DersBul_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int bulunacak_id = Int16.Parse(txbOgrenciNo.Text);
            dataGridView1.DataSource = db.tOgrenciDers.Where(ogrenciDers => ogrenciDers.ogrenciID == bulunacak_id).ToList();
        }

        private void button_OgrenciBul_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int bulunacak_id = (int)cmbDers.SelectedValue;
            string bulunacak_yil = txbYil.Text;
            string bulunacak_yariYil = txbYariyil.Text;
            if (txbYariyil.TextLength == 0 && txbYil.TextLength == 0)
            {
                dataGridView2.DataSource = db.tOgrenciDers.Where(ogrenciDers => ogrenciDers.dersID == bulunacak_id).ToList();
            }
            else if(txbYariyil.TextLength != 0 && txbYil.TextLength != 0)
            {
                dataGridView2.DataSource = db.tOgrenciDers.Where(ogrenciDers => (ogrenciDers.ogrenciID == bulunacak_id) && (ogrenciDers.yariyil == bulunacak_yariYil) && (ogrenciDers.yil == bulunacak_yil)).ToList();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

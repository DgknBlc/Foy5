using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Foy5
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenciForm = new OgrenciForm();
            ogrenciForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BolumForm bolumForm = new BolumForm();
            bolumForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DersForm dersForm = new DersForm();
            dersForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FakulteForm fakulteForm = new FakulteForm();
            fakulteForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NotForm notForm = new NotForm();
            notForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListeForm listeForm = new ListeForm();
            listeForm.ShowDialog();

        }
    }
}

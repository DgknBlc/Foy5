
namespace Foy5
{
    partial class ListeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_DersBul = new System.Windows.Forms.Button();
            this.txbOgrenciNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_OgrenciBul = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.txbYariyil = new System.Windows.Forms.TextBox();
            this.txbYil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_DersBul);
            this.panel1.Controls.Add(this.txbOgrenciNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 518);
            this.panel1.TabIndex = 0;
            // 
            // button_DersBul
            // 
            this.button_DersBul.Location = new System.Drawing.Point(384, 3);
            this.button_DersBul.Name = "button_DersBul";
            this.button_DersBul.Size = new System.Drawing.Size(90, 79);
            this.button_DersBul.TabIndex = 4;
            this.button_DersBul.Text = "Dersleri Bul";
            this.button_DersBul.UseVisualStyleBackColor = true;
            this.button_DersBul.Click += new System.EventHandler(this.button_DersBul_Click);
            // 
            // txbOgrenciNo
            // 
            this.txbOgrenciNo.Location = new System.Drawing.Point(6, 47);
            this.txbOgrenciNo.Name = "txbOgrenciNo";
            this.txbOgrenciNo.Size = new System.Drawing.Size(161, 22);
            this.txbOgrenciNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 427);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ders Sorgulama";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_OgrenciBul);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.cmbDers);
            this.panel2.Controls.Add(this.txbYariyil);
            this.panel2.Controls.Add(this.txbYil);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(505, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 518);
            this.panel2.TabIndex = 1;
            // 
            // button_OgrenciBul
            // 
            this.button_OgrenciBul.Location = new System.Drawing.Point(384, 3);
            this.button_OgrenciBul.Name = "button_OgrenciBul";
            this.button_OgrenciBul.Size = new System.Drawing.Size(90, 79);
            this.button_OgrenciBul.TabIndex = 5;
            this.button_OgrenciBul.Text = "Dersi Alanları Bul";
            this.button_OgrenciBul.UseVisualStyleBackColor = true;
            this.button_OgrenciBul.Click += new System.EventHandler(this.button_OgrenciBul_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(471, 427);
            this.dataGridView2.TabIndex = 9;
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(6, 47);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 24);
            this.cmbDers.TabIndex = 8;
            // 
            // txbYariyil
            // 
            this.txbYariyil.Location = new System.Drawing.Point(239, 47);
            this.txbYariyil.Name = "txbYariyil";
            this.txbYariyil.Size = new System.Drawing.Size(100, 22);
            this.txbYariyil.TabIndex = 7;
            // 
            // txbYil
            // 
            this.txbYil.Location = new System.Drawing.Point(133, 47);
            this.txbYil.Name = "txbYil";
            this.txbYil.Size = new System.Drawing.Size(100, 22);
            this.txbYil.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yarıyıl :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yıl :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Dönemi Sorgulama";
            // 
            // ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListeForm";
            this.Text = "ListeForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOgrenciNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.TextBox txbYariyil;
        private System.Windows.Forms.TextBox txbYil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DersBul;
        private System.Windows.Forms.Button button_OgrenciBul;
    }
}
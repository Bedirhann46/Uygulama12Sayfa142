using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama12Sayfa142
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirler.Text);
            Listele();
            txtSehirler.Clear();

        }
        

        private void btnAraEkle_Click(object sender, EventArgs e)
        {
            int indexNo = listeleSehirler.SelectedIndex;
            sehirler.Insert(indexNo, txtSehirler.Text);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = listeleSehirler.SelectedIndex;
            sehirler[indexNo] = txtSehirler.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = listeleSehirler.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            {
                if (sehirler.Contains(txtSehirler.Text))
                {
                    labelDurum.Text = "Aranan Değer Bulundu.";
                    listeleSehirler.SelectedIndex = sehirler.IndexOf(txtSehirler.Text);
                }
                else
                {
                    labelDurum.Text = "Aranan Değer Bulunamadı.";
                }
            }
        }
        private void Listele()
        {
            listeleSehirler.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listeleSehirler.Items.Add(sehir);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sehirler.Sort();
            Listele();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            sehirler.Sort();
            sehirler.Reverse();
            Listele();
        }
    }
}

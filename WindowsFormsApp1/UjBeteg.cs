using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UjBeteg : Form
    {
        Beteg b;

        internal Beteg B { get => b; set => b = value; }

        public UjBeteg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (tbNev.Text != "" && errorProvider1.GetError(tbTaj) == "")
            {
                /*Beteg b = new Beteg();
                 b.Nev = tbNev.Text;
                 b.Taj = tbTaj.Text;
                 b.SzDatum dateTime = dtpSzDatum.Value;*/
                B = new Beteg(tbNev.Text, tbTaj.Text, dtpSzDatum.Value);
                DialogResult = DialogResult.OK;



            }
            else if (errorProvider1.GetError(tbTaj) != "")
            {
                MessageBox.Show("Hibás adatok!");
            }
            else
            {
                MessageBox.Show("Hiányos adatok.");
            }

        }

        private void tbTaj_Validated(object sender, EventArgs e)
        {
            int a;
            if (tbTaj.Text.Length != 9)
            {
                errorProvider1.SetError(tbTaj, "A Taj szám 9 karaktert tartalmaz");
            }
            else if (!Int32.TryParse(tbTaj.Text, out a))
            {
                errorProvider1.SetError(tbTaj, "A TAJ szám csak számokat tartalmaz");
            }
            else
            {
                errorProvider1.SetError(tbTaj, string.Empty);
            }
        }
    }
}

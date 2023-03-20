using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class NapiAdatokForm : Form
    {
        List<Beteg> betegek = new List<Beteg>();
        public NapiAdatokForm()
        {
            InitializeComponent();
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            betegek.Clear();
            lbBetegek.Items.Clear();
            tbNev.Text = "";
            tbTaj.Text = "";
            tbSzDatum.Text = "";
            DateTime datum = dtpDatum.Value;
            Form1 f =new Form1();
            f.datumSzam(datum);
            string fajlnev = "vizsgalt_" + f.datumSzam(datum) + "txt";
            if (File.Exists(fajlnev))
            {
                StreamReader r = new StreamReader(fajlnev);
                while (!r.EndOfStream)
                {
                    string[] s = r.ReadLine().Split(';');
                    Beteg b = new Beteg(s[0], s[1], Convert.ToDateTime(s[2]));
                    betegek.Add(b);
                    lbBetegek.Items.Add(b.Nev);
                }
                r.Close();
            }
            else
            {
                MessageBox.Show("Ezen a napon nem volt rendelés!");
            }
        }

        private void lbBetegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBetegek.SelectedIndex >= 0)
            {
                int a = lbBetegek.SelectedIndex;
                tbNev.Text = betegek[a].Nev;
                tbTaj.Text = betegek[a].Taj;
                tbSzDatum.Text = betegek[a].SzDatum.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Nem választott ki beteget!");
            }
        }

        private void btnRendez_Click(object sender, EventArgs e)
        {
            lbBetegek.Items.Clear();
            for (int i = 1; i <= betegek.Count - 1; i++)
            {
                Beteg a = betegek[i];
                int j = 0;
                while (string.Compare(betegek[i].Nev, betegek[j].Nev, true) > 0 && j < i)
                {
                    j++;
                }
                for (int k = i; k > j; k--)
                {
                    betegek[k] = betegek[k - 1];
                }
                betegek[j] = a;
            }
            foreach (Beteg b in betegek)
            {
                lbBetegek.Items.Add(b.Nev);
            }

        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            int i = 0;
            string keres = tbKeres.Text;
            bool talal = false;
            while (i < betegek.Count && !talal)
            {
                if(keres == betegek[i].Taj)
                {
                    talal = true;
                }
                else
                {
                    i++;
                }

            }
            if (i < betegek.Count)
            {
                lbBetegek.SelectedIndex = i;
            }
            else
            {
                MessageBox.Show("A keresett Taj számú beteg ezen a napon nem volt vizsgálva.");
            }
        }

    }
}

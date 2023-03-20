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
    public partial class Form1 : Form
    {

        List<Beteg> varakozok = new List<Beteg>();
        List<Beteg> vizsgaltak = new List<Beteg>();
        //int vizsgalt = 0;




        public Form1()
        {
            InitializeComponent();
            Beolvas();
        }

        private void Beolvas()
        {
            DateTime datum = DateTime.Today;

            string fajlnev = "vizsgalt_" + datumSzam(datum) + "txt";
            if (File.Exists(fajlnev))
            {
                StreamReader r=new StreamReader(fajlnev);
                while(!r.EndOfStream)
                {
                    string[] s = r.ReadLine().Split(';');
                        Beteg b = new Beteg(s[0],s [1], Convert.ToDateTime(s[2]));
                    vizsgaltak.Add(b);
                }
                r.Close();
            }
        }

        public string datumSzam(DateTime datum)
        {
            string datumSzam = datum.Year.ToString();
            if (datum.Month < 10)
            {
                datumSzam += "0" +datum.Month.ToString();
            }
            else
            {
                datumSzam = datum.Month.ToString();
            }
            if (datum.Month < 10)
            {
                datumSzam += "0" + datum.Month.ToString();
            }
            else
            {
                datumSzam = datum.Month.ToString();
            }
            return datumSzam;


        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            UjBeteg uj = new UjBeteg();
             if (uj.ShowDialog () == DialogResult.OK)
            {
                varakozok.Add(uj.B);
                lbVarakozo.Items.Add(uj.B.Nev);


            }
        }

        private void btnBehiv_Click(object sender, EventArgs e)
        {
            if (lbVarakozo.SelectedIndex >= 0)
            {
                string fajlnev = "vizsgalt_" +  datumSzam(DateTime.Today) + "txt";
                StreamWriter w = new StreamWriter(fajlnev, true);
                Beteg b = varakozok[lbVarakozo.SelectedIndex];
                /*w.WriteLine(varakozok[lbVarakozo.SelectedIndex].Nev + ";" + varakozok[lbVarakozo.SelectedIndex].Taj + ";" + varakozok[lbVarakozo.SelectedIndex].SzDatum);*/
                w.WriteLine(varakozok[lbVarakozo.SelectedIndex].ToString());
                w.Close();
                vizsgaltak.Add(b);
                varakozok.RemoveAt(lbVarakozo.SelectedIndex);
                lbVarakozo.Items.RemoveAt(lbVarakozo.SelectedIndex);
                //vizsgalt++;
            }
            else
            {
                MessageBox.Show("Nem jelölt ki beteget.");
            }
        }

        private void btnBetegSzam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Várakozók száma: " + lbVarakozo.Items.Count + "\nVizsgáltak száma: " + vizsgaltak.Count);

        }

        private void btnNapi_Click(object sender, EventArgs e)
        {
            NapiAdatokForm uj = new NapiAdatokForm();
            uj.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

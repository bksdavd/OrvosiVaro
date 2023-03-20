using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Beteg
    {
        string nev, taj;
        DateTime szDatum;

        public Beteg(string nev, string taj, DateTime szDatum)
        {
            this.nev = nev;
            this.taj = taj;
            this.szDatum = szDatum;
        }

        public Beteg()
       {
        
        }
       
        public string Nev { get => nev; set => nev = value; }
        public string Taj { get => taj; set => taj = value; }
        public DateTime SzDatum { get => szDatum; set => szDatum = value; }

        public override string ToString()
        {
            return Nev + ";" + Taj + ";" + SzDatum.ToShortDateString();

        }
    }
}

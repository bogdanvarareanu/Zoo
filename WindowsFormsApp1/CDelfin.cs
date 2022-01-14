using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CDelfin:Wassertier
    {
        private int Korperlaenge;


        public CDelfin() { Korperlaenge = 10;  }

        public CDelfin(string N, int T, int KL) : base(N, T) { Korperlaenge = KL; }

        public int get_KLaenge() { return Korperlaenge; }

        public string get_DWerte()
        {
            string Text;
            Text = "Name:" + Name + "\n";
            Text += "Tauchzeit:" + tauchzeit + "\n";
            Text += "Korperlaenge:" + Korperlaenge +" m"+ "\n\n";
            return Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blibio
{
    public class Revista:Element
    {
        int numar;
        String data;

        public int Numar { get => numar; set => numar = value; }
        public string Data { get => data; set => data = value; }
        public Revista(string unTitlu, int unNrExemplare, int unNumar, string oData):base(unTitlu, unNrExemplare)
        {
            this.Numar = unNumar;
            this.Data = oData;
        }
        public override string descriere()
        {
            return base.descriere() + " " + this.Numar + " " + this.Data;
        }
    }
}

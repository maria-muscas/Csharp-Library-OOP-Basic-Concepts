using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blibio
{
    public abstract class Element
    {
        String titlu;
        int nrExemplare;

        public string Titlu { get => titlu; set => titlu = value; }
        public int NrExemplare { get => nrExemplare; set => nrExemplare = value; }

        public Element(String unTitlu, int unNrExemplare)
        {
            this.Titlu = unTitlu;
            this.NrExemplare=unNrExemplare;
        }
        public virtual String descriere()
        {
            return this.Titlu + " " + this.NrExemplare;
        }
    }
}

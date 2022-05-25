using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blibio
{
    public class Carte:Element
    {
        string autor;
        public string Autor { get => autor; set => autor = value; }
        public Carte(String unTitlu, int unNrExemplare, string unAutor):base(unTitlu,unNrExemplare)
        {
            this.Autor = unAutor;
        }
        public override string descriere()
        {
            return base.descriere() + " " + this.Autor;
        }
    }
}

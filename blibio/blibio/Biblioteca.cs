using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blibio
{
    public class Biblioteca
    {
        private static List<Element> revcar=new List<Element>();
        private static int nrElemente=0;

        public void adaugaCarte()
        {
            string titlu, autor;
            int nr;
            Console.WriteLine("Introduceti date despre carte: ");
            Console.WriteLine("Introduceti titlul: ");
            titlu = Console.ReadLine();
            Console.WriteLine("Introduceti nr de carti: ");
            nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti autorul: ");
            autor = Console.ReadLine();
            Carte cart = new Carte(titlu, nr, autor);
            revcar.Add(cart);
            nrElemente++;
        }
        public void adaugRevista()
        {
            string titlu, data;
            int nr, numar;
            Console.WriteLine("Introduceti date despre revista: ");
            Console.WriteLine("Introduceti titlul: ");
            titlu = Console.ReadLine();
            Console.WriteLine("Introduceti nr de reviste: ");
            nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul revistei:");
            numar = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti data aparitiei: ");
            data = Console.ReadLine();
            Revista rev = new Revista(titlu, nr, numar, data);
            revcar.Add(rev);
            nrElemente++;
        }
        public void Write2Console()
        {
            for(int i=0;i<nrElemente;i++)
            {
                if (revcar[i] is Carte)
                    Console.WriteLine(revcar[i].descriere());
                else
                    if (revcar[i] is Revista)
                    Console.WriteLine(revcar[i].descriere());
            }
        }
        public void cauta(String tlt)
        {
            int ok = 0;
            foreach(Element el in revcar)
            {
                if (el.Titlu == tlt)
                {
                    el.NrExemplare--;
                    Console.WriteLine("Ati imprumutat elementul respectiv!");
                    nrElemente--;
                    ok = 1;
                    break;
                }
            }   
            if(ok==0)
                Console.WriteLine("Nu s-a gasit elementul");

        }
    }
}

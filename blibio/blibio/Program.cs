using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blibio
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca blb = new Biblioteca();
            int nr_total,op,i=0;
            Console.WriteLine("Introduceti nr total de elemente al bibliotecii: ");
            nr_total=int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Selectati o optiune:\n1.Adaug carte\n2.Adaug revista");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        {
                            blb.adaugaCarte();
                            i++;
                            break;

                        }
                        
                    case 2:
                        {
                            blb.adaugRevista();
                            i++;
                            break;

                        }
                       
                    default:
                        {
                            Console.WriteLine("Optiune introdusa gresit!");
                            break;
                        }    
                }

            } while (i < nr_total);
            Console.WriteLine("Elementele bibliotecii sunt: ");
            blb.Write2Console();
            Console.WriteLine("Introduceti tiltu elementului de cautat: ");
            string titlu = Console.ReadLine();
            blb.cauta(titlu);
            Console.WriteLine("Elementele bibliotecii dupa imprumut: ");
            blb.Write2Console();
            Console.ReadKey();

        }
    }
}

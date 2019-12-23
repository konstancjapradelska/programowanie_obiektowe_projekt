using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class oferta :  samochody , IOferta
    {
        public LinkedList<samochody> Oferta = new LinkedList<samochody>();
        public int Ilość_samochodów_do_wypożyczenia = 0;

        void IOferta.Dodaj(samochody s)
        {
            Oferta.AddLast(s);
            Ilość_samochodów_do_wypożyczenia++;
        }

        void IOferta.Usuń(samochody s)
        {
            Oferta.Remove(s);
            Ilość_samochodów_do_wypożyczenia--;
        }

        void IOferta.Wyczysc()
        {
            Oferta.Clear();
            Ilość_samochodów_do_wypożyczenia = 0;
        }

        int IOferta.PodajIlosc()
        {
            Console.WriteLine("Ilość samochodów do wypożyczenia: \n"); 
            return Ilość_samochodów_do_wypożyczenia ;
        }

        public override string ToString()
        {
            Console.WriteLine( "OFERTA: \n" + "Ilość samochodów do wypożyczenia: \n" + Ilość_samochodów_do_wypożyczenia + "\nZawartość: \n");
            int count = 0;
            foreach (samochody element in Oferta)
            {
                count++;
                Console.WriteLine($"Samochód #{count}: {element}");
            }

            return "";
        }

        void IOferta.rezerwuj(samochody s1)
        {
            throw new NotImplementedException();
        }

        samochody IOferta.wybór_samochodu_do_rezerwacji()
        {
            throw new NotImplementedException();
        }
    }
}


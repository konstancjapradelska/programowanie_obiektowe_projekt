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
        //public enum rezerw { Zarezerwowany = 1, Niezarezerwowany = 0 };
        //private rezerw Rezerwacja;
        //int Ilość_samochodów_zarezerwowanych;


        //internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        //public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }

        public void Dodaj(samochody s)
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
                if (element.Rezerwacja == rezerw.Zarezerwowany)
                {
                    Console.WriteLine("             Zarezerwowano");
                }
            }

            return "";
        }

    }
}


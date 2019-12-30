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
        public enum rezerw { Zarezerwowany = 1, Niezarezerwowany = 0 };
        private rezerw Rezerwacja;
        int Ilość_samochodów_zarezerwowanych;


        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }

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
            Rezerwacja1 = oferta.rezerw.Zarezerwowany;
            Ilość_samochodów_do_wypożyczenia--;
            Ilość_samochodów_zarezerwowanych++;
        }

        samochody IOferta.wybór_samochodu_do_rezerwacji()
        {
            samochody s = new samochody();
            string wybór;
            foreach (samochody element in Oferta)
            {
                Console.WriteLine("Jeżeli chcesz wypożyczyć to auto wybierz: TAK");
                Console.WriteLine(element);
                wybór = Console.ReadLine();
                if (wybór == "TAK")
                {
                    s = element;
                    break;
                }
                else
                    continue;
            }
            return s;
        }
    }
}


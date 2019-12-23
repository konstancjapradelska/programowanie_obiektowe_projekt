using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class rezerwacja : oferta, IOferta
    {
        public enum rezerw { Zarezerwowany =  1 , Niezarezerwowany = 0 };
        private rezerw Rezerwacja;
        int Ilość_samochodów_zarezerwowanych;

        
        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }
        
        void IOferta.rezerwuj(samochody s)
        {
            Rezerwacja1 = rezerwacja.rezerw.Zarezerwowany;
            Ilość_samochodów_do_wypożyczenia--;
            Ilość_samochodów_zarezerwowanych++;
        }
        samochody IOferta.wybór_samochodu_do_rezerwacji()
        {
            samochody s = new samochody();
            string wybór;
            foreach(samochody element in Oferta)
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
        public override string ToString()
        {
            Console.WriteLine("\nIlość zarezerwowanych samochdów: " + Ilość_samochodów_zarezerwowanych);
            return base.ToString() ;
        }



    }
}

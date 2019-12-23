using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class rezerwacja : oferta
    {
        public enum rezerw { Zarezerwowany =  1 , Niezarezerwowany = 0 };
        private rezerw Rezerwacja;
        int Ilość_samochodów_zarezerwowanych;

        
        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }
        
        public void rezerwuj(samochody s)
        {
            Rezerwacja1 = rezerwacja.rezerw.Zarezerwowany;
            Ilość_samochodów_do_wypożyczenia--;
            Ilość_samochodów_zarezerwowanych++;
        }
               
        public override string ToString()
        {
            Console.WriteLine("\nIlość zarezerwowanych samochdów: " + Ilość_samochodów_zarezerwowanych);
            return base.ToString() ;
        }



    }
}

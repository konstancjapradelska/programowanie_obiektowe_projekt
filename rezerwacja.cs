﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class rezerwacja : oferta, IOferta
    {
        //public enum rezerw { Zarezerwowany =  1 , Niezarezerwowany = 0 };
        private rezerw Rezerwacja;
        int Ilość_samochodów_zarezerwowanych;

        
        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }
        public int Ilość_samochodów_zarezerwowanych1 { get => Ilość_samochodów_zarezerwowanych; set => Ilość_samochodów_zarezerwowanych = value; }
        
        public virtual void rezerwuj(samochody s)
        {
            s.Rezerwacja = rezerw.Zarezerwowany;
            Ilość_samochodów_do_wypożyczenia--;
            Ilość_samochodów_zarezerwowanych++;
        }
        public samochody wybór_samochodu_do_rezerwacji(oferta s)
        {
            samochody k = new samochody();
            string wybór;
            foreach(samochody element in s.Oferta)
            {
                Console.WriteLine("Jeżeli chcesz wypożyczyć to auto wybierz: TAK");
                Console.WriteLine(element);
                wybór = Console.ReadLine();
                if (wybór == "TAK")
                {
                    k = element;
                    rezerwuj(k);
                    break;
                }
                else
                    continue;
            }
            return k;
        }
        public override string ToString()
        {
            Console.WriteLine("\nIlość zarezerwowanych samochdów: " + Ilość_samochodów_zarezerwowanych);
            return base.ToString() ;
        }



    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class klient : osoba
    {
        private string numer_klienta;
        public string Numer_klienta { get => numer_klienta; set => numer_klienta = value; }

        public klient()
        {
        }

        public klient(string numer_klienta)
        {
            numer_klienta = numer_klienta ?? throw new ArgumentNullException(nameof(numer_klienta));
        }

        public klient(string imie, string nazwisko, string pESEL)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
        }
        public klient(string imie, string nazwisko, string pESEL, string identyfikator)
        {
            this.Imie = imie ?? throw new ArgumentNullException(nameof(imie));
            this.Nazwisko = nazwisko ?? throw new ArgumentNullException(nameof(nazwisko));
            Pesel = pESEL ?? throw new ArgumentNullException(nameof(pESEL));
            Numer_klienta = Numer_klienta ?? throw new ArgumentNullException(nameof(Numer_klienta));
        }
    
        public override string ToString()
        {
            Console.WriteLine("Zalogowano jako klient.\n");

            return "numer_klienta  : " + this.Numer_klienta + base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class klienci
    {
        int liczba_klientów;
        public List<klient> Klienci = new List<klient>();

        public int Liczba_klientów { get => liczba_klientów; set => liczba_klientów = value; }

        public void Dodaj(klient k)
        {
            Klienci.Add(k);
            Liczba_klientów++;
        }
        public void Usuń(klient k)
        {
            Klienci.Remove(k);
            Liczba_klientów--;
        }
        public object sprawdzenie(klient k)
        {
            klient wynik = new klient();
            foreach (klient element in Klienci)
            {
                if (element.Numer_klienta == k.Numer_klienta)
                {
                    wynik = element;
                }
            }
            return wynik;
        }
        public override string ToString()
        {
            int count = 0;
            Console.WriteLine("Liczba klientów: "+ liczba_klientów +"\n");
            foreach (klient element in Klienci)
            {
                count++;
                Console.WriteLine($"Klient #{count}: {element}");
            }
            return "";
        }
    }
}

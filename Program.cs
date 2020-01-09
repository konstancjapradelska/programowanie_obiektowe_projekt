using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ofc
namespace po_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region baza samochodow
            oferta Oferta = new oferta();
            samochody s1 = new samochody { Klasa1 = samochody.klasa.klasa_A, Marka1 = "Fiat", Model1 = "Panda", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback };
            samochody s2 = new samochody { Klasa1 = samochody.klasa.klasa_B, Marka1 = "Opel", Model1 = "Corsa", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback };
            samochody s3 = new samochody { Klasa1 = samochody.klasa.klasa_C, Marka1 = "Kia", Model1 = "Ceed", Silnik1 = samochody.silnik.diesel, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi };
            samochody s4 = new samochody { Klasa1 = samochody.klasa.klasa_C, Marka1 = "Kia", Model1 = "Ceed", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback };
            samochody s5 = new samochody { Klasa1 = samochody.klasa.klasa_D, Marka1 = "Kia", Model1 = "Optima", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi };
            samochody s6 = new samochody { Klasa1 = samochody.klasa.klasa_D, Marka1 = "Kia", Model1 = "Optima", Silnik1 = samochody.silnik.diesel, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback };
            samochody s7 = new samochody { Klasa1 = samochody.klasa.klasa_E, Marka1 = "BMW", Model1 = "525", Silnik1 = samochody.silnik.diesel, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan };
            samochody s8 = new samochody { Klasa1 = samochody.klasa.klasa_E, Marka1 = "BMW", Model1 = "550", Silnik1 = samochody.silnik.benzynowy, Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna, Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi };
            
            Oferta.Dodaj(s1);
            Oferta.Dodaj(s2);
            Oferta.Dodaj(s3);
            Oferta.Dodaj(s4);
            Oferta.Dodaj(s5);
            Oferta.Dodaj(s6);
            Oferta.Dodaj(s7);
            Oferta.Dodaj(s8);
#endregion
            
            string opcja;

            do
            {   Console.WriteLine("Proszę wybrać opcję:\n");
                Console.WriteLine("Jestem klientem -> k");
                Console.WriteLine("Jestem pracownikiem -> p");
                Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                opcja = Console.ReadLine();
                if (opcja == "k")
                {
                    Console.WriteLine("Wybrano opcję : klient");
                   
                    string wybór;
                    do
                    {
                        Console.WriteLine("Jeżeli chcesz wyświetlić naszą ofertę wybierz: oferta");
                        Console.WriteLine("Jeżeli chcesz zarezerwować samochód wybierz: rezerwuj");
                        Console.WriteLine("Jeżeli chcesz wypożyczyć samochód wybierz: wypożycz");
                        Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                        Console.WriteLine("Twój wybór:");
                        wybór = Console.ReadLine();
                        if(wybór == "oferta") 
                        {                      
                            Console.WriteLine(Oferta);
                        }
                        else if(wybór == "rezerwuj")
                        {
                            Console.WriteLine("Wybierz samochodów do rezerwacji:");                           
                            rezerwacja r1 = new rezerwacja();
                            r1.wybór_samochodu_do_rezerwacji(Oferta);
                        }
                        else if (wybór == "wypożycz")
                        {
                            Console.WriteLine("Wybierz samochodów do wypożyczenia:");
                            wypożyczanie w1 = new wypożyczanie();
                            w1.wypożycz(w1.wybór_samochodu_do_wypożyczenia(Oferta),Oferta);
                           
                        }
                        else if (wybór == "koniec")
                            break;
                        else
                        {
                            Console.WriteLine("Nie wybrano żadnej z opcji");
                        }
                    } 
                    while (wybór != "koniec" ) ;
                }
                else if (opcja == "p")
                {
                    Console.WriteLine("Wybrano opcję : pracownik");
                    Console.WriteLine("Proszę o wprowadzenie hasła:\n");
                    string hasło;
                    do
                    {
                        hasło = Console.ReadLine();
                        if(hasło == "programowanie")
                        {
                            Console.WriteLine("Poprawe hasło, zapraszamy.\n");
                            
                            string wybór;
                            do
                            {
                                Console.WriteLine("Jeżeli chcesz dodać samochód do oferty wybierz: dodaj");
                                Console.WriteLine("Jeżeli chcesz usunąć samochód z oferty wybierz: usuń");
                                Console.WriteLine("Jeżeli chcesz wyświetlić naszą ofertę wybierz: oferta");
                                Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                                Console.WriteLine("Twój wybór:");
                                wybór = Console.ReadLine();
                                if (wybór == "dodaj")
                                {
                                    int k = 1 + Oferta.Ilość_samochodów_do_wypożyczenia;
                                    samochody d = new samochody();
                                    string klasa;
                                    Console.WriteLine("Wprowadź klasę samochodu:\n");
                                    do
                                    {
                                        klasa = Console.ReadLine();
                                        if (klasa == "A")
                                        { d.Klasa1 = samochody.klasa.klasa_A; break; }
                                        if (klasa == "B")
                                        { d.Klasa1 = samochody.klasa.klasa_B; break; }
                                        if (klasa == "C")
                                        { d.Klasa1 = samochody.klasa.klasa_C; break; }
                                        if (klasa == "D")
                                        {  d.Klasa1 = samochody.klasa.klasa_D; break;}
                                        if (klasa == "E")
                                        {  d.Klasa1 = samochody.klasa.klasa_E; break;}
                                        else
                                            Console.WriteLine("Proszę wybrać klasę A lub B lub C lub D lub E");
                                    }
                                    while ((klasa != "A") || (klasa != "B") || (klasa != "C" )|| (klasa != "D") || (klasa != "E"));
                                    Console.WriteLine("Wprowadź markę:\n");
                                    d.Marka1 = Console.ReadLine();
                                    Console.WriteLine("Wprowadź model:\n");
                                    d.Model1 = Console.ReadLine();
                                    string silnik;
                                    Console.WriteLine("Wprowadź rodzaj silnika:\n");
                                    do
                                    {
                                        silnik = Console.ReadLine();
                                        if (silnik == "benzynowy")
                                        { d.Silnik1 = samochody.silnik.benzynowy; break; }
                                        if (silnik == "diesel")
                                        { d.Silnik1 = samochody.silnik.diesel; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać silnik benzynowy lub diesel");

                                    }
                                    while (silnik != "benzynowy" || silnik != "diesel");
                                    string skrzynia;
                                    Console.WriteLine("Wprowadź rodzaj skrzynii biegów: \n");
                                    do
                                    {
                                        skrzynia = Console.ReadLine();
                                        if (skrzynia == "manualna")
                                        { d.Skrzynia_Biegów1 = samochody.skrzynia_biegów.manualna; break; }
                                        if (skrzynia == "automatyczna")
                                        { d.Skrzynia_Biegów1 = samochody.skrzynia_biegów.automatyczna; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać skrzynie biegów automatyczna lub manualna");

                                    }
                                    while (skrzynia != "automatyczna" || skrzynia != "manualna");
                                    string nadwozie;
                                    Console.WriteLine("Wprowadzać rodzaj nadwozia:\n");
                                    do
                                    {
                                        nadwozie = Console.ReadLine();
                                        if (nadwozie == "combi")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.combi; break; }
                                        if (nadwozie == "hatchback")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.hatchback; break; }
                                        if (nadwozie == "sedan")
                                        { d.Rodzaj_Nadwozia1 = samochody.rodzaj_nadwozia.sedan; break; }
                                        else
                                            Console.WriteLine("Proszę wybrać rodzaj nadwozia combi lub hatchback lub combi");

                                    }
                                    while ((nadwozie != "combi") || (nadwozie != "hatchback") || (nadwozie != "sedan"));
                                                                      
                                    Oferta.Dodaj(d);
                                }
                                else if (wybór == "usuń")
                                {
                                    Oferta.Usuń(Oferta.wybór_samochodu_do_usunięcia());
                                }
                                else if (wybór == "oferta")
                                {
                                    Console.WriteLine(Oferta);
                                }
                                else if (wybór == "koniec")
                                    break;
                                else 
                                {
                                    Console.WriteLine("Nie wybrano żadnej z opcji");
                                }
                            }
                            while (wybór != "koniec");

                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Podano błędne hasło\nSpróbuj jeszcze raz.\n");
                        }
                    }
                    while (hasło != "programowanie");
                }
                else if (opcja == "koniec")
                    break;
                else
                {
                    Console.WriteLine("Proszę wybrać ,k' lub ,p' lub 'koniec'.");
                }
            }
            while (opcja != "koniec");


            #region serializacja
            oferta.ZapiszXML("zapis.xml", Oferta);
            oferta klon = new oferta();
            klon = klon.OdczytajXML("zapis.xml") as oferta;
            Console.WriteLine(klon);
            Console.ReadKey();
            #endregion

        }

    }

}


 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            oferta.ZapiszXML("zapis.xml", Oferta);
            #endregion

            #region baza pracowników
            pracownik p1 = new pracownik { Imie = "Jan"  , Nazwisko = "Janowski" , Pesel ="82080328496" , Identyfikator = "100", Stanowisko1 = pracownik.Stanowisko.kierownik };
            pracownik p2 = new pracownik { Imie = "Beata"  , Nazwisko = "Jurkiewicz" , Pesel = "92102201347" , Identyfikator ="101" , Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };
            pracownik p3 = new pracownik { Imie = "Anna" , Nazwisko = "Dobrowolska", Pesel = "92031507772" , Identyfikator ="102" , Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };
            pracownik p4 = new pracownik { Imie = "Jakub" , Nazwisko = "Grobelczyk" , Pesel = " 90070100211" , Identyfikator ="103" , Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };
            pracownik p5 = new pracownik { Imie = "Wiktor" , Nazwisko = "Jagielski", Pesel = " 92031532652", Identyfikator ="104" , Stanowisko1 = pracownik.Stanowisko.zwykły_pracownik };

            pracownicy Pracownicy = new pracownicy();
            Pracownicy.Dodaj(p1);
            Pracownicy.Dodaj(p2);
            Pracownicy.Dodaj(p3);
            Pracownicy.Dodaj(p4);
            Pracownicy.Dodaj(p5);

            #endregion

            #region baza klientów
            klient k1 = new klient { Imie = "Witold"  , Nazwisko = "Adamski" , Pesel = "90070142412", Numer_klienta = "200" };
            klient k2 = new klient { Imie = "Paulina" , Nazwisko = "Szymańska" , Pesel = "92102266738", Numer_klienta = "201" };
            klient k3 = new klient { Imie = "Adam" , Nazwisko = "Winnicki" , Pesel = "91072235964 K", Numer_klienta = "202" };
            klient k4 = new klient { Imie = "Radosław" , Nazwisko = "Leszczyński" , Pesel = "93112225023", Numer_klienta = "203" };
            klient k5 = new klient { Imie = "Błażej" , Nazwisko = "Tomaszewski" , Pesel = "92051613915", Numer_klienta = "204" };
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
                    klient k = new klient();
                    Console.WriteLine("Proszę o wprowadzenie numeru klienta:\n");
                    k.Numer_klienta = Console.ReadLine();

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
                            Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;
                            Console.WriteLine("Wybierz sortowanie:");
                            Console.WriteLine("Jeżeli chcesz sortować po klasie samochodu wybierz: klasa");
                            Console.WriteLine("Jeżeli chcesz sortować po modelu samochodu wybierz: model");
                            Console.WriteLine("Jeżeli chcesz sortować po cenie samochodu wybierz: cena");
                            Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                            string wybór_sortowania;
                            do
                            {
                                wybór_sortowania = Console.ReadLine();
                                if (wybór_sortowania == "klasa")
                                {
                                    Console.WriteLine("SORTOWANIE PO KLASIE:");
                                    Oferta.Sortuj_po_klasie_samochodu();
                                    Console.WriteLine(Oferta);
                                }
                                else if (wybór_sortowania == "model")
                                {
                                    Console.WriteLine("SORTOWANIE PO MODELU:");
                                    Oferta.Sortuj_po_modelu_samochodu();
                                    Console.WriteLine(Oferta);
                                }
                                else if (wybór_sortowania =="cena")
                                {
                                    Console.WriteLine("opcja do dodania");
                                }
                                else if (wybór_sortowania == "koniec")
                                    break;
                            }
                            while (wybór_sortowania != "koniec");
                            
                        }
                        else if(wybór == "rezerwuj")
                        {
                            Console.WriteLine("Wybierz samochodów do rezerwacji:");                           
                            rezerwacja r1 = new rezerwacja();
                            r1.wybór_samochodu_do_rezerwacji(Oferta);
                            oferta.ZapiszXML("zapis.xml", Oferta);
                        }
                        else if (wybór == "wypożycz")
                        {
                            Console.WriteLine("Wybierz samochodów do wypożyczenia:");
                            wypożyczanie w1 = new wypożyczanie();
                            w1.wypożycz(w1.wybór_samochodu_do_wypożyczenia(Oferta),Oferta);
                            oferta.ZapiszXML("zapis.xml", Oferta);
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
                    pracownik p = new pracownik();
                    Console.WriteLine("Proszę o wprowadzenie identyfikatora:\n");
                    p.Identyfikator = Console.ReadLine();
                    
                    Console.WriteLine("Proszę o wprowadzenie hasła:\n");
                    string hasło;
                    do
                    {
                        pracownik P = new pracownik();
                        P = Pracownicy.sprawdzenie(p) as pracownik;
                        hasło = Console.ReadLine();
                        if(hasło == "programowanie")
                        {
                            Console.WriteLine("Poprawe hasło, zapraszamy.\n");
                            Console.WriteLine("Zalogowano się do systemu jako:\n" + P);
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

                                    oferta.ZapiszXML("zapis.xml", Oferta);
                                }
                                else if (wybór == "usuń")
                                {
                                    Oferta.Usuń(Oferta.wybór_samochodu_do_usunięcia());

                                    oferta.ZapiszXML("zapis.xml", Oferta);
                                }
                                else if (wybór == "oferta")
                                {
                                    Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;
                                    Console.WriteLine("Wybierz sortowanie:");
                                    Console.WriteLine("Jeżeli chcesz sortować po klasie samochodu wybierz: klasa");
                                    Console.WriteLine("Jeżeli chcesz sortować po modelu samochodu wybierz: model");
                                    Console.WriteLine("Jeżeli chcesz sortować po cenie samochodu wybierz: cena");
                                    Console.WriteLine("Jeżeli chcesz wyjść wybierz : koniec");
                                    string wybór_sortowania;
                                    do
                                    {
                                        wybór_sortowania = Console.ReadLine();
                                        if (wybór_sortowania == "klasa")
                                        {
                                            Console.WriteLine("SORTOWANIE PO KLASIE:");
                                            Oferta.Sortuj_po_klasie_samochodu();
                                            Console.WriteLine(Oferta);
                                        }
                                        else if (wybór_sortowania == "model")
                                        {
                                            Console.WriteLine("SORTOWANIE PO MODELU:");
                                            Oferta.Sortuj_po_modelu_samochodu();
                                            Console.WriteLine(Oferta);
                                        }
                                        else if (wybór_sortowania == "cena")
                                        {
                                            Console.WriteLine("opcja do dodania");
                                        }

                                        else if (wybór_sortowania == "koniec")
                                            break;
                                    }
                                    while (wybór_sortowania != "koniec");
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
           
            //#region serializacja
            //oferta.ZapiszXML("zapis.xml", Oferta);
            //Oferta = Oferta.OdczytajXML("zapis.xml") as oferta;
            //Console.WriteLine(Oferta);

            //#endregion
            //Console.WriteLine("SORTOWANIE PO KLASIE:");
            //Oferta.Sortuj_po_klasie_samochodu();
            //Console.WriteLine(Oferta);
            //Console.WriteLine("SORTOWANIE PO MODELU:");
            //Oferta.Sortuj_po_modelu_samochodu();
            //Console.WriteLine(Oferta);
            Console.ReadKey();
        }

    }

}


 


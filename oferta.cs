using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace po_projekt
{
    [XmlInclude(typeof(samochody))]
    
    public class oferta : samochody, IOferta
    {
        public LinkedList<samochody> Oferta = new LinkedList<samochody>();
        public List<samochody> lista;
        public int Ilość_samochodów_do_wypożyczenia = 0;


        public oferta()
        {
        }

        public oferta(LinkedList<samochody> oferta)
        {
            Oferta = oferta ?? throw new ArgumentNullException(nameof(oferta));
        }

        public oferta(LinkedList<samochody> oferta, List<samochody> lista, int ilość_samochodów_do_wypożyczenia) : this(oferta)
        {
            this.lista = lista ?? throw new ArgumentNullException(nameof(lista));
            Ilość_samochodów_do_wypożyczenia = ilość_samochodów_do_wypożyczenia;
        }

        public void Dodaj(samochody s)
        {
            Oferta.AddLast(s);
            Ilość_samochodów_do_wypożyczenia++;
        }

        public virtual void Usuń(samochody s)
        {
            Oferta.Remove(s);
            Ilość_samochodów_do_wypożyczenia--;
        }

        public void Wyczysc()
        {
            Oferta.Clear();
            Ilość_samochodów_do_wypożyczenia = 0;
        }

        public int PodajIlosc()
        {
            Console.WriteLine("Ilość samochodów do wypożyczenia: \n"); 
            return Ilość_samochodów_do_wypożyczenia ;
        }

        public samochody wybór_samochodu_do_usunięcia()
        {
            samochody k = new samochody();
            string wybór;
            foreach (samochody element in Oferta)
            {
                Console.WriteLine("Jeżeli chcesz usunąć to auto wybierz: TAK");
                Console.WriteLine(element);
                wybór = Console.ReadLine();
                if (wybór == "TAK")
                {
                    k = element;
                    
                    break;
                }
                else
                    continue;
            }
            return k;
        }



        public static void ZapiszXML(string nazwa, oferta xmloferta)
        {
            xmloferta.lista = new List<samochody>(xmloferta.Oferta);
            XmlSerializer serializer = new XmlSerializer(typeof(oferta));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, xmloferta);
            writer.Close();
        }

        public object OdczytajXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(oferta));
            StreamReader reader = new StreamReader(nazwa);
            oferta xmloferta = serializer.Deserialize(reader) as oferta;
            reader.Close();
            xmloferta.Oferta = new LinkedList<samochody>(xmloferta.lista);
            return xmloferta;
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_projekt
{
    class rezerwacja : samochody
    {
        public enum rezerw { Zarezerwowany =  1 , Niezarezerwowany = 0 };
        private rezerw Rezerwacja;

        internal rezerw Rezerwacja1 { get => Rezerwacja; set => Rezerwacja = value; }



    }
}

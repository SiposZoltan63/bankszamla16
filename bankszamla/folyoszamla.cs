using bankszamla.BankiRendszer;
using System;
using System.Collections.Generic;
using System.Text;

namespace bankszamla
{
    public class Folyoszamla : Bankszamla
    {
        public decimal Hitelkeret { get; set; }

        public Folyoszamla(string szamlaszam, string tulajdonos, decimal kezdoEgyenleg = 0m, decimal hitelkeret = 10000.0m)
            : base(szamlaszam, tulajdonos, kezdoEgyenleg)
        {
            Hitelkeret = hitelkeret;
        }

        public override void Kifizetes(decimal osszeg)
        {
            if (osszeg < 0)
            {
                throw new ArgumentException("A kifizetendő összeg nem lehet negatív!", nameof(osszeg));
            }

            if (Egyenleg - osszeg < -Hitelkeret)
            {
                throw new InvalidOperationException("A kifizetés nem hajtható végre: túllépné a megengedett hitelkeretet!");
            }

            Egyenleg -= osszeg;
        }
    }
}

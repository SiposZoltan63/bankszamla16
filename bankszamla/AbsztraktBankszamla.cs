using System;
using System.Collections.Generic;
using System.Text;

namespace bankszamla
{
    using System;

    namespace BankiRendszer
    {
        public abstract class Bankszamla
        {
            public string Szamlaszam { get; set; }
            public string Tulajdonos { get; set; }
            public decimal Egyenleg { get; protected set; }

            public Bankszamla(string szamlaszam, string tulajdonos, decimal kezdoEgyenleg = 0m)
            {
                if (kezdoEgyenleg < 0)
                {
                    throw new ArgumentException("A kezdő egyenleg nem lehet negatív!", nameof(kezdoEgyenleg));
                }

                Szamlaszam = szamlaszam;
                Tulajdonos = tulajdonos;
                Egyenleg = kezdoEgyenleg;
            }

            public void Befizetes(decimal osszeg)
            {
                if (osszeg < 0)
                {
                    throw new ArgumentException("A befizetendő összeg nem lehet negatív!", nameof(osszeg));
                }

                Egyenleg += osszeg;
            }

            public abstract void Kifizetes(decimal osszeg);
        }
    }
}

using bankszamla.BankiRendszer;
using System;
using System.Collections.Generic;
using System.Text;

namespace bankszamla
{
    public class MegtakaritasiSzamla : Bankszamla
    {
        public MegtakaritasiSzamla(string szamlaszam, string tulajdonos, decimal kezdoEgyenleg = 0m)
            : base(szamlaszam, tulajdonos, kezdoEgyenleg)
        {
        }

        public override void Kifizetes(decimal osszeg)
        {
            if (osszeg < 0)
            {
                throw new ArgumentException("A kifizetendő összeg nem lehet negatív!", nameof(osszeg));
            }

            if (Egyenleg - osszeg < 0)
            {
                throw new InvalidOperationException("A kifizetés nem hajtható végre: a megtakarítási számla egyenlege nem mehet negatívba!");
            }

            Egyenleg -= osszeg;
        }
    }
}

namespace bankszamla
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Folyoszamla folyo = new Folyoszamla("00120102-03451234-00000000", "Kovács Péter", 5000m, 10000m);
                Console.WriteLine($"Számla tulajdonos: {folyo.Tulajdonos}");
                Console.WriteLine($"Számlaszám: {folyo.Szamlaszam}");
                Console.WriteLine($"Folyószámla kezdő egyenleg: {folyo.Egyenleg} Ft");

                decimal kifizetettOsszeg1 = 12000m;
                folyo.Kifizetes(kifizetettOsszeg1);
                Console.WriteLine($"Kifizetve: {kifizetettOsszeg1} Ft");
                Console.WriteLine($"Kifizetés utáni egyenleg: {folyo.Egyenleg} Ft");

                MegtakaritasiSzamla megtakaritas = new MegtakaritasiSzamla("11111111-22222222-33333333", "Nagy Anna", 20000m);
                Console.WriteLine($"\nSzámla tulajdonos: {megtakaritas.Tulajdonos}");
                Console.WriteLine($"Számlaszám: {megtakaritas.Szamlaszam}");
                Console.WriteLine($"Megtakarítási számla kezdő egyenleg: {megtakaritas.Egyenleg} Ft");

                decimal kifizetettOsszeg2 = 5000m;
                megtakaritas.Kifizetes(kifizetettOsszeg2);
                Console.WriteLine($"Kifizetve: {kifizetettOsszeg2} Ft");
                Console.WriteLine($"Kifizetés utáni egyenleg: {megtakaritas.Egyenleg} Ft");
                decimal kifizetettOsszeg3 = 20000m;
                megtakaritas.Kifizetes(kifizetettOsszeg3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Paraméter hiba: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Műveleti hiba: {ex.Message}");
            }
        }
    }
}

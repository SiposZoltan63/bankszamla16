namespace bankszamla
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Folyoszamla folyo = new Folyoszamla("00120102-03451234-00000000", "Kovács Péter", 5000m, 10000m);
                Console.WriteLine($"Folyószámla kezdő egyenleg: {folyo.Egyenleg} Ft");

                folyo.Kifizetes(12000m);
                Console.WriteLine($"Kifizetés utáni egyenleg: {folyo.Egyenleg} Ft");

                MegtakaritasiSzamla megtakaritas = new MegtakaritasiSzamla("11111111-22222222-33333333", "Nagy Anna", 20000m);
                Console.WriteLine($"\nMegtakarítási számla kezdő egyenleg: {megtakaritas.Egyenleg} Ft");

                megtakaritas.Kifizetes(5000m);
                Console.WriteLine($"Kifizetés utáni egyenleg: {megtakaritas.Egyenleg} Ft");

                megtakaritas.Kifizetes(20000m);
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

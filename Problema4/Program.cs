namespace Problema4
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti cuvantul: ");
            string text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Nu ati introdus niciun cuvant.");
                return;
            }

            // Verificare dacă textul introdus este un număr
            if (double.TryParse(text, out _))
            {
                Console.WriteLine("Va rog sa introduceti un cuvant, nu un numar!");
                return;
            }

            if (StringHelper.Ispalindrom(text))
            {
                Console.WriteLine(text + " este palindrom.");

            }
            else
            {
                Console.WriteLine(text + " nu este palindrom.");

            }

            

        }
    }
}
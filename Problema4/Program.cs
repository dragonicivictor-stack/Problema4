namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti cuvantul: ");
            string text = Console.ReadLine();

            int index = 0;
            int index2 = text.Length - 1;
            bool estepalindrom = true;



            while (index < index2)
            {
                if (text[index] != text[index2])
                { estepalindrom = false;
                    break;
                }
                    
                index++;
                index2--;
            }
          

        if(estepalindrom)
            {
                Console.WriteLine(text + " este palindrom.");
            }
        else
            {
                Console.WriteLine(text + " nu este palindrom.");
            }
        Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    public class StringHelper
    {
        public static bool Ispalindrom(string text)
        {
            int index = 0;
            int index2 = text.Length - 1;
            bool estepalindrom = true;



            while (index < index2)
            {
                if (text[index] != text[index2])
                {
                    estepalindrom = false;
                    break;
                }

                index++;
                index2--;
            }

            return estepalindrom;
            

            

        }
    }
}

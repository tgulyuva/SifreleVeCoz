using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreleVeCoz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alfabe = new List<string>
            {
                "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "i", "ı", "j", "k", "l", "m", "n", "o", "ö", "p", "q", "r", "s", "ş", "t", "u", "ü", "v", "w", "x", "y", "z"
            };
            SifreleMetodu(alfabe);
        }

        private static void SifreleMetodu(List<string> alfabe)
        {
            Console.WriteLine("Sifrelemek istenen kelimeyi yazınız:");
            string result = "";
            string metin = Console.ReadLine();
            metin.ToCharArray();
            int i;
            foreach (char item in metin)
            {
                if (item != ' ')
                {
                    i = alfabe.IndexOf(item.ToString());
                    result += i + "-";
                }
                else
                {
                    result += result.TrimEnd('-');
                    result += "+";
                }
            }

            Console.WriteLine(result.TrimEnd('-'));
            Console.ReadLine();
        }
    }
}

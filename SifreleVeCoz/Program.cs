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
            CozMethodu(alfabe);
            Console.ReadLine();
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
                   result= result.TrimEnd('-');
                    result += "+";
                }
            }

            Console.WriteLine(result.TrimEnd('-'));
            Console.ReadLine();
        }

        private static void CozMethodu(List<string> alfabe)
        {
            Console.WriteLine("Çözmek istediğiniz şifreyi girin.");
            string cumle = Console.ReadLine();
            
            string result = "";
            string[] kelime = cumle.Split('+');
           

            foreach (var item  in kelime)
            {
                string[] words = item.Split('-');

                foreach (var harf  in words)
                {
                  result += alfabe[Int32.Parse(harf.ToString())];
                    
                }

                result += " ";

            }
            
            Console.WriteLine(result);

        }
    }
}

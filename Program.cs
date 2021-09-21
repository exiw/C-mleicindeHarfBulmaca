using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CümleicindeHardBulmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir kelime giriniz :");
            string kelime = Console.ReadLine();
            Console.Write("Lütfen aranacak karakteri giriniz :");
            char aranan = Convert.ToChar(Console.ReadLine());
            int sonuc = kelime.IndexOf(aranan);
            if (sonuc == -1)
            {
                Console.WriteLine("Bulunamadı");
            }
            else
            {
                Console.WriteLine("Kelimenin {0}. sırasında bulndur", (++sonuc));
            }
            Console.ReadKey();
        }
    }
}

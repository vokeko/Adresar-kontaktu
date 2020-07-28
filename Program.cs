using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Adresář_kontaktů
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList seznamZaznamu = new ArrayList();
            bool programBezi = true;
            while(programBezi)
            {
                Console.Clear();
                Console.WriteLine("Stisknětě 'P' pro přidání záznamu");
                Console.WriteLine("Stisknětě 'V' pro výpis záznamů");
                Console.WriteLine("Stisknětě 'U' pro úpravu záznamů");
                Console.WriteLine("Stiskněte 'H' pro hledání");
                Console.WriteLine("Stiskněte 'K' pro konec");
                ConsoleKeyInfo klavesa = Console.ReadKey(true);
                switch(klavesa.Key)
                {
                    case ConsoleKey.P:
                        Zaznam NovyZaznam = new Zaznam();
                        break;
                    case ConsoleKey.V:
                        break;
                    case ConsoleKey.U:
                        break;
                    case ConsoleKey.H:
                        break;
                    case ConsoleKey.K:
                        programBezi = false;
                        break;
                    default:
                        break;
                }
                Console.ReadKey(true);
            }
        }
        static void UpravZaznam(Zaznam zaznam)
        {
            Console.WriteLine();
            zaznam.Jmeno = Console.ReadLine();
            Console.WriteLine();
            zaznam.Adresa = Console.ReadLine();
        }
    }
}

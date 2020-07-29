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
                        Zaznam novyZaznam = new Zaznam();
                        UpravZaznam(novyZaznam);
                        Console.WriteLine("Číslo záznamu: ");
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        if (seznamZaznamu.Count > 0)
                        {
                            int pocitadlo = 0;
                            foreach (Zaznam z in seznamZaznamu)
                            {
                                Console.WriteLine("Číslo záznamu: " + pocitadlo++);
                                VypisZaznam(z);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Seznam je prázdný!");
                        }
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
        static void VypisZaznam(Zaznam z)
        {
            Console.WriteLine("Jméno: " + z.Jmeno + "\nAdresa: " + z.Adresa);
        }
    }
}

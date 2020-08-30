using System;
using System.Collections;

namespace Adresář_kontaktů
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList seznamZaznamu = new ArrayList();
            seznamZaznamu.Add(1);
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
                        Console.WriteLine("Zadejte prosím nejdřív jméno a pak adresu - ");
                        Zaznam novyZaznam = new Zaznam();
                        UpravZaznam(novyZaznam);
                        Console.WriteLine("Číslo záznamu: " + seznamZaznamu.Add(novyZaznam));
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        if (seznamZaznamu.Count > 0)
                        {
                            int pocitadlo = 0;
                            foreach (object O in seznamZaznamu)
                            {
                                Zaznam z = O as Zaznam;
                                if (z != null)
                                {
                                    Console.WriteLine("Číslo záznamu: " + pocitadlo++);
                                    VypisZaznam(z);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Seznam je prázdný!");
                        }
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine("Zadejte prosím číslo záznamu: ");
                        try
                        {
                            int CisloZaznamu = int.Parse(Console.ReadLine());
                            Zaznam VybranyZaznam = (Zaznam)seznamZaznamu[CisloZaznamu];
                            VypisZaznam(VybranyZaznam);
                            UpravZaznam(VybranyZaznam);
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Neplatný vstup!");
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Záznam na dané pozici neexistuje!");
                        }
                        catch(OverflowException)
                        {
                            Console.WriteLine("Zadaná hodnota je mimo rozsah!");
                        }
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("Zadejte prosím hledané jméno nebo jeho část: ");
                        string HledanyRetezec = Console.ReadLine();
                        int nalezeneZaznamy = 0;
                        foreach(object o in seznamZaznamu)
                        {
                            Zaznam Z = o as Zaznam;
                            if (Z != null)
                            {
                                if (Z.Jmeno.Contains(HledanyRetezec))
                                {
                                    nalezeneZaznamy++;
                                    VypisZaznam(Z);
                                }
                            }

                        }

                        if (nalezeneZaznamy > 0)
                        {
                            Console.WriteLine("Záznamů nalezeno: " + nalezeneZaznamy);
                        }
                        else Console.WriteLine("Žádný záznam nebyl nalezen!");
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
            Console.WriteLine("Zadejte prosím jméno");
            zaznam.Jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte prosím adresu");
            zaznam.Adresa = Console.ReadLine();
        }
        static void VypisZaznam(Zaznam z)
        {
            Console.WriteLine("Jméno: " + z.Jmeno + "\nAdresa: " + z.Adresa);
        }
    }
}

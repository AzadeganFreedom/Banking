using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Banking
{
    internal class Menu
    {
        //Menu hvis man logger ind som kunde
        public void CustomerMenu()
        {            
            while(true)
            {
                Console.WriteLine("1: Se oversigt over konti\n2: Opret konto\n\nq: Luk program");
                string userChoice = Console.ReadLine();
                Console.Clear();
                
                int i = 1;
                string valuta = "kr";

                switch (userChoice)
                {
                    case "1":

                        foreach (var a1 in Data.account)
                        {
                            if(a1.Saldo != null & a1.NewSaldo == null)
                            {
                                Console.WriteLine("Konto #{0}: " + a1.Saldo + "{1}", i++, valuta);
                            }                            
                            else if(a1.Saldo != null & a1.NewSaldo != null)
                            {
                                foreach (var an in Data.newAccount)
                                {
                                    Console.WriteLine("Konto #{0}: " + a1.Saldo + "{1}", i++, valuta);
                                    Console.WriteLine("Konto #{0}: " + a1.NewSaldo + "{1}", i++, valuta);
                                }
                            }
                        }
                        Console.WriteLine("\n");
                        break;

                    case "2":
                        foreach (var an in Data.newAccount)
                        {
                            Console.WriteLine("Hvor meget vil du tilføje i dit nye konto?");

                        }
                        break;

                    case "q":
                        Console.WriteLine("På gensyn. Tak for denne gang!");
                        Environment.Exit(0);                        
                        break;
                }
            }                       
        }

        //Menu hvis man logger ind som medarbejder
        public void EmployeeMenu()
        {
            while (true)
            {
                Console.WriteLine("1: Se oversigt over kunder og deres konti\n2: Tilføj kunde\n\nq: Luk program");
                string userChoice = Console.ReadLine();
                Console.Clear();
                
                int i = 1;
                string valuta = "kr";

                switch (userChoice)
                {
                    case "1":
                        foreach (var c in Data.customers)
                        {
                            if ((c.Name != null & c.Email != null) && (c.NewName == null & c.NewEmail == null))
                            {
                                Console.WriteLine("Kunde: {0} (Email: {1})", c.Name, c.Email);
                                foreach (var a1 in Data.account)
                                {
                                    Console.WriteLine("Konto #{0}: " + a1.Saldo + "{1}", i++, valuta);
                                }
                            }
                            else if ((c.NewName != null & c.NewEmail != null) && (c.Name != null & c.Email != null))
                            {
                                Console.WriteLine("Kunde: {0} (Email: {1})", c.Name, c.Email);
                                foreach (var a1 in Data.account)
                                {
                                    Console.WriteLine("Konto #{0}: " + a1.Saldo + "{1}", i++, valuta);
                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("Kunde: {0} (Email: {1})", c.NewName, c.NewEmail);
                            }
                        }
                        Console.WriteLine("\n");
                        break;

                    case "2":
                        foreach (var cn in Data.customers)
                        {
                            Console.WriteLine("Indtast kundens navn: ");
                            cn.NewName = Console.ReadLine();
                            Console.WriteLine("Indtast kundens email: ");
                            cn.NewEmail = Console.ReadLine();
                            Console.WriteLine("Indtast kundens password: ");
                            cn.NewPassword = Console.ReadLine();
                            Console.Clear();
                            break;
                        }                        
                        break;

                    case "q":
                        Console.WriteLine("På gensyn. Tak for denne gang!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Banking
{
    internal class Login
    {
        //field for medarbejder og kunde
        Customer _customer;
        Employee _employee;
        public void CustomerLogin()
        {
            //Skal loopes indtil man indtaster gyldig navn og password

            bool isCorrect = false;

            while (isCorrect == false)
            {
                Console.WriteLine("Kunde\n\nIndtast brugernavn: ");
                string user = Console.ReadLine();

                Console.WriteLine("Indtast password: ");
                string password = Console.ReadLine();

                isCorrect = cLogin(user,password);

            }
            //Menu systemet skal startes op når kunden taster sit navn og password            
        }

        private bool cLogin(string? user, string? password)
        {
            foreach (var c in Data.customers)
            {
                if (user == c.Name && password == c.Password)
                {
                    Console.Clear();
                    Console.WriteLine("Velkommen " + c.Name + " (mail: " + c.Email + ")\n" );
                    _customer = c;
                    return true;
                }
            }
            Console.WriteLine("Ugyldig navn eller password! Vær sød og prøv igen!\nTryk Enter");
            Console.ReadLine();
            Console.Clear();
            return false;
        }


        public void EmployeeLogin()
        {
            //Skal loopes indtil man indtaster gyldig navn og password

            bool isCorrect = false;

            while (isCorrect == false)
            {
                Console.WriteLine("Medarbejder\n\nIndtast brugernavn: ");
                string user = Console.ReadLine();

                Console.WriteLine("Indtast password: ");
                string password = Console.ReadLine();

                isCorrect = eLogin(user, password);

            }
            //Menu systemet skal startes op når medarbjder taster sit navn og password
        }   

        private bool eLogin(string? user, string? password)
        {
            foreach (var e in Data.employee)
            {
                if (user == e.Name && password == e.Password)
                {
                    Console.Clear();
                    Console.WriteLine("Velkommen " + e.Name + "\n");
                    _employee = e;
                    return true;
                }
            }
            Console.WriteLine("Ugyldig navn eller password! Vær sød og prøv igen!\nTryk Enter");
            Console.ReadLine();
            Console.Clear();
            return false;
        }
    }            
}

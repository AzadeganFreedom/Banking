// See https://aka.ms/new-console-template for more information
namespace Banking
{
    internal class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            new Data().AddFakeData();


            Console.WriteLine("\n1: Kunde\n2: Medarbejder\n\nq: Luk programmmet");
            string userChoice = Console.ReadLine();
            Console.Clear();

            switch (userChoice)
            {
                case "1":
                    //Brugernavn: Johnny
                    //Password: ChuckBerry
                    new Login().CustomerLogin();
                    new Menu().CustomerMenu();
                    break;

                case "2":
                    //Brugernavn: Tokyo
                    //Password: MoneyHeist
                    new Login().EmployeeLogin();
                    new Menu().EmployeeMenu();
                    break;

                case "q":
                    Console.WriteLine("På gensyn. Tak for denne gang!");
                    Environment.Exit(0);
                    break;
            }
                
        }
    }
}


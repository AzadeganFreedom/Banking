namespace Banking
{
    internal class Data
    {
        public static List<Customer> customers = new();
        public static List<Account> account = new(), newAccount = new();
        public static List<Employee> employee = new();

        public void AddFakeData()
        {
            //Kunde data for en allerede eksisterende kunde i systemet
            Customer c = new Customer();
            c.Name = "Johnny"; c.Email = "Bgood.com"; c.Password = "ChuckBerry";
            customers.Add(c);

            //Ikke eksisterende kunde som medarbejderen kan tilføje i systemet
            Customer cn = new Customer();
            cn.NewName = null; cn.NewEmail = null; cn.NewPassword = null;
            customers.Add(cn);

            //Konti til den allerede eksisternde kunde i systemet
            Account a1 = new Account();
            a1.Saldo = 2000;
            account.Add(a1);
            Account a2 = new Account();
            a2.Saldo = 3500;
            account.Add(a2);

            Account an = new Account();
            an.NewSaldo = null;
            newAccount.Add(an);

            //Medarbejder data for en allerede eksisterende medarbejder i systemet
            Employee e = new Employee();
            e.Name = "Tokyo"; e.Password = "MoneyHeist";
            employee.Add(e);
        }
    }
}

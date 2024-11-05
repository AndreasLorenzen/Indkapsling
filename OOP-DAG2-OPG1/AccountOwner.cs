using System;

namespace Bank
{
    internal class AccountOwner
    {
        public int ID { get; private set; }
        public string FullName { get; private set; }

        // Constructor with ID and name parameters
        public AccountOwner(int id, string name)
        {
            ID = id;
            FullName = name;
        }

        public Account Owner { get; set; }

        public void UserInfo()
        {
            Console.WriteLine($"Konto ejer: {FullName}, ID: {ID}");
        }
    }
}
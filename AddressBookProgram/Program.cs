using System;

namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBookMain main = new AddressBookMain();

            main.AddContact();
            main.Display();
        }
    }
}

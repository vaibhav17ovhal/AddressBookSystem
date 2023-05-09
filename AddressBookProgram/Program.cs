using System;

namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("\n==========||==========\n");

            AddressBookMain main = new AddressBookMain();

            main.AddContact();
            Console.WriteLine("==========||==========\n");
            main.Display();

            Console.WriteLine("\n==========||==========\n");

            main.EditContact();
            Console.WriteLine("==========||==========\n");
            main.Display();
        }
    }
}

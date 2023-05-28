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

            Console.Write("Enter the number of contact you want to save: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                main.AddContact();
                Console.WriteLine("==========||==========\n");
                main.Display();
                Console.WriteLine("\n");
                
            }

            /*Console.WriteLine("\n==========||==========\n");

            main.EditContact();
            Console.WriteLine("==========||==========\n");
            main.Display();

            Console.WriteLine("\n==========||==========\n");

            main.DeleteContact();
            Console.WriteLine("==========||==========\n");
            */
        }
    }
}

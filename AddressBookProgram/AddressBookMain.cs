using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        List<Contact> main = new List<Contact>();
        public void AddContact()
        {
            Console.Write("Enter the first name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter the address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter the city: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter the state: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter the Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter the phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter the email: ");
            contact.Email = Console.ReadLine();

            main.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
        public void EditContact()
        {
            Console.WriteLine("Enter weather you want to edit or not: \n 1.YES \n 2.NO");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Write("Edit using first name: ");
                    string name = Console.ReadLine();
                    foreach (var data in main)
                    {
                        if (data.FirstName == name)
                        {
                            Console.WriteLine("Choose any parameter to edit: \n 1.FirstName \n 2.LastName \n 3.Address \n 4.City \n 5.State \n 6.Zip \n 7.PhoneNumber \n 8.Email \n 9.Quit Edit");
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.Write("Enter new FirstName: ");
                                    data.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("Enter new LastName: ");
                                    data.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Enter new Address: ");
                                    data.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("Enter new City: ");
                                    data.City = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.Write("Enter new State: ");
                                    data.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.Write("Enter new Zip: ");
                                    data.Zip = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.Write("Enter new PhoneNumber: ");
                                    data.PhoneNumber = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.Write("Enter new Email: ");
                                    data.Email = Console.ReadLine();
                                    break;
                                case 9:
                                    break;
                            }
                        }
                    }
                    break;
                case 2:
                    break;
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter weather you want to delete or not: \n 1.YES \n 2.NO");
            int select1 = Convert.ToInt32(Console.ReadLine());
            switch (select1)
            {
                case 1:
                    Console.WriteLine("Enter name to delete details: ");
                    string name = Console.ReadLine();
                    foreach (var data in main)
                    {
                        if (data.FirstName.Equals(name))
                        {
                            contact = data;
                        }
                    }
                    main.Remove(contact);
                    Console.WriteLine("Contact Successfully deleted");
                    break;
                case 2:
                    Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
                    break;
            }
        }
    }
}

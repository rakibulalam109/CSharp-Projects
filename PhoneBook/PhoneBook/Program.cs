using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! It is a PhoneBook Console Application");
            Console.WriteLine("Operation Catelog:");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact By Number");
            Console.WriteLine("3 View All Contacts");
            Console.WriteLine("4 Search For Contact By a Name");
            Console.WriteLine("5 Delete Contact by Name"); 
            Console.WriteLine("6 Delete Contact by Number");
            Console.WriteLine("7 Exit From PhoneBook");

            Console.WriteLine($"{Environment.NewLine}Select Operation:");
            var userInput = Console.ReadLine();

            var phnBook = new PhnBook();

            while (true)
            {              
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();
                        var contact = new Contact(name, number);
                        phnBook.AddContact(contact);
                        break;

                    case "2":
                        Console.WriteLine("Input Contact Number for search:");
                        var searchNumber = Console.ReadLine();
                        phnBook.DisplayContact(searchNumber);
                        break;

                    case "3":
                        phnBook.ViewAllContact();
                        break;

                    case "4":
                        Console.WriteLine("Input Contact Name for search:");
                        var inputName = Console.ReadLine();
                        phnBook.DisplayMatchingContact(inputName);
                        break;

                    case "5":
                        Console.WriteLine("Contact Name:");
                        var deleteContactByName = Console.ReadLine();
                        phnBook.DeleteContactByName(deleteContactByName);
                        break;

                    case "6":
                        Console.WriteLine("Contact Number:");
                        var deleteContact = Console.ReadLine();
                        phnBook.DeleteContactByNumber(deleteContact);
                        break;

                    case "7":
                        return;

                    default:
                        break;
                }
                Console.WriteLine("Select Operation:");
                userInput = Console.ReadLine();
            }
            

        }
    }
}

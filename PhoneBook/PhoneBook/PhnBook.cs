using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhnBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact> { };
        private void DisplayContactDetail(Contact contact)
        {
            Console.WriteLine($"Name: {contact.Name},Number: { contact.Number}");
        }
        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetail(contact);
            }
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact); 
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetail(contact);
            }
        }
        public void ViewAllContact()
        {
            DisplayContactDetails(_contacts);
        }
        public void DisplayMatchingContact(string searchPhrase)
        {
            var matchingContact = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            if (matchingContact == null)
            {
                Console.WriteLine("No Contact Matched.");
            }
            else
            {
                DisplayContactDetails(matchingContact);
            }
            
        }
        public void DeleteContactByName(string deleteContactByName)
        {
            
            var contact = _contacts.FirstOrDefault(c => c.Name == deleteContactByName);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                _contacts.Remove(contact);
                Console.WriteLine("Contact deleted");
            }
            
        }
        public void DeleteContactByNumber(string deleteContactByNumber)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == deleteContactByNumber);
            if (contact == null)
            {
                Console.WriteLine("No Contact Found");
            }
            else
            {
                _contacts.Remove(contact);
                Console.WriteLine("Contact deleted");
            }
        }
    }
}

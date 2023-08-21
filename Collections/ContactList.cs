using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Collections
{
    public class ContactList : Contact
    {
        public ContactList(string firstName, string lastName, string phoneNumber, string emailAddress, List<Contact> list) : base(firstName, lastName, phoneNumber, emailAddress)
        {
            List = list;
        }
                                                                                            
        public ContactList() { }


        public List<Contact> List { get; set; }

        public void Add(Contact contact)
        { 
            List.Add(contact); 
        }

        public void Remove(Contact contact)
        {
            List.Remove(contact);
        }

        public Contact? Search(string query)
        {
            if((List.FirstOrDefault(contact => contact.FirstName == query) is null) == true)
            {
                return List.FirstOrDefault(contact => contact.FirstName == query);
            }
            else if ((List.FirstOrDefault(contact => contact.LastName == query) is null) == true)
            {
                return List.FirstOrDefault(contact => contact.LastName == query);
            }
            else if ((List.FirstOrDefault(contact => contact.EmailAddress == query) is null) == true)
            {
                return List.FirstOrDefault(contact => contact.EmailAddress == query);
            }

            return null;
        }

        public override string ToString()
        {
            return $"\nFirstm name: {FirstName}" +
                $"\nLast name: {LastName}" +
                $"\nPhone number: {PhoneNumber}" +
                $"\nEmail address: {EmailAddress}\n";
        }
    }
}

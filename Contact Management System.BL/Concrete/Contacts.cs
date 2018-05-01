

using Contact_Management_System.BL.Interfaces;
using Contact_Management_System.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contact_Management_System.BL.Concrete
{
    public class Contacts : Base, IContacts
    {
        public void AddContact(Contact contact)
        {
            {
                db.Contacts.Add(new Contact
                {
                    Title = contact.Title,
                    CellNumber = contact.CellNumber,
                    Email = contact.Email,
                    Name = contact.Name,
                    Surname = contact.Surname,
                    Telephone = contact.Telephone,
                    ContactID = contact.ContactID

                });
                db.SaveChanges();
            }

        }





        //Returns all Contacts
        public List<Contact> GetAllContacts()
        {
            return db.Contacts.ToList();
        }
    }
}


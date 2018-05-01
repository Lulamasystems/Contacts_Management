

using Contact_Management_System.BL.Interfaces;
using Contact_Management_System.DAL.DTOs;
using Contact_Management_System.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contact_Management_System.BL.Concrete
{
    public class Contacts : Base, IContacts
    {
        //public void CreateUser(UserProfileDTO UserProfile)
        public void AddContact(ContactsDTO contact)
        {
            db.Contacts.Add(new Contact
            {

                // Contacts =ContactDTO.UserProfileDTOId,
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

        public void DeleteContact(int ContactID)
        {


            var contact = db.Contacts.Find(ContactID);

            db.Entry(contact).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }


        public List<Contact> GetAllContacts()
        {
            return db.Contacts.ToList();
        }

        public void UpdateContact(int ID)
        {
            throw new System.NotImplementedException();
        }
    }
}

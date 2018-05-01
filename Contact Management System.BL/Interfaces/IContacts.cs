using Contact_Management_System.DAL.DTOs;
using Contact_Management_System.DAL.Models;
using System.Collections.Generic;

namespace Contact_Management_System.BL.Interfaces
{
    public interface IContacts
    {
        void AddContact(ContactsDTO contactsDTO);
        List<Contact> GetAllContacts();
        void DeleteContact(int ContactID);
        void UpdateContact(int ContactID);


    }
}

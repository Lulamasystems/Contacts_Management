

﻿using Contact_Management_System.BL.Interfaces;
using Contact_Management_System.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contact_Management_System.BL.Concrete
{
    public class Contacts : Base, IContacts
    {
        public void AddContact(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        //Returns all Contacts
        public List<Contact> GetAllContacts()
        {
            return db.Contacts.ToList();
        }
    }
}


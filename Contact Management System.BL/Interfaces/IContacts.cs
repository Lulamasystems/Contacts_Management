using Contact_Management_System.DAL.Models;
using System.Collections.Generic;

namespace Contact_Management_System.BL.Interfaces
{
    public interface IContacts
    {
        List<Contact> GetAllContacts();
    }
}

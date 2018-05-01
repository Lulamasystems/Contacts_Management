using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Management_System.DAL.DTOs
{
   public  class ContactsDTO
    {
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string Telephone { get; set; }
    }

}

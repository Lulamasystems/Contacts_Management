using Contact_Management_System.BL.Concrete;
using Contact_Management_System.DAL.DTOs;
using System.Collections;

using System.Web.Http;

namespace Contact_Management_System.API.Controllers
{


    [RoutePrefix("api/Contacts")]
    public class ContactsController : ApiController
    {
        BL.Concrete.Contacts con = new BL.Concrete.Contacts();

        [Route("GetContacts")]
        [HttpGet]
        public IEnumerable GetContacts()
        {

            var contactList = new Contacts();
            var asaas = contactList.GetAllContacts();
            return asaas;
        }

        [HttpPost]

        // POST: api/User
        public IHttpActionResult AddContact(ContactsDTO contactDTO)
        {
            con.AddContact(contactDTO);
            return Ok();
        }
    }
    }


using Contact_Management_System.BL.Concrete;
using System.Collections;

using System.Web.Http;

namespace Contact_Management_System.API.Controllers
{


    [RoutePrefix("api/Contacts")]
    public class ContactsController : ApiController
    {


        [Route("GetContacts")]
        [HttpGet]
        public IEnumerable GetContacts()
        {

            var contactList = new Contacts();
            var asaas = contactList.GetAllContacts();
            return asaas;
        }


    }
}


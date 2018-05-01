using Contact_Management_System.DAL.DTOs;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;


namespace Contact_Management_System.API.Controllers
{


    [RoutePrefix("api/Contacts")]
    public class ContactsController : ApiController
    {
        BL.Concrete.Contacts con = new BL.Concrete.Contacts();

        [Route("GetContacts")]
        [HttpGet]
        public HttpResponseMessage GetContacts()
        {


            var data = con.GetAllContacts();
            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(data).ToString(), Encoding.UTF8, "application/json")
            };


        }




        [Route("AddContact")]
        [HttpPost]

        // POST: api/User
        public IHttpActionResult AddContact(ContactsDTO contactDTO)
        {
            con.AddContact(contactDTO);
            return Ok("Successful");
        }


        [Route("DeleteContact")]
        [HttpPost]

        // POST: api/User
        public IHttpActionResult Delete(int id)
        {
            con.DeleteContact(id);
            return Ok("Successfully deleted");
        }






    }
}


using System.Web.Mvc;

namespace Contact_Management_System.Web.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult AddContact()
        {
            return View();
        }

        public ActionResult ListContacts()
        {
            return View();
        }
    }
}
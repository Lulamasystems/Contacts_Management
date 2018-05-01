using Contact_Management_System.BL.Concrete;
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

        public JsonResult List()

        {

            var db = new Contacts();
            return Json(db.GetAllContacts(), JsonRequestBehavior.AllowGet);
        }




        [HttpPost]

        // POST: api/User
        public ActionResult Delete(int id)
        {
            var con = new Contacts();
            con.DeleteContact(id);


            return View("ListContacts");
        }
    }
}
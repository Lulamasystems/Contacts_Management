using Contact_Management_System.BL.Concrete;
using Contact_Management_System.DAL.Models;
using System.Data.Entity;
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


        [HttpGet]
        public JsonResult GetContactById(int id)
        {
            var context = new ACMEDb();
            var user = context.Contacts.Find(id);
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public string Update(Contact contact)
        {
            var db = new ACMEDb();
            db.Entry(contact).State = EntityState.Modified;
            db.SaveChanges();

            return "Update Sucessful";
        }

        // POST: api/User
        public ActionResult Delete(int id)
        {
            var con = new Contacts();
            con.DeleteContact(id);


            return View("ListContacts");
        }
    }
}
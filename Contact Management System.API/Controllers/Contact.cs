using Contact_Management_System.BL.Concrete;
using Contact_Management_System.DAL.DTOs;
using Contact_Management_System.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Contact_Management_System.API
{
    public class Contact : Base
    {



        BL.Concrete.Contacts con =new BL.Concrete.Contacts();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }
        

        [HttpPost]
 
        // POST: api/User
        public IHttpActionResult AddContact(ContactsDTO contactDTO)
        {
            con.AddContact(contactDTO);
            return Ok();
        }


        

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
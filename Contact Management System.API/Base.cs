using Contact_Management_System.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contact_Management_System.API
{
    public class Base : System.Web.Http.ApiController
    {
       
            public ACMEDb db = new ACMEDb();
        
    }
}


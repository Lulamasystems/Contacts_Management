using System.Collections.Generic;
using Contact_Management_System.BL.Interfaces;
using Contact_Management_System.DAL.Models;

namespace Contact_Management_System.BL.Concrete
{
    public class Contacts : IContacts
    {
        public void AddContact(Contact contact)
        {
            using (var db = new AssetManagementSystemEntities())
//        {
//            //var ComputerType = db.ComputerTypes.Find(ComputerDTO.AssetTypeId);


                //            db.AssetsRegister.Add(new AssetsRegister
                //            {
                //                // ID = AssetsRegister.ID,
                //                Brand = AssetsRegister.Brand,
                //                Description = AssetsRegister.Description,
                //                Supplier = AssetsRegister.Supplier,
                //                SerialNumber = AssetsRegister.SerialNumber,
                //                AssetType = AssetsRegister.AssetType,
                //                isAllocated = AssetsRegister.isAllocated,
                //                ComputerType = AssetsRegister.ComputerType


                //            });
                //            db.SaveChanges();
                //        }




        }


        public List<Contact> GetAllContacts()
        {
            throw new System.NotImplementedException();
        }
    }
}


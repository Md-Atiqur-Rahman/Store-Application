using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceEmp.Model
{
    public class Customer
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public string Addresss { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Country { get; set; }
        public int phone_Number { get; set; }
        public string Email { get; set; }

        
    }
}
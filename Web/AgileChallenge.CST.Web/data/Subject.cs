﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgileChallenge.CST.Web.data
{
    public class Subject
    {
        [Key]
        public int ContactId { get; set; }
        [Required(ErrorMessage = "First Name is a required field.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is a required field.")]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
   
    }


}

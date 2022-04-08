using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Property
    {
        public int action { get; set; }
        public int id { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        public string name { get; set; }
        [Required(ErrorMessage ="This field is mandatory")]
        public string email { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        public string password { get; set; }
        public string dob { get; set; }
        public DataTable dt { get; set; }
       
    }
}
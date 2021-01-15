using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AsignmentWCF.Models
{
    [DataContract]
    public class StudentClient
    {
        
        public int Id { get; set; }
       
        public string RoleNumber { get; set; }

        public string Name { get; set; }

        public string Birthday { get; set; }
       
        public string Genre { get; set; }

        public string Email { get; set; }

        public string Introduction { get; set; }

        
    }
}
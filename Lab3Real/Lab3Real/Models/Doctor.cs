using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3Real.Models
{
    public class Doctor
    {
        public Doctor() { 
        patients=new List<Patient>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Patient>patients { get; set; }
        public virtual  Hospital Hospital{ get; set; }
    }
}
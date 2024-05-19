using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3Real.Models
{
    public class Patient
    {
        public Patient()
        {
            doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Кодот на пациентот треба да биде цел број составен од точно 5 цифри.")]
        [Display(Name = "Kod Na Pacient")]
        public int PatientCode { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Doctor> doctors { get; set; }

    }
}
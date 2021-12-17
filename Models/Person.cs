using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1721050358.Models
{
 
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Display(Name ="Tên")]
        public string PersonName { get; set; }
    }
}
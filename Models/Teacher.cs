using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1721050358.Models
{
 
    public class Teacher : Person
    {
        
        [Display(Name ="Mã Giáo viên")]
        public int TeacherId { get; set; }

        [Display(Name ="Địa Chỉ")]
        public string DiaChi { get; set; }
    }
}
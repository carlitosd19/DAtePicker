using System;
using System.ComponentModel.DataAnnotations;

namespace DAtePicker.Models
{
    public class Person
    {
        
        public int ID { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public string Name { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniversityApp.Data.Entites
{
    internal class Student
    {
        public int Id { get; set; }
        [Required]
        //[MaxLength(40)]
        [StringLength(maximumLength:40)]
        public string FullName { get; set; }
        public int GroupId { get; set; }
        public DateTime BirthDate { get; set; }

        public Group Group { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [StringLength(50)]
        public string TeacherUsername { get; set; }
        public string TeacherPassword { get; set; }
        public string TeacherFullname { get; set; }
        public string TeacherBirthdate { get; set; }
        public string TeacherGender { get; set; }
        public int TeacherAge { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherNationality { get; set; }

        public int SubjectId { get; set; }
         

    }
}

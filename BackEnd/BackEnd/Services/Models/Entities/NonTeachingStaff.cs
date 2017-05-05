using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    class NonTeachingStaff
    {
        [Key]
        public int NonTeacherId { get; set; }
        [StringLength(50)]
        public string NonTeacherUsername { get; set; }
        public string NonTeacherPassword { get; set; }
        public string NonTeacherFullname { get; set; }
        public string NonTeacherBirthdate { get; set; }
        public string NonTeacherGender { get; set; }
        public int NonTeacherAge { get; set; }
        public string NonTeacherAddress { get; set; }
        public string NonTeacherNationality { get; set; }
    }
}

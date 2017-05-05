using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackEnd.Services.Models.Entities
{
   public class Students
    {
        [Key]
        public int StudentNo { get; set; }     
        [StringLength(50)]
        public string Fullname { get; set; }
        public gender Gender { get; set; }
        public string Birthdate { get; set; }
        public int Age  { get; set; }
        public string  Nationality { get; set; }
        public string Grade { get; set; }
        public string HomeAddress { get; set; }
        public string  City { get; set; }
        public int  ContactNo{ get; set; }
        public string  Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

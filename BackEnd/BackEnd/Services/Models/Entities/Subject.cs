using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackEnd.Services.Models.Entities
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public int SubjectCode { get; set; }

        public int SubjectDescription { get; set; }


        public int YearId { get; set; }


    }
}

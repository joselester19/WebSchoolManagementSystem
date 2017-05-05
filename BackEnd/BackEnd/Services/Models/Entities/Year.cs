using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class Year
    {
        [Key]
        public int YearId { get; set; }

        public Subject YearSub { get; set; }
        public Section YearSec { get; set; }
        public Students YearStudents { get; set; }



    }
}

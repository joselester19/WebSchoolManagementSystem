using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class Section
    {
        [Key]
        public int SecId { get; set; }

        [Required,StringLength(50)]
        public string SecName { get; set; }
        public Teacher SecAdviserId { get; set; }
        public Teacher SecTeachersId { get; set; }
        public Students SecStudentsId { get; set; }
        public Schedule SecSched { get; set; }

        public int YearId { get; set; }

    }
}

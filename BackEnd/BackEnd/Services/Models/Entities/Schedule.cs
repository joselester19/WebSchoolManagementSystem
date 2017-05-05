using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class Schedule
    {
        [Key]
        public int SchedId { get; set; }

        public DayOfWeek SchedDay { get; set; }


        [Required,StringLength(50)]
        public Subject SchedSub { get; set; }
        public string SchedTime { get; set; }
        public Teacher SchedTeacher { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BackEnd.Services.Models
{
    public class SchoolEntities : DbContext
    {
        public SchoolEntities() : base("High5School") { }
        public IDbSet<Entities.Admin> admin { get; set; }
        public IDbSet<Entities.Teacher> teachers { get; set; }
        public IDbSet<Entities.Students> student { get; set; }
        //public IDbSet<Entities.Year> year { get; set; }
        public IDbSet<Entities.Subject> subjects { get; set; }
        public IDbSet<Entities.Section> section { get; set; }
        public IDbSet<Entities.Schedule> schedule { get; set; }


    }
}

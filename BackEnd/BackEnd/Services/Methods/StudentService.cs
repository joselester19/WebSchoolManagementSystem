using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BackEnd.Services.Methods
{
   public class StudentService
    {
        private readonly Models.SchoolEntities database;
        public StudentService()
        {
            database = new Models.SchoolEntities();
        }
        public void AddStudent(Services.Models.Entities.Students sInfo)
        {

            database.student.Add(sInfo);
            database.SaveChanges();
        }

    }
}

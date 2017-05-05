using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Services.Models.Entities;


namespace BackEnd.Services.Methods
{
    public class FirstYearService
    {
        private readonly Models.SchoolEntities schooldb;
        public FirstYearService()
        {
            schooldb = new Models.SchoolEntities();
        }


        //list down first year

        public List<Subject> ViewSubjects() {
            return schooldb.subjects.Where(u => u.YearId.Equals(1)).ToList();
        }
        public List<Section> ViewSection()
        {
            return schooldb.section.Where(u => u.YearId.Equals(1)).ToList();
        }


        //adding
        public void AddSubject(Subject sub) {

            schooldb.subjects.Add(sub);

            schooldb.SaveChanges();
        }


    }
}

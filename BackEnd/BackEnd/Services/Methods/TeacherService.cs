using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Services.Models.Entities;
namespace BackEnd.Services.Methods
{
    public class TeacherService
    {
        private readonly Models.SchoolEntities database;
        public TeacherService()
        {
            database = new Models.SchoolEntities();
        }

        public void AddTeacher(Teacher tInfo)
        {
            database.teachers.Add(tInfo);
            database.SaveChanges();
        }
        public Teacher get(int xid) {

                return database.teachers.Where(u => u.TeacherId.Equals(xid)).FirstOrDefault();
        }

        public void Save(Teacher teach) {
          
                Teacher te = database.teachers.SingleOrDefault(tea => tea.TeacherId == teach.TeacherId);
                te.TeacherFullname = teach.TeacherFullname;
                te.TeacherAddress = teach.TeacherAddress;
                te.TeacherBirthdate = teach.TeacherBirthdate;
                te.TeacherFullname = teach.TeacherFullname;
                te.TeacherFullname = teach.TeacherFullname;
                te.TeacherFullname = teach.TeacherFullname;
            database.SaveChanges();
           
        }

        //public Teacher Update(int id) {
        //    return database.Users.Where(u => u.EmailAddress.Equals(emailAddress, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

        //    return database.teacher.Where(m => models.TeacherId.Equals(id, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

        //}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Services.Models.Entities;

namespace BackEnd.Services.Methods
{
    public class AdminService
    {

        private readonly Models.SchoolEntities schooldb;
        public AdminService()
        {
            schooldb = new Models.SchoolEntities();
        }

        public void AddTeacher(Teacher xteacher)
        {
            schooldb.teachers.Add(xteacher);
            schooldb.SaveChanges();
        }
        public void AddStudents(Students xstudents)
        {
            schooldb.student.Add(xstudents);
            schooldb.SaveChanges();
        }
        public void AddSubjects(Subject xsubject)
        {
            schooldb.subjects.Add(xsubject);
            schooldb.SaveChanges();
        }
        public void AddSection(Section xsection)
        {
            schooldb.section.Add(xsection);
            schooldb.SaveChanges();
        }
        public void CreateSchedule(Schedule xsched)
        {
            schooldb.schedule.Add(xsched);
            schooldb.SaveChanges();
        }

        //Get subject
        public Subject getSubId(int SId)
        {
            return schooldb.subjects.Where(u => u.SubjectId.Equals(SId)).FirstOrDefault();
        }
        //Get Teacher
        public Teacher getTeacherID(int TId)
        {
            return schooldb.teachers.Where(t => t.TeacherId.Equals(TId)).FirstOrDefault();
        }

        //Edit
        public void EditTeacher(Teacher teach)
        {
            Teacher te = schooldb.teachers.SingleOrDefault(tea => tea.TeacherId == teach.TeacherId);
            te.TeacherFullname = teach.TeacherFullname;
            te.TeacherAddress = teach.TeacherAddress;
            te.TeacherBirthdate = teach.TeacherBirthdate;
            te.TeacherAge = teach.TeacherAge;
            te.TeacherNationality = teach.TeacherNationality;
            te.TeacherPassword = teach.TeacherPassword;
            te.TeacherUsername = teach.TeacherUsername;

            schooldb.SaveChanges();
        }
        public void EditStudents(Students EditStud)
        {
            Students stud = schooldb.student.SingleOrDefault(model => model.StudentNo == EditStud.StudentNo);
            stud.Fullname = EditStud.Fullname;
            stud.Gender = EditStud.Gender;
            stud.Birthdate = EditStud.Birthdate;
            stud.Age = EditStud.Age;
            stud.Nationality = EditStud.Nationality;
            stud.Grade = EditStud.Grade;
            stud.HomeAddress = EditStud.HomeAddress;
            stud.City = EditStud.City;
            stud.ContactNo = EditStud.ContactNo;
            stud.Email = EditStud.Email;
            schooldb.SaveChanges();
        }


        //list of all the content of FirsYear
    }
}

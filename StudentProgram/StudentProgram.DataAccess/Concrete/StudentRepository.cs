using StudentProgram.DataAccess.Abstract;
using StudentProgram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentProgram.DataAccess.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        public Student CreateStudent(Student student)
        {
            using(var studentDbContext = new StudentDbContext())
            {
                studentDbContext.Students.Add(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }

        public void DeleteStudent(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                var deletedStudent = GetStudentById(id);
                studentDbContext.Students.Remove(deletedStudent);
                studentDbContext.SaveChanges();
            }
        }

        public List<Student> GetAllStudent()
        {
            using (var studentDbContext = new StudentDbContext())
            {
                return studentDbContext.Students.ToList();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                return studentDbContext.Students.Find(id);
            }
        }

        public Student UpdateStudent(Student student)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                studentDbContext.Students.Update(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }
    }
}

using StudentProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProgram.DataAccess.Abstract
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();

        Student GetStudentById(int id);

        Student CreateStudent(Student student);

        Student UpdateStudent(Student student);

        void DeleteStudent(int id);
    }
}

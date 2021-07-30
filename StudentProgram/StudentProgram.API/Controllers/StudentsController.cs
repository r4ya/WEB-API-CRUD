using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProgram.Business.Abstract;
using StudentProgram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProgram.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.GetAllStudent();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentService.GetStudentById(id);
        }

        [HttpPost]
        public Student Post([FromBody] Student student)
        {
            return _studentService.CreateStudent(student);
        }

        [HttpPut]
        public Student Put([FromBody] Student student)
        {
            return _studentService.UpdateStudent(student);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.DeleteStudent(id);
        }
    }
}

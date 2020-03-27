using System;
using System.Collections.Generic;
using System.Linq;
using Tutorial_3.Models;
using Tutorial_3.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial_3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            this._dbService = dbService;
        }

      
        [HttpGet]
        public IActionResult GetStudents(string orderBy) //action method
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) 
        {
            if (id == 1)
            {
                return Ok("Jan");
            }
            else if (id == 2)
            {
                return Ok("Katarzyna");
            }

            return NotFound("Student was not found");
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        

    }
}
using Tutorial_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_3.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
        public IEnumerable<Student> GetStudent();
    }
}

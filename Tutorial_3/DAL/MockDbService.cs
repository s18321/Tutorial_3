using Tutorial_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_3.Services
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski", IndexNumber="s1234"},
                new Student{IdStudent=2, FirstName="Anna", LastName="Malewska", IndexNumber="s3446"},
                new Student{IdStudent=3, FirstName="Malewska", LastName="Andrzejewicz", IndexNumber="s5644"}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
        
        
        
    }
}
using Lab.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Repository.DBContext
{
    public class Student_Repository : IStudentRepository
    {
        static int Count = 1;
        private List<Student> _students;

        public Student_Repository()
        {
            
            _students = new List<Student>();
        }

        public void Created(Student student)
        {
            _students.Add(student);
            student.Id = Count;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int studentId)
        {
            return _students.FirstOrDefault(s => s.Id == studentId);
        }
    }
}

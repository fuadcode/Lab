using Lab.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Service.Interfaces
{
    public interface IStudent
    {
        Student GetStudentById(int studentId);
        void CreatedStudent(Student student);
        List<Student> GetAllStudents();
    }
}

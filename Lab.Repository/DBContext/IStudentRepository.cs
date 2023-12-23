using Lab.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Repository.DBContext
{
    public interface IStudentRepository
    {
        Student GetById(int studentId);
        void Created(Student student);
        List<Student> GetAll();
    }
}

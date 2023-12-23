using Lab.Domain.Common;
using Lab.Domain.Models;
using Lab.Repository.DBContext;
using Lab.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Service
{
    public class StudentService : IStudent
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void CreatedStudent(Student student)
        {
            _studentRepository.Created(student);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();

        }

        public Student GetStudentById(int studentId)
        {
            return _studentRepository.GetById(studentId);
        }
    }
    }


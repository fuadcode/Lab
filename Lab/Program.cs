
using Lab.Domain.Models;
using Lab.Repository.DBContext;
using Lab.Service;
using Lab.Service.Interfaces;
using System.Security.Cryptography.X509Certificates;


IStudentRepository studentRepository = new Student_Repository();
IStudent studentService = new StudentService(studentRepository);
while (true)
{
    Console.WriteLine("1. Created Student");
    Console.WriteLine("2. Get Student by ID");
    Console.WriteLine("3. Get All Students");

    Console.Write("Enter your menu ");
    string menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            
            Student newStudent = new Student
            {
                Name = name,
                 
            };
           
            studentService.CreatedStudent(newStudent);
          
            Console.WriteLine("Student created.");
          
            break;
           
        case "2":
            Console.Write("Enter student ID : ");
            int getId = int.Parse(Console.ReadLine());
            Student studentById = studentService.GetStudentById(getId);
            if (studentById != null)
            {
                Console.WriteLine($"Student ID: {studentById.Id}, Name: {studentById.Name}");
            }
            else
            {
                Console.WriteLine("Student tapilmadi.");
            }
            break;

        case "3":
            var allStudents = studentService.GetAllStudents();
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
            break;

        case "0":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("sagol qaqa");
            break;
    }

    Console.WriteLine();
}
    
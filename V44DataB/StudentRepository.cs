using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V44DataB
{
    public class StudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public Student FindStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s=>s.Id==id);
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void UpdateFirstName(Student student, string newFirstName)
        {
            if (!string.IsNullOrEmpty(newFirstName))
            {
                student.FirstName = newFirstName;
                _context.SaveChanges();
            }
        }
        public void UpdateLastName(Student student, string newLastName)
        {
            if (!string.IsNullOrEmpty(newLastName))
            {
                student.LastName = newLastName;
                _context.SaveChanges();
            }
        }
        public void UpdateCity(Student student, string newCity)
        {
            if (!string.IsNullOrEmpty(newCity))
            {
                student.City = newCity;
                _context.SaveChanges();
            }
        }

    }
}

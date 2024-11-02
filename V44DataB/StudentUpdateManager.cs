using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V44DataB
{
    public class StudentUpdateManager
    {
        private readonly StudentRepository _repository;

        public StudentUpdateManager(StudentRepository repository)
        {
            _repository = repository;
        }
        private void UpdateStudent(Student studentToUpdate)
        {
            UpdateStudentFields(studentToUpdate);
            _repository.UpdateStudent(studentToUpdate);
            Console.WriteLine($"Studenten {studentToUpdate.FirstName} {studentToUpdate.LastName} har uppdaterats.");
            MenuManager.BackToMenu();

        }
        private void UpdateStudentFields(Student student)
        {
            UpdateFirstName(student);
            UpdateLastName(student);
            UpdateCity(student);

        }
        private void UpdateFirstName(Student student)
        {
            Console.WriteLine($"Nuvarande förnamn: {student.FirstName}");
            string firstname = InputHelper.GetUserInput("Nytt förnamn: (lämna fältet tomt för att behålla)");
            _repository.UpdateFirstName(student, firstname);
        }
        private void UpdateLastName(Student student)
        {
            Console.WriteLine($"Nuvarande förnamn: {student.LastName}");
            string lastname = InputHelper.GetUserInput("Nytt efternamn: (lämna fältet tomt för att behålla)");
            _repository.UpdateLastName(student, lastname);
        }
        private void UpdateCity(Student student)
        {
            Console.WriteLine($"Nuvarande stad: {student.City}");
            string city = InputHelper.GetUserInput("Ny stad: (lämna fältet tomt för att behålla)");
            _repository.UpdateCity(student, city);
        }
        public void ListAndChooseStudentToUpdate()
        {
            ListStudents();
            Console.WriteLine("Ange Student ID för att völja vilken student att uppdatera: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                var selectedStudent = _repository.GetAllStudents().FirstOrDefault(s => s.Id == studentId);
                if (selectedStudent != null)
                {
                    UpdateStudent(selectedStudent);
                }
                else
                {
                    Console.WriteLine("Ingen student hittades med det angiva ID:t.");
                }

            }
            else
            {
                Console.WriteLine("Ogiligt ID, försök igen");
            }
        }
        public void ListStudents()
        {
            var students = _repository.GetAllStudents();
            Console.WriteLine("\nLista över alla studenter:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}  Namn: {student.FirstName}  Efternamn: {student.LastName}  Stad: {student.City}");
            }
        }
    }
}

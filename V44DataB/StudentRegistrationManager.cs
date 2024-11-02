using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V44DataB
{
    public  class StudentRegistrationManager
    {
        private readonly StudentRepository _repository;

        public StudentRegistrationManager(StudentRepository repository)
        {
            _repository = repository;
        }

        public void RegisterNewStudent()
        {
            Console.WriteLine("\nRegistrera ny student");
            string firstname = InputHelper.GetUserInput("\nFörnamn");
            string lastname = InputHelper.GetUserInput("Efternamn");
            string city = InputHelper.GetUserInput("Stad");

            var student = new Student();
            {
                student.FirstName = firstname;
                student.LastName = lastname;
                student.City = city;
            }
            _repository.AddStudent(student);
            Console.WriteLine("Studenten är registrerad.");

            MenuManager.BackToMenu();
        }

    }
}

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V44DataB
{
    public class MenuManager
    {
        private readonly StudentRepository _repository;
         private readonly StudentRegistrationManager _registrationManager;
        private readonly StudentUpdateManager _updateManager;
        public MenuManager(StudentRepository repository)
        {
            _repository = repository;
            _registrationManager = new StudentRegistrationManager(repository);
            _updateManager = new StudentUpdateManager(repository);
        }
        public void ShowMenu()
        {
            bool exit=false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\nVälj ett alternativ");
                Console.WriteLine("1. Registrera ny student");
                Console.WriteLine("2. Ändra en student");
                Console.WriteLine("3. Lista alla studenter");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("Ditt val:");
                string choice = Console.ReadLine();
                exit = HandleMenuChoice(choice);
            }
            
        }
        
        private bool HandleMenuChoice(string choice)
        {
           Console.Clear();
            switch (choice)
            {
                case "1":
                    _registrationManager.RegisterNewStudent();
                    
                    return false;
                    case "2":
                    _updateManager.ListAndChooseStudentToUpdate();
                    return false;
                    case "3":
                    _updateManager.ListStudents();
                    BackToMenu();
                    return false;
                    case "4":
                    Console.WriteLine("Avslutar programmet");
                    return true;
                default:
                    Console.WriteLine("Ogiltigt val");
                    return false;
            }
 
        }

        public static void BackToMenu()
        {
            Console.WriteLine("Tryck på Enter för att återgå till menyn...");
            Console.ReadLine();
        }
    }
}

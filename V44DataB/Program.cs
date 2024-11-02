using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace V44DataB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                var repository = new StudentRepository(context); // Skapa repository
                var menuManager = new MenuManager(repository); // Skicka repository till MenuManager
                menuManager.ShowMenu();
            }

            // Data Source = KATARINA\SQL24; Initial Catalog = V44; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False
            //var dBContext=new StudentDbContext();
            // dBContext.Add();
            // dBContext.SaveChanges();
        }
    }
}

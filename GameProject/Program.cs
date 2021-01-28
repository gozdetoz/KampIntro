using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add
                (new Gamer  
                { Id = 1 , 
                  BirthYear = 1993,
                  FirstName = "GÖZDE",
                  LastName = "TOZ",
                  IdentityNumber = 12345678901 
                }
                );
            Console.WriteLine("Hello World!");
        }
    }
}

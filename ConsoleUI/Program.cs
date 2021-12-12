using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalUserTest();


        }

        private static void NormalUserTest()
        {
            NormalUserManager normalUserManager = new NormalUserManager(new EfNormalUserDal());

            foreach (var user in normalUserManager.GetAllByHomeId(2))
            {
                Console.Write(user.UserId + " ");
                Console.Write(user.Email + " ");
                Console.Write(user.Name + "\n");
            }

            Console.WriteLine("Hello World!");
        }
    }
}

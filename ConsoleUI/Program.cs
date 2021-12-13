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
            //NormalUserTest();
            //MainDeviceTest();
            UserHomeTest();

        }

        private static void UserHomeTest()
        {
            UserHomeManager uhm = new UserHomeManager(new EfUserHomeDal());

            var result = uhm.GetAll();

            if (result.Success)
            {
                foreach (var userHome in result.Data)
                {
                    Console.Write(userHome.UserId + " ");
                    Console.Write(userHome.HomeId + "\n");
                    Console.WriteLine("**********************************");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            foreach (var userHome in uhm.GetAllByHomeId(1).Data)
            {
                Console.Write(userHome.UserId + " ");
                Console.Write(userHome.HomeId + "\n");
                Console.WriteLine("----------------------------------");
            }
            foreach (var userHome in uhm.GetAllByUserId(1).Data)
            {
                Console.Write(userHome.UserId + " ");
                Console.Write(userHome.HomeId + "\n");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            foreach (var userHome in uhm.GetUserHomeName().Data)
            {
                Console.Write(userHome.Name + " ");
                Console.Write(userHome.StructureName + "\n");
            }
        }

        private static void MainDeviceTest()
        {
            MainDeviceManager ma = new MainDeviceManager(new EfMainDeviceDal());
            foreach (var device in ma.GetAll())
            {
                Console.Write(device.DeviceName + " ");
                Console.Write(device.DeviceProps + " ");
                Console.Write(device.UserId + " ");
                Console.Write(device.HomeId + "\n");
            }
        }

        private static void NormalUserTest()
        {
            NormalUserManager normalUserManager = new NormalUserManager(new EfNormalUserDal());

            foreach (var user in normalUserManager.GetAll())
            {
                Console.Write(user.UserId + " ");
                Console.Write(user.Email + " ");
                Console.Write(user.Name + "\n");
            }

            Console.WriteLine("Hello World!");
        }
    }
}

using Data;
using System;

namespace consoleMain
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalInfoRepo personalInfoRepo = new PersonalInfoRepo();
            personalInfoRepo.Create();
            personalInfoRepo.PrintData();
            Console.ReadKey();
        }
    }
}

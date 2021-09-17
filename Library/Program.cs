using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student 
            {
                Id = 1, GivenName = "Hey", Surname = "Yo", StartDate = new DateTime(2020, 08, 24), GraduationDate = new DateTime(2023, 07, 31), EndDate = new DateTime(2023, 07, 31)
            };

            Console.WriteLine(s.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReflection.Models
{
    public class User
    {


        private int Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private static int Age { get; set; }



        public void GetFullName()
        {
            Console.WriteLine(Name + " " + Surname);
        }


        public static void ChangeAge(int age)
        {
            Console.WriteLine(Age = age);

        }
    }
}

using System.Reflection;
using TaskReflection.Models;

namespace TaskReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(User);


            User person = new User();
            PropertyInfo propId = type.GetProperty("Id", BindingFlags.Instance | BindingFlags.NonPublic);
            propId.SetValue(person, 4);
            Console.WriteLine(propId.GetValue(person));


            PropertyInfo propName = type.GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic);
            propName.SetValue(person, "Murad");
            Console.WriteLine(propName.GetValue(person));

            PropertyInfo propSurname = type.GetProperty("Surname", BindingFlags.Instance | BindingFlags.NonPublic);
            propSurname.SetValue(person, "Eliyev");
            Console.WriteLine(propSurname.GetValue(person));


            PropertyInfo propAge = type.GetProperty("Age", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
            propAge.SetValue(person, 21);
            Console.WriteLine(propAge.GetValue(person));

            Console.WriteLine("=====================================");




            MethodInfo methodGetFullName = type.GetMethod("GetFullName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            methodGetFullName.Invoke(person, null);




            MethodInfo methodChangeAge = type.GetMethod("ChangeAge", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            methodChangeAge.Invoke(person, new object[] { 30 });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihaninheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alan", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Galang", 33, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Linda", 19, "10506", "sara123@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}

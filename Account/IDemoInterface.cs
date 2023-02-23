using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public interface IDemoInterface
    {
     
        static int age;
        void Method()
        {
            Console.WriteLine("This a method with body brom interface");
        }
    }

    public abstract class Person
    {
        static int age;
        public Person()
        {
            age = 1;
        }
        public void PersonMethod()
        {
            Console.WriteLine("Hi, I am a person");
        }
    }
    public class Student : Person, IDemoInterface
    {
        Person person;
        public Student() : base()
        {
            
            person = new Student();
        }

        public void Method()
        {
            // Some work
        }
    }
}

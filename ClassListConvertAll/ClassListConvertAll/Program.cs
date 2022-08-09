using System;
using System.Collections.Generic;

namespace ClassListConvertAll
{
    class Program
    {

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class InternalStudent
        {
            public string IName { get; set; }
            public int IAge { get; set; }
        }


        static void Main(string[] args)
        {

            List<InternalStudent> lstInternalStudent = new List<InternalStudent>
            { 
                new InternalStudent
                {
                    IName = "Studante1", IAge = 20
                },
                new InternalStudent
                {
                    IName = "Studante2", IAge = 25
                },
                new InternalStudent
                {
                    IName = "Studante3", IAge = 35
                }
            };

            List<Student> listStudent = lstInternalStudent
                .ConvertAll(x => new Student { Age = x.IAge, Name = x.IName });

            foreach(var i in listStudent)
            {
                Console.WriteLine($"Idade: {i.Age}, Nome: {i.Name}");

            }

        }


    }
}

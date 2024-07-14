using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id , string name , int aga )
            
        {
           this.Id = id;
            this.Name = name;
            this.Age = aga;
        }
        static Student()
        {
            Console.WriteLine("hello");
        }

        public void GetData()
        {
            Console.WriteLine($"Name: {Name}  ID: {Id}  Age: {Age}");

        }
        

        public bool IsGrauate(int age)
        {
            if( age >= 24 )
                return true;
            else return false;
        }










    }
}

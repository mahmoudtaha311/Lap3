using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lap3
{
    internal class Book
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }
        public DateTime  CreateOn {  get; set; }
        static int count = 0;
        public bool isdeleted;

        public Book() : this(string.Empty, 100, DateTime.Now ,1000)
        {
            
        }
        public Book(string name)
        {
            this.Name = name;
        }
        public Book(string name, int id ) 
        {
            this.Name = name;
            this.ID = id;
        }
        public Book(string name , int id , DateTime dateTime) 
        { 
            this.Name=name;
            this.ID = id;
            this.CreateOn = dateTime;
        }
        public Book(string name, int id, DateTime dateTime,int price)
        {
            count++;
            this.Name = name;
            this.ID = id;
            this.CreateOn = dateTime;
            this.Price = price;
        }

        public int HowManyBookBuy()
        {
            Console.WriteLine(count);
            return count; 
        }
        public void GetData()
        {
            Console.WriteLine($"Name:{Name} ID: {ID} Price: {Price} CreateOn: {CreateOn}");
        }
        public void IsDeleted()
            { Console.WriteLine(isdeleted ? "deleted" : "not deleted");
        
        
        
    }
}

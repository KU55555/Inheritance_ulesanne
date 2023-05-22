using System;

namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            Student emp = new Student();
            emp.Id = 11;
            emp.Name = "Name1";
            emp.Title = "Title1";
            emp.Description = "Description1";

            
            StudentDto dto = new StudentDto();

            
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title; 
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name);
            
        }
    }
    //Person class on tavaline class.
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //See pärib Person classist ja lisab juurde täiendavaid omadusi.
    
    public class Student : Person
    {
        public string Description { get; set; }
        public string Title { get; set; }
    }

    //see pärib Person classist ja lisab juurde täiendavaid omadusi.
    public class StudentDto : Person
    {
        public string Description { get; set; }
        public string Title { get; set; }
    }
}

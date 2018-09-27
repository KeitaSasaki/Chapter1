using System;

namespace Chapter1_3 //1.6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Id = 100,
                Name = "山田太郎",
                Birthday = new DateTime(1992, 4, 5),
                DivisionName = "第一営業課",
            };
            Console.WriteLine("{0}({1})は、{2}に所属しています。",employee.Name,employee.GetAge(),employee.DivisionName);

            Student student = new Student //追加問題
            {
                Name = "山田次郎",
                Birthday = new DateTime(1997, 08, 28),
                Grade = 4,
                Classnumber = "A",

            };
            Console.WriteLine("名前:{0}({1})は、{2}年{3}組です",student.Name,student.GetAge(),student.Grade,student.Classnumber);
            Action keep = () => Console.ReadLine(); Console.ReadKey();
            keep();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }
    }

    public class Employee : Person
    {
        public int Id { get; set; }
        public string DivisionName { get; set; }
    }

    public class Student : Person   //追加問題
    {
        public int Grade { get; set; }
        public string Classnumber { get; set; }
    }
}

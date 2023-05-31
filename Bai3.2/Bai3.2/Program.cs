using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._2
{
    public class Person
    {
        public void Greet()
        {
            Console.WriteLine("Xin chao.");
        }
        public int SetAge()
        {
            Console.Write("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Toi dang hoc.");
        }
        public void ShowAge(int age)
        {
            Console.WriteLine("Tuoi cua toi la: " + age + " tuoi");
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Toi dang giai thich.");
        }
    }
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Greet();
            Student b = new Student();
            b.Greet();
            b.ShowAge(b.SetAge());
            Teacher c = new Teacher();
            c.SetAge();
            c.Greet();
            c.Explain();
            Console.ReadKey();
        }
    }
}

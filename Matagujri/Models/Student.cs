using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matagujri.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
    }

    public static class StudentProvider
    {
        public static List<Student> GetStudentList()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentId = 1, Name = "Ankush", Email = "ankush1802@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 2, Name = "Pradeep", Email = "Pradeep@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 3, Name = "Lokesh", Email = "Lokesh@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 4, Name = "Naresh", Email = "Naresh@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 5, Name = "Manisha", Email = "Manisha@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 6, Name = "Lovely", Email = "Lovely@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 7, Name = "Manjot", Email = "Manjot@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 8, Name = "Abhishek", Email = "Abhishek@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 9, Name = "Himashu", Email = "Himashu@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 10, Name = "Gurpreet", Email = "Gurpreet@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 11, Name = "Hitesh", Email = "Hitesh@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 12, Name = "Manish", Email = "Manish@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 13, Name = "Jagjit", Email = "Jagjit@outlook.com", Address = "Fatehgarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 14, Name = "Jagpreet", Email = "Jagpreet@outlook.com", Address = "Sirhind", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 15, Name = "Jaspreet", Email = "Jaspreet@outlook.com", Address = "Sirhind", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 16, Name = "Jeevanjot", Email = "Jeevanjot@outlook.com", Address = "Sirhind", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 17, Name = "Berjinder", Email = "Berjinder@outlook.com", Address = "Sirhind", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 18, Name = "Sabrop", Email = "Sabrop@outlook.com", Address = "Sirhind", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 19, Name = "Gurchain", Email = "Gurchain@outlook.com", Address = "Sirhind", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 20, Name = "Amit", Email = "Amit@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 21, Name = "Rohit", Email = "Rohit@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 22, Name = "Rahul", Email = "Rahul@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 23, Name = "Rekha", Email = "Rekha@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 24, Name = "Mukesh", Email = "Mukesh@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 25, Name = "Yogesh", Email = "Yogesh@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 26, Name = "Navdeep", Email = "Navdeep@outlook.com", Address = "Patiala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 27, Name = "Tejinder", Email = "Tejinder@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 28, Name = "Pankaj", Email = "Pankaj@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 29, Name = "Manju", Email = "Manju@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 30, Name = "Pooja", Email = "Pooja@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 31, Name = "Neha", Email = "Neha@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 32, Name = "Peeti", Email = "Peeti@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 33, Name = "Jyoti", Email = "Jyoti@outlook.com", Address = "Rajpura", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 34, Name = "Sukhchain", Email = "Sukhchain@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 35, Name = "Sonia", Email = "Sonia@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 36, Name = "Prabhat", Email = "Prabhat@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 37, Name = "Anil", Email = "Anil@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 38, Name = "Shubham", Email = "Shubham@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 39, Name = "Sahil", Email = "Sahil@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 40, Name = "Amol", Email = "Amol@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 41, Name = "Vinay", Email = "Vinay@outlook.com", Address = "Ambala", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 42, Name = "Mandeep", Email = "Mandeep@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 45, Name = "Ajay", Email = "Ajay@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 46, Name = "Mohit", Email = "Mohit@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 47, Name = "Kalia", Email = "Kalia@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 48, Name = "Happy", Email = "Happy@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 49, Name = "Inderdeep", Email = "Inderdeep@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 50, Name = "Matt", Email = "Matt@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 51, Name = "Arjun", Email = "Arjun@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 52, Name = "Vijay", Email = "Vijay@outlook.com", Address = "Mohali", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 53, Name = "Kapil", Email = "Kapil@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 54, Name = "Prabhat", Email = "Prabhat@outlook.com", Address = "Chandigarh", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 55, Name = "Arun", Email = "Arun@outlook.com", Address = "Una", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 56, Name = "Swati", Email = "Swati@outlook.com", Address = "Una", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 57, Name = "Shivani", Email = "Shivani@outlook.com", Address = "Una", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 58, Name = "Suman", Email = "Suman@outlook.com", Address = "Una", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 59, Name = "Vivek", Email = "Vivek@outlook.com", Address = "Una", Mobile = "9041627385", Pincode = "160071" });
            students.Add(new Student { StudentId = 60, Name = "Varun", Email = "Varun@outlook.com", Address = "Una", Mobile = "9041627385", Pincode = "160071" });
            return students;
        }
    }
}
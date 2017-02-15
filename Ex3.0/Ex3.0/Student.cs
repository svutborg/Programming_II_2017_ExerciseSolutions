using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._0
{
    public class Student
    {
        static int studentCount = 0;
        public string FullName { get; private set; }
        public string Course { get; private set; }
        public string Subject { get; private set; }
        public string University { get; private set; }
        public string EMail { get; private set; }
        public string PhoneNumber { get; private set; }

        public Student(string fullName, string course, string subject, string university, string eMail, string phoneNumber)
        {
            FullName = fullName;
            Course = course;
            Subject = subject;
            University = university;
            EMail = eMail;
            PhoneNumber = phoneNumber;
            studentCount++;
        }
        public Student(string fullName, string university, string eMail, string phoneNumber) : this(fullName, null, null, university, eMail, phoneNumber) { }
        public Student(string fullName, string university, string eMail) : this(fullName, null, null, university, eMail, null) { }

        public void DisplayStudentInformation()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"University: {University}");
            Console.WriteLine($"E-mail: {EMail}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
        }
    }
}

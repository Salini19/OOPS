using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolData;

namespace SchlData.Test
{
    [TestFixture]
    public class StudentTest
    {
        StudentMethod method=new StudentMethod();
        [TestCase]
        public void AddNewStudentTest()
        {
            Student student = new Student();
            student.studid = "STUD-001";
            student.studName = "Prateek";
            student.@class = "5th B";
            bool flag = method.AddStudent(student);
            Assert.AreEqual(true, flag);
            Console.WriteLine("Student details added successfully...");
            Console.WriteLine("StudentID :" +student.studid);
            Console.WriteLine("StudentName :" + student.studName);
            Console.WriteLine("Class :" + student.@class);
        }

        [TestCase]
        public void DeleteStudentTest()
        {
            string student = "STUD-001";
            bool flag = method.RemoveStudent(student);
            Assert.AreEqual(true, flag);
            Console.WriteLine("Student details deleted successfully...");
        }

        [TestCase]
        public void UpdateStudentTest()
        {
            Student student = new Student();
            student.studid = "STUD-001";
            student.studName = "Prathipa";
            student.@class = "8th B";
            bool flag = method.UpdateStudent(student);
            Assert.AreEqual(true, flag);
            Console.WriteLine("Student details updated successfully...");
            Console.WriteLine("StudentID :" + student.studid);
            Console.WriteLine("StudentName :" + student.studName);
            Console.WriteLine("Class :" + student.@class);
        }
    }
}

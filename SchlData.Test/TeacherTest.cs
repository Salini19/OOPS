using NUnit.Framework;
using SchoolData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchlData.Test
{
    public class TeacherTest
    {
        TeacherMethod method = new TeacherMethod();
        [TestCase]
        public void AddNewTeacherTest()
        {
            Teacher teacher = new Teacher();
            teacher.Teacherid = "TEACH-001";
            teacher.Name = "Mr Sanjay";
            teacher.Qualification = "BSC";
            bool flag = method.AddTeacher(teacher);
            Assert.AreEqual(true, flag);
            Console.WriteLine("Teacher details added successfully...");
            Console.WriteLine("TeacherID :" + teacher.Teacherid);
            Console.WriteLine("TeacherName :" + teacher.Name);
            Console.WriteLine("Qualtification :" + teacher.Qualification);

        }

        [TestCase]
        public void DeleteTeacherTest()
        {
            string teacher = "TEACH-001";
            bool flag = method.RemoveTeacher(teacher);
            Assert.AreEqual(true, flag);
            Console.WriteLine("Teacher details deleted successfully...");
        }

        [TestCase]
        public void UpdateTeacherTest()
        {
            Teacher teacher = new Teacher();
            teacher.Teacherid = "TEACH-001";
            teacher.Name = "Mr Shravan";
            teacher.Qualification = "PHD";

            bool flag = method.UpdateTeacher(teacher);
            Assert.AreEqual(true, flag);

            Console.WriteLine("Teacher details updated successfully...");
            Console.WriteLine("TeacherID :" + teacher.Teacherid);
            Console.WriteLine("TeacherName :" + teacher.Name);
            Console.WriteLine("Qualtification :" + teacher.Qualification);
        }
    }
}

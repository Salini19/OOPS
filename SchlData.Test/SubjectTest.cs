using NUnit.Framework;
using SchoolData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchlData.Test
{
    [TestFixture]
    public class SubjectTest
    {
        SubjectMethods method = new SubjectMethods();
        [TestCase]
        public void AddNewSubjectTest()
        {
            Subject subject = new Subject();
            subject.subId = "SUB-001";
            subject.subName = "MPMC";
            subject.Stream = "ETC";
            bool flag = method.AddSubject(subject);
            Assert.AreEqual(true, flag);

            Console.WriteLine("SUbject details added successfully...");
            Console.WriteLine("SubjectID :" + subject.subId);
            Console.WriteLine("SubjectName :" + subject.subName);
            Console.WriteLine("Stream :" + subject.Stream);
        }

        [TestCase]
        public void DeleteSubjectTest()
        {
            string subject = "SUB-001";
            bool flag = method.RemoveSubject(subject);
            Assert.AreEqual(true, flag);
            Console.WriteLine("SUbject details deleted successfully...");
        }

        [TestCase]
        public void UpdateSubjectTest()
        {
            Subject subject = new Subject();
            subject.subId = "SUB-001";
            subject.subName = "OOPS";
            subject.Stream = "CS";
            bool flag = method.Updatesubject(subject);
            Assert.AreEqual(true, flag);
            Console.WriteLine("SUbject details updated successfully...");
            Console.WriteLine("SubjectID :" + subject.subId);
            Console.WriteLine("SubjectName :" + subject.subName);
            Console.WriteLine("Stream :" + subject.Stream);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolData
{
    public class StudentMethod
    {
        SchoolDBEntities context = new SchoolDBEntities();

        public  bool AddStudent(Student s)
        {
            try
            {
                context.Students.Add(s);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool RemoveStudent(string id)
        {
            
            List<Student> s = context.Students.ToList();
            Student s1 = s.Find(m => m.studid == id);
            try
            {
                context.Students.Remove(s1);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool UpdateStudent(Student s2)
        {
            List<Student> s = context.Students.ToList();
            try
            {
                Student s1 = s.Find(m => m.studid== s2.studid);
                s1.studid = s2.studid;
                s1.studName = s2.studName;
                s1.@class = s2.@class;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public List<Student> GetAllStudents()
        {
           
            List<Student> s1 = context.Students.ToList();

            return s1;
        }
    }
    public class SubjectMethods
    {
        SchoolDBEntities context = new SchoolDBEntities();

        public bool AddSubject(Subject s1)
        {
            
            try
            {
                context.Subjects.Add(s1);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool RemoveSubject(string id)
        {
            
            List<Subject> s1 = context.Subjects.ToList();
            try
            {
                Subject s2 = s1.Find(m => m.subId == id);
                context.Subjects.Remove(s2);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool Updatesubject( Subject s1)
        {
           
            List<Subject> list = context.Subjects.ToList();
            try
            {
                Subject s2 = list.Find(m => m.subId == s1.subId);
                s2.subId = s1.subId;
                s2.subName = s1.subName;
                s2.Stream = s1.Stream;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public List<Subject> Subjectlist()
        {
            return context.Subjects.ToList();
        }
    }
    public class TeacherMethod
    {
        SchoolDBEntities context = new SchoolDBEntities();
        public bool AddTeacher(Teacher t)
        {
            try
            {
                context.Teachers.Add(t);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveTeacher(string id)
        {
            List<Teacher> list = context.Teachers.ToList();
            Teacher t1 = list.Find(x => x.Teacherid == id);
            try
            {
                context.Teachers.Remove(t1);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateTeacher(Teacher t)
        {
            List<Teacher> list = context.Teachers.ToList();
            Teacher t1 = list.Find(x => x.Teacherid == t.Teacherid);
            try
            {
                t1.Teacherid = t.Teacherid;
                t1.Name = t.Name;
                t1.Qualification = t.Qualification;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Teacher> GetTeachers()
        {
            return context.Teachers.ToList();
        }
    }
}

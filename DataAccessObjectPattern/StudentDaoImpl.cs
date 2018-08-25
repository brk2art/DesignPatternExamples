using System;
using System.Collections.Generic;

namespace DataAccessObjectPattern
{
    public class StudentDaoImpl : StudentDao
    {
        //list is working as a database
        List<Student> students;

        public StudentDaoImpl()
        {
            students = new List<Student>();
            Student student1 = new Student("Robert", 0);
            Student student2 = new Student("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void deleteStudent(Student student)
        {
            students.RemoveAt(student.getRollNo());
            Console.WriteLine("Student: Roll No " + student.getRollNo() + ", deleted from database");
        }

        public List<Student> getAllStudents()
        {
            return students;
        }

        public Student getStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void updateStudent(Student student)
        {
            students[student.getRollNo()].setName(student.getName());
            Console.WriteLine("Student: Roll No " + student.getRollNo() + ", updated in the database");
        }
    }
}

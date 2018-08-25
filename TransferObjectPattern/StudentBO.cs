using System;
using System.Collections.Generic;

namespace TransferObjectPattern
{
    public class StudentBO
    {
        //list is working as a database
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            StudentVO student1 = new StudentVO("Robert", 0);
            StudentVO student2 = new StudentVO("John", 1);
            students.Add(student1);
            students.Add(student2);
        }
        public void deleteStudent(StudentVO student)
        {
            students.RemoveAt(student.getRollNo());
            Console.WriteLine("Student: Roll No " + student.getRollNo() + ", deleted from database");
        }

        //retrive list of students from the database
        public List<StudentVO> getAllStudents()
        {
            return students;
        }

        public StudentVO getStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void updateStudent(StudentVO student)
        {
            students[student.getRollNo()].setName(student.getName());
            Console.WriteLine("Student: Roll No " + student.getRollNo() + ", updated in the database");
        }
    }
}

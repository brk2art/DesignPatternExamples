using System;

namespace TransferObjectPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();

            //print all students
            foreach (StudentVO studentItem in studentBusinessObject.getAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + studentItem.getRollNo() + ", Name : " + studentItem.getName() + " ]");
            }

            //update student
            StudentVO student = studentBusinessObject.getAllStudents()[0];
            student.setName("Michael");
            studentBusinessObject.updateStudent(student);

            //get the student
            student = studentBusinessObject.getStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.getRollNo() + ", Name : " + student.getName() + " ]");
        }
    }
}

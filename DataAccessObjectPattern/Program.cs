using System;

namespace DataAccessObjectPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentDao studentDao = new StudentDaoImpl();

            //print all students
            foreach (Student studentItem in studentDao.getAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + studentItem.getRollNo() + ", Name : " + studentItem.getName() + " ]");
            }

            //update student
            Student student = studentDao.getAllStudents()[0];
            student.setName("Michael");
            studentDao.updateStudent(student);

            //get the student
            studentDao.getStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.getRollNo() + ", Name : " + student.getName() + " ]");
        }
    }
}

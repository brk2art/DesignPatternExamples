namespace DataAccessObjectPattern
{
    public class Student
    {
        private string name;
        private int rollNo;

        public Student(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getRollNo()
        {
            return rollNo;
        }

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }
    }
}

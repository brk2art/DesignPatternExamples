﻿using System.Collections.Generic;

namespace DataAccessObjectPattern
{
    public interface StudentDao
    {
        List<Student> getAllStudents();
        Student getStudent(int rollNo);
        void updateStudent(Student student);
        void deleteStudent(Student student);
    }
}

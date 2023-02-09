using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Notes_Assignment
{

    public class Student
    {
        //Fields
        public string FirstName;
        public string LastName;
        public double CSIGrade;
        public double GenEdGrade;

        //Constructor

        //constructor is whats called when we create an object of a class
        //create constructor by access modifier - ClassName - Closing parenthesis.
        //constructors allow/restrict requirements to create an object
        
        public Student(string firstName, string lastName, double compGrade, double genEdGrade)
        {
            //assign values to fields
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = compGrade;
            GenEdGrade = genEdGrade;
        }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = -1;
            GenEdGrade = -1;
        }
        
    }
}

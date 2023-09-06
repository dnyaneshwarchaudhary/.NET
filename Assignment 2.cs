using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class MainProgram
    {
        //Assignment 2
        public static void Main(string[] args)
        {
           
            Student S1 = new Student(22, "Rameshwari", 19,95 );
            S1.Display();
            S1.Accept();
            S1.Display();
            Console.WriteLine(S1.CalculateRank());
           
            EnggStudent ES1 = new EnggStudent(21,"Dnyaneshwar",18,72.0,"Mech",55);
            ES1.Display();
            ES1.Accept();
            ES1.Display();
            Console.WriteLine(ES1.CalculateRank());
            
            MedicalStudent M1 = new MedicalStudent(18,"ger",53,432.3,"MBBS",4523);
            M1.Display();
            M1.Accept();
            M1.Display();
            Console.WriteLine(M1.CalculateRank());
          


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Student
    {

        int StudentId;
        string Name;
        int Age;
        double Percentage;

        public Student(int S, string N, int A, double P) 
        { 
            this.StudentId = S;
            this.Name = N;
            this.Age = A;
            this.Percentage = P;
        }

        public virtual void Display()
        {

            Console.WriteLine("Student Id is : " + this.StudentId);
            Console.WriteLine("Student Name is : " + this.Name);
            Console.WriteLine("Student Age is : " + this.Age);
            Console.WriteLine("Student Percentage is : " +  this.Percentage);

        }

        public virtual void Accept()
        {
            Console.WriteLine("Enter student ID: ");
            this.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter percentage: ");
            this.Percentage = Convert.ToDouble(Console.ReadLine());
        }

        public virtual int CalculateRank()
        {
            int StudentRank = 1;
            
            return StudentRank;
        }

        public override string ToString()
        {
            string Result = "Student ID: " + this.StudentId + " \n Name: " + this.Name + " \n Age: " + this.Age + " \n Percentage: " + this.Percentage; 
            return Result;
        }
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class EnggStudent : Student
    {

        string Branch;
        int InternalMarks;

        public EnggStudent(int S, string N, int A, double P, string B, int I) : base(S, N, A, P)
        {
            this.InternalMarks = I;
            this.Branch = B;

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Student Engineering Branch is : " + this.Branch);
            Console.WriteLine("Student Engineering Internal Marks: " + this.InternalMarks);

        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the Student Engineering Branch : ");
            this.Branch = Console.ReadLine();
            Console.WriteLine("Enter the Student Engineering Internal Marks : ");
            this.InternalMarks = Convert.ToInt32(Console.ReadLine());
        }
        public override int CalculateRank()
        {
            return base.CalculateRank()+1;
        }
        public override string ToString()
        {
            string result = base.ToString();
            result += "Student Engineering Branch: " + this.Branch + " \n Student Engineering Internal Marks : " + this.InternalMarks;
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class MedicalStudent : Student
    {
        string Specilization;
        int MarksOfInternship;

        public MedicalStudent(int S, string N, int A, double P, string Sp, int M ) : base(S, N, A, P)
        {
            this.Specilization = Sp;
            this.MarksOfInternship = M;

        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Student Specilization is : " + this.Specilization);
            Console.WriteLine("Student Marks of Intership is : " + this.MarksOfInternship);
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the Student Specilization : ");
            this.Specilization = Console.ReadLine();
            Console.WriteLine("Enter  the Student Marks of Internship : ");
            this.MarksOfInternship = Convert.ToInt32(Console.ReadLine());
        }

        public override int CalculateRank()
        {
            return base.CalculateRank()+1;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "Student Specilization is " + this.Specilization + "\n Student Marks of Internship is : " + this.MarksOfInternship;
             
            return result;
        }
    }
}


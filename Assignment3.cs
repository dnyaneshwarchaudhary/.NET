using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Main Class
            Company C1 = new Company(5);
      
            C1.addEmployee(new Employee(21, "Danny"),0);
            C1[0].name = "Dannys";
            C1.displayEmp(0);
            C1.searchEmployee(21);
            C1.editEmployee(0);
            C1.displayEmp(0);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Employee
    {
        public int id;
        public string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
      
        public void display()
        {

            Console.WriteLine("Employee ID is : " + this.id);
            Console.WriteLine("Employee Name is : " + this.name);

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Company
    {
        Employee[] employees;
        public Company(int size)
        {
             employees = new Employee[size];
                
        }


        public  void addEmployee(Employee e, int index)
        {
            
            e = new Employee(e.id, e.name);
            employees[index] = e;
            e.display();
        }

        public void displayEmp(int index)
        {
            Console.WriteLine("Employee name : " + employees[index].name);
            Console.WriteLine("Employee ID : " + employees[index].id);


        }
        public void editEmployee(int index)
        {
            Console.WriteLine("Enter the new name : ");
            employees[index].name = Console.ReadLine();
          

        }

        public void searchEmployee(int id)
        {
            for (int i = 0; i < employees.Length; i++)
            {

                if (employees[i].id == id )
                    Console.WriteLine("Employee Found");
                    break;

               
            }
       
        }
        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set 
            {
                Employee employee = value;
            }

        }


    }
    
    }

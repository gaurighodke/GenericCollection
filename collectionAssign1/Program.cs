using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;


namespace collectionAssign1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                Empname = "Gauri",
                Empid = 101,
                Salary = 25000,
            };

            Employee e2 = new Employee()
            {
                Empname = "Purva",
                Empid = 104,
                Salary = 26000,
            };

            Employee e3 = new Employee()
            {
                Empname = "Ekta",
                Empid = 102,
                Salary = 27000,
            };
            Employee e4 = new Employee()
            {
                Empname = "Aishwarya",
                Empid = 103,
                Salary = 28000,
            };


            #region Stack Demo
            //Stack st = new Stack();  // non generic collection

             Stack<Employee> st = new Stack<Employee>(); // generic collectopn

            st.Push(e1);
            st.Push(e2);
            st.Push(e3);
            st.Push(e4);
           
            //st.Push(DateTime.Now);
            // //st.Push("gauri");
            Console.WriteLine("no. of elements in stack {0}", st.Count);

            Console.WriteLine("Retrive elements from stack");
            // /// Console.WriteLine("getting element {0}", st.Pop());

            // Console.WriteLine("no. of elements in stack {0}", st.Count
         
           

            foreach (Employee emp in st)
            {
                Console.WriteLine("Id : " + emp.Empid +" "+ " Name : "+  emp.Empname + " "+ " Salary : " + emp.Salary);
              
            }
                Employee emp1 = st.Pop();

            Console.WriteLine("********** After Pop Operation**************");


            foreach (Employee emp in st)
            {
                Console.WriteLine("Id : " + emp.Empid + " " + " Name : " + emp.Empname + " " + " Salary : " + emp.Salary);

            }
            //while (st.Count > 0)
            //     Console.Write(st.Pop() + ",");
            Console.Write("Number of elements in Stack: {0}", st.Count);
            Console.ReadLine();

           
            #endregion

        }
    }
}

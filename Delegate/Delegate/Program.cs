using System;
using System.Collections.Generic;

namespace DelegateNameSpace
{
    class Program
    {
        public delegate bool EligibleToPromoteDelegate(Employee emp); 
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>() {
            new Employee () { Id=1,Name="John", Experience=5},
            new Employee () { Id=2,Name="Mark", Experience=7},
            new Employee () { Id=3,Name="George", Experience=2},
            new Employee () { Id=4,Name="Bill", Experience=6},
            new Employee () { Id=1,Name="Cannor", Experience=9}
            };


            // Here we are able to call different Bussiness logic without without 
            Console.WriteLine("____________________________________Employee with exp > 5_____________________________________");
            EligibleToPromoteDelegate eligibleToPromote = new EligibleToPromoteDelegate(Promote);
            //IsEligibleToPromote(employeeList, eligibleToPromote);
            Employee.IsEligibleToPromote(employeeList, eligibleToPromote);

            Console.WriteLine("____________________________________Employee with exp > 3_____________________________________");
            EligibleToPromoteDelegate eligibleToPromote3 = new EligibleToPromoteDelegate(Promote3);
            Employee.IsEligibleToPromote(employeeList, eligibleToPromote3);
            //IsEligibleToPromote(employeeList, eligibleToPromote3);

            //The Function Pointer Delegate got replaced with Lambda expression
            Console.WriteLine("____________________________________Employee with exp > 5_____________________________________");
            Employee.IsEligibleToPromote(employeeList, x => x.Experience > 5);

            Console.ReadKey();

        }

    

        /// <summary>
        /// Independent Bussiness logic method 
        /// Promote Employee With Exp >5
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        private static bool Promote (Employee emp)
        {
            if (emp.Experience > 5)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Independent Bussiness logic method 
        /// Promote Employee With Exp >3
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        private static bool Promote3(Employee emp)
        {
            if (emp.Experience > 3)
                return true;
            else
                return false;
        }
    }
}

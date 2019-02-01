using System;
using System.Collections.Generic;
using static DelegateNameSpace.Program;

namespace DelegateNameSpace
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Experience { get; set; }

        public static void IsEligibleToPromote(List<Employee> employeeList, EligibleToPromoteDelegate eligibleToPromoteDelegate)
        {

            foreach (Employee emp in employeeList)
            {
                if (eligibleToPromoteDelegate(emp))
                    Console.WriteLine("Promotable");
                else
                    Console.WriteLine("Not Promotable");
            }
        }



      
    }
}

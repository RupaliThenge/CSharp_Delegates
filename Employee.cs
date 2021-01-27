using System;
using System.Collections.Generic;
delegate bool isPromote(Employee emp);  
delegate string strDele(string str); //declare
    class Employee  
    {  
        public int ID { get; set; }  
        public string Name { get; set; }  
        public int salary { get; set; }  
        public float Experiance { get; set; }  
  
         
        public static void PromoteEmp(List<Employee> EmployeeList,isPromote IsEligible)  
        {  
            foreach (Employee  emp in EmployeeList )  
            {  
                //you can see that there is no hard coded logic to promote an employee. 
                //The logic is used when we call this method.
                if(IsEligible(emp))//logic condition  
                {  
                    Console.WriteLine(emp.Name + " Promoted");  
                }  
            }  
        }  
}  
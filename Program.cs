using System;
using System.Collections.Generic;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Employee> empl = new List<Employee>();  
            empl.Add(new Employee() { ID = 101, Name = "Brad", salary = 20000, Experiance = 13 });  
            empl.Add(new Employee() { ID = 102, Name = "John", salary = 30000, Experiance = 4 });  
            empl.Add(new Employee() { ID = 103, Name = "Suzan", salary = 50000, Experiance = 8 });  
            empl.Add(new Employee() { ID = 104, Name = "Mike", salary = 10000, Experiance = 2 });  
            
            //Using delegate business logic got separated from employee class which makes code reusable.
            
            //Creating an instance of delegate
            isPromote pro = new isPromote(promote);  

            //Calling PromoteEmp function with passing the employee list and the delegate
            Employee.PromoteEmp(empl, pro);

             //multi cast delegate example
            strDele delobj = new strDele (uppercasestr); //method reference 1  
            Console.WriteLine(delobj("Thank You"));
            delobj += new strDele (Lowercasestr); //method reference 2   
            Console.WriteLine(delobj("Thank You"));
        }
        
        //Using delegate business logic got separated from employee class which makes code reusable.
        public static bool promote(Employee emp)  
        {  
            if (emp.Experiance >= 5)  
            {  
                return true;  
            }  
            else  
            {  
                return false;  
            }  
        }  
    
  
        public static string uppercasestr(string abc)  
        { 
            return abc.ToUpper();
        }

        public static string Lowercasestr(string abc)  
        { 
            return abc.ToLower();
        }
    }
        
}

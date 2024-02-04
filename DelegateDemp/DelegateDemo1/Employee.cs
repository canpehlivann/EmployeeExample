using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo1
{
	class Employee
	{
		private delegate bool IsPromotable(EmployeeModel emp1);
		
		private delegate bool IsPromotableBySalary(EmployeeModel emp2);
		
		private delegate void MulticastDelegate();

		private readonly List<EmployeeModel> EmployeeList;

		public Employee()
        {
			EmployeeList = new List<EmployeeModel>
			{
				new EmployeeModel() { Id = 1, Name = "Sandeep", Experience = 8 , Salary = 20 },

				new EmployeeModel() { Id = 2, Name = "Rohith", Experience = 6, Salary = 10 },

				new EmployeeModel() { Id = 3, Name = "Omkar", Experience = 10, Salary = 15},

				new EmployeeModel() { Id = 4, Name = "Vishnu", Experience = 7 , Salary = 6}
			};
		}
		
		public void PromoteEmployee()
		{
			var isPromotable = new IsPromotable(EligibleEmpSalary);

			isPromotable += EligibleEmp;

			foreach (EmployeeModel employee in EmployeeList)
			{
				if (isPromotable(employee))
				{ 
						Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
				}
			}

		}
		private static void MethodOne()
		{
			Console.WriteLine("MethodOne");
		}

		private static void MethodTwo()
		{
			Console.WriteLine("MethodTwo");
		}

		public void multiMethod() //Wrapper of method one and method two.
		{
			var multiCastDel = new MulticastDelegate(MethodOne);
			
			multiCastDel += MethodTwo;
			
			multiCastDel();
		
		}
		static bool EligibleEmp(EmployeeModel ee)
		{
			if (ee.Experience >= 8)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		static bool EligibleEmpSalary(EmployeeModel e2)
		{
			if (e2.Salary >= 10)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


	}
}

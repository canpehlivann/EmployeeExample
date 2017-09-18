using System;
using System.Collections.Generic;

public class WithDelClassEx
{

	public static void Main()
	{

		List<Employee> emplist = new List<Employee>
		{
			new Employee() { Id = 1, Name = "Sandeep", Experience = 8 , Salary = 20 },
			new Employee() { Id = 2, Name = "Rohith", Experience = 6, Salary = 10 },
			new Employee() { Id = 3, Name = "Omkar", Experience = 10 , Salary = 5},
			new Employee() { Id = 4, Name = "Vishnu", Experience = 9 , Salary = 6}
		};

		IsPromotable isPromotable = new IsPromotable(EligibleEmp);
		isPromotable += EligibleEmpSalary;//Multi Cast Delegate
		//IsPromotable promoteSal = new IsPromotable(EligibleEmpSalary);
		//isPromotable += promoteSal;
		Employee.PromoteEmployee(emplist, isPromotable);
		//Employee.PromoteEmployee(emplist, emp => emp.Experience >= 8);
		Console.ReadKey();
	}

	static bool EligibleEmp(Employee ee)
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

	static bool EligibleEmpSalary(Employee e2)
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

delegate bool IsPromotable(Employee emp1);


class Employee
{

	public int Id { set; get; }
	public string Name { set; get; }
	public int Experience { set; get; }
	public int Salary { get; set; }

	public static void PromoteEmployee(List<Employee> emp, IsPromotable IsEligibleToPromote)
	{
		foreach (Employee employee in emp)
		{
			if (IsEligibleToPromote(employee))
			{
				Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
			}
		}
	}

}
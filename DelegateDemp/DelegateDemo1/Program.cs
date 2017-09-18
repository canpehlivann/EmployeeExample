using System;
using System.Collections.Generic;



delegate bool IsPromotable(Employee emp1);
delegate bool IsPromotableBySalary(Employee emp2);
delegate void MulticastDelegate();

public class WithDelClassEx
{

	public static void Main(string[] Args)
	{

		List<Employee> emplist = new List<Employee>
		{
			new Employee() { Id = 1, Name = "Sandeep", Experience = 8 , salary = 20 },
			new Employee() { Id = 2, Name = "Rohith", Experience = 6, salary = 10 },
			new Employee() { Id = 3, Name = "Omkar", Experience = 10, salary = 15},
			new Employee() { Id = 4, Name = "Vishnu", Experience = 7 , salary = 6}
		};

		IsPromotable isPromotable = new IsPromotable(EligibleEmp);
		//isPromotable += EligibleEmpSalary;
		IsPromotableBySalary promoteSal = new IsPromotableBySalary(EligibleEmpSalary);
		//isPromotable += promoteSal;
		Employee.PromoteEmployee(emplist, isPromotable, promoteSal);
		//Employee.PromoteEmployee(emplist, emp => emp.Experience >= 8);

		//Multicast Delegate
		Console.WriteLine("Multicast Delegate");
		MulticastDelegate multi = MethodOne;
		multi += MethodTwo;
		multi();
		Console.ReadKey();
	}


	public static void MethodOne()
	{
		Console.WriteLine("MethodOne");
	}

	public static void MethodTwo()
	{
		Console.WriteLine("MethodTwo");
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
		if (e2.salary >= 10)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

}



class Employee
{

	public int Id { set; get; }
	public string Name { set; get; }
	public int Experience { set; get; }
	public int salary { get; set; }

	public static void PromoteEmployee(List<Employee> emp, IsPromotable IsEligibleToPromote, IsPromotableBySalary IsEligibleBySalary)
	{
		foreach (Employee employee in emp)
		{
			if (IsEligibleToPromote(employee))
			{
				if (IsEligibleToPromote(employee))
				{
					Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
				}
			}
		}
	}

}
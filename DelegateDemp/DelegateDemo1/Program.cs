using System;
using System.Collections.Generic;

namespace DelegateDemo1
{
	public class EmployeePromoter
	{
		static void Main()
		{

			var employee = new Employee();

			employee.PromoteEmployee();

			Console.WriteLine("\n");

			Console.WriteLine("Multi Method Example\n");

			employee.multiMethod();

			Console.ReadLine();

		}
	}
}
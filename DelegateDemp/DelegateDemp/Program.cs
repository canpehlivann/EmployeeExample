using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemp
{
	class Program
	{
		private delegate void GreetingDelegate(string Name);
		static void Main()
		{
			var del = new GreetingDelegate(Greeting);

			del("Sandeep");
			
			Console.ReadKey();
		}

		private static void Greeting(string Name)
		{

			Console.WriteLine("Hello " + Name);
		
		}
	}
}

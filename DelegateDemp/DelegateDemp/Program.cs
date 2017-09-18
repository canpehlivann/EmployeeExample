using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemp
{
	public delegate void GreetingDelegate(string Name);

	class Program
	{
		static void Main(string[] args)
		{
			GreetingDelegate del = new GreetingDelegate(Greeting);
			//GreetingDelegate del = Greeting;
			del("Sandeep");
			Console.ReadKey();
		}

		public static void Greeting(string Name)
		{
			Console.WriteLine("Hello " + Name);
		}
	}
}

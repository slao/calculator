using System;

namespace calculator
{
	public class MainClass
	{
		public static void Main()
		{
			RunTests();
		}

		private static void RunTests()
		{
			Calculator c = new Calculator ();
			Console.WriteLine(c.Compute ("1 + 1"));
			Console.WriteLine(c.Compute ("1 + 1 + 1"));
		}
	}
}


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
			Console.WriteLine(c.Compute ("1 + 2 * 3"));
			Console.WriteLine(c.Compute ("5 - 6"));
			Console.WriteLine(c.Compute ("8 * 4"));
			Console.WriteLine(c.Compute ("1 + 1 - 4 * 4"));
		}
	}
}


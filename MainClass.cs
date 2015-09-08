using System;

namespace calculator
{
	// User-defined operator
	public class PowerOperator : Operator
	{
		public string Symbol {
			get {
				return "^";
			}
		}

		public int Priority {
			get {
				return 0;
			}
		}

		public int Calculate(int value1, int value2)
		{
			return (int) Math.Pow (value1, value2);
		}
	}

	public class MainClass
	{
		public static void Main()
		{
//			RunTests();

			Calculator c = new Calculator ();

			// Shows extensibility of operands
			c.AddOperator (new PowerOperator ());

			do {
				string s = Console.ReadLine ();
				Console.WriteLine (c.Compute (s));
			} while (true);
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

			c.AddOperator (new PowerOperator ());
			Console.WriteLine(c.Compute ("1 + 5 * 2 ^ 3"));
		}
	}
}


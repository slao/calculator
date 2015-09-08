using System;

namespace calculator
{
	public class DivideOperator : Operator
	{
		public string Symbol {
			get {
				return "/";
			}
		}

		public int Priority {
			get {
				return 1;
			}
		}

		public int Calculate(int value1, int value2)
		{
			return value1 / value2;
		}
	}
}
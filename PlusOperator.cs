using System;

namespace calculator
{
	public class PlusOperator : Operator
	{
		public string Symbol {
			get {
				return "+";
			}
		}

		public int Calculate(int value1, int value2)
		{
			return value1 + value2;
		}
	}
}


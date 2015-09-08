using System;

namespace calculator
{
	public class SubtractOperator : Operator
	{
		public string Symbol {
			get {
				return "-";
			}
		}

		public int Priority {
			get {
				return 2;
			}
		}

		public int Calculate(int value1, int value2)
		{
			return value1 - value2;
		}
	}

}


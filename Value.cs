using System;

namespace calculator
{
	public class Value : Expression
	{
		int value = 0;

		public Value(int value)
		{
			this.value = value;
		}

		public int Compute()
		{
			return value;
		}
	}
}


using System;
using System.Collections.Generic;

namespace calculator
{
	public class Calculator
	{
		private Dictionary<string, Operator> mOperators = new Dictionary<string, Operator>();

		public Calculator()
		{
			AddOperator (new PlusOperator ());
		}

		private void AddOperator(Operator o)
		{
			mOperators [o.Symbol] = o;
		}

		public int Compute(string expr)
		{
			Expression e = Formula.Parse (expr, mOperators);
			if (e != null)
				return e.Compute ();
			else
				throw new Exception ("Invalid Expression");
		}
	}

}


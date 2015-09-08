using System;
using System.Collections.Generic;

namespace calculator
{
	public class Calculator
	{
		private Dictionary<string, Operator> mOperators = new Dictionary<string, Operator>();

		public Calculator()
		{
			SetupOperators ();
		}

		private void SetupOperators()
		{
			AddOperator (new PlusOperator ());
			AddOperator (new MultiplyOperator ());
			AddOperator (new SubtractOperator ());
			AddOperator (new DivideOperator ());
		}

		public void AddOperator(Operator o)
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


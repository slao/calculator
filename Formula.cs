using System;
using System.Collections.Generic;

namespace calculator
{
	public class Formula : Expression
	{
		protected Expression mValue1;
		protected Expression mValue2;
		protected Operator mOp;

		public int Compute()
		{
			return mOp.Calculate (mValue1.Compute(), mValue2.Compute());
		}

		public Formula(Expression value1, Expression value2, Operator op)
		{
			this.mValue1 = value1;
			this.mValue2 = value2;
			this.mOp = op;
		}

		public static Expression Parse(string expr, Dictionary<string, Operator> operators)
		{
			string[] words = expr.Split (' ');
			return ParseHelper (words, 0, words.Length - 1, operators);
		}

		private static Expression ParseHelper(string[] words, int start, int end, Dictionary<string, Operator> operators)
		{
			Expression value1 = null;
			Expression value2 = null;
			Operator op = null;

			for (int i = start; i <= end; ++i) {
				string word = words[i];
//				Console.WriteLine ("process " + word);
				int n = 0;
				bool isNumeric = int.TryParse (word, out n);
				if (isNumeric) {
					if (value1 == null)
						value1 = new Value (n);
					else if (value2 == null)
						value2 = new Value (n);
					else
						return null;
				} else if (op == null) {
					if (operators.ContainsKey (word)) {
						op = operators [word];
					} else
						return null;
				} else if (value1 != null && value2 != null && operators.ContainsKey(word)) {
					value1 = new Formula (value1, value2, op);
					op = operators [word];
					value2 = null;
				} else {
					return null;
				}
			}

			if (value1 == null || value2 == null || op == null) {
				return null;
			}

			return new Formula (value1, value2, op);
		}
	}
}

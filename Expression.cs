using System;
using System.Collections.Generic;

namespace calculator
{
	public class Expression
	{
		protected int mValue1;
		protected int mValue2;
		protected Operator mOp;

		public int Compute()
		{
			return mOp.Calculate (mValue1, mValue2);
		}

		public Expression(int value1, int value2, Operator op)
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
			bool foundValue1 = false;
			bool foundValue2 = false;
			int value1 = 0;
			int value2 = 0;
			Operator op = null;

			for (int i = start; i <= end; ++i) {
				string word = words[i];
				int n = 0;
				bool isNumeric = int.TryParse (word, out n);
				if (isNumeric) {
					if (!foundValue1) {
						value1 = n;
						foundValue1 = true;
					} else if (!foundValue2) {
						value2 = n;
						foundValue2 = true;
					}
					else
						return null;
				} else if (op == null && operators.ContainsKey (word)) {
					op = operators [word];
				} else {
					return null;
				}
			}

			if (!foundValue1 || !foundValue2 || op == null) {
				return null;
			}

			return new Expression (value1, value2, op);
		}
	}
}

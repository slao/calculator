﻿using System;

namespace calculator
{
	public interface Operator
	{
		string Symbol { get; }
		int Priority { get; }
		int Calculate(int value1, int value2);
	}
}


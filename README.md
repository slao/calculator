API

Operator interface: implement this to create your own operator and call Calculator.AddOperator to add to a calculator instance

Calculator:
- void AddOperator(Operator o): adds a new operator for calculator expressions
- int Compute(string expr): compute the expression

Usage:
Calculator c = new Calculator();
c.AddOperator(new MyOperator());
c.Compute("1 + 1 * 3");

MainClass is an example of how to use the calculator library. To build and run sample:

1. Install mono: http://www.mono-project.com/docs/about-mono/supported-platforms/osx/
2. xbuild calculator.sln
3. mono bin/Debug/calculator.exe


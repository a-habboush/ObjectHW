class Program
{

	static void Main(string[] args)
	{
		Calculator calculator = new Calculator();

		Console.WriteLine("enter the value of x: ");
		double inputX = Double.Parse(Console.ReadLine());
		Console.WriteLine("enter the value of y: ");
		double inputY = Double.Parse(Console.ReadLine());



		Console.WriteLine("Sum: " + calculator.Add(inputX, inputY));
		Console.WriteLine("Difference: " + calculator.Subtract(inputX, inputY));
		Console.WriteLine("Product: " + calculator.Multiply(inputX, inputY));

		try
		{
			Console.WriteLine("Quotient: " + calculator.Divide(inputX, inputY));
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("Cannot divide by zero");

		}

	}




}

class Calculator
{

	public double Add(double x, double y)
	{
		return x + y;

	}


	public double Subtract(double x, double y)
	{
		return x - y;

	}

	public double Multiply(double x, double y)
	{
		return x * y;

	}
	public double Divide(double x, double y)
	{
		if (y == 0)
		{
			throw new DivideByZeroException();
		}
		return x / y;
	}




}

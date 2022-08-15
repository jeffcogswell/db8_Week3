// int x = 10;
// List<string> mylist = new List<string>();

// firstpen is an object that has inside it four variables.

Pen firstpen = new Pen();
firstpen.InkColor = "blue";
firstpen.Length = 4.5;
firstpen.PointType = "Gel";
firstpen.PointSize = "Small";
firstpen.InkAmount = 5;

Console.WriteLine(firstpen.InkColor);
Console.WriteLine(firstpen.Length);
Console.WriteLine(firstpen.PointType);
Console.WriteLine(firstpen.PointSize);
Console.WriteLine(firstpen.InkAmount);

Console.WriteLine("Let's draw with firstpen!");
firstpen.Draw();
Console.WriteLine($"The ink is now {firstpen.InkAmount}");

Console.WriteLine();

Pen secondpen = new Pen();
secondpen.InkColor = "red";
secondpen.Length = 4.5;
secondpen.PointType = "Ball Point";
secondpen.PointSize = "Medium";
secondpen.InkAmount = 2;

Console.WriteLine(secondpen.InkColor);
Console.WriteLine(secondpen.Length);
Console.WriteLine(secondpen.PointType);
Console.WriteLine(secondpen.PointSize);
Console.WriteLine(secondpen.InkAmount);

Console.WriteLine("Let's do two drawings with secondpen!");
secondpen.Draw();
secondpen.Draw();

Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");
Console.WriteLine($"firstpen still has ink level {firstpen.InkAmount}");

secondpen.Draw();
Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");

secondpen.Refill();
Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");

Console.WriteLine();
Console.WriteLine("Let's refill firstpen with green ink");
firstpen.Refill("green");
Console.WriteLine($"First pen has ink {firstpen.InkColor}");

Console.WriteLine();
Pen thirdpen = new Pen();
Console.WriteLine(thirdpen.InkAmount);

Console.WriteLine();
Pen fourthpen = new Pen("green");
Console.WriteLine(fourthpen.InkAmount);
Console.WriteLine(fourthpen.InkColor);

class Pen
{
	// Member variables
	public string InkColor;
	public double Length;
	public string PointType;
	public string PointSize;
	public int InkAmount;

	public Pen() // Default Constructor
	{
		InkAmount = 10;
		InkColor = "black";
	}

	public Pen(string _InkColor)
	{
		InkColor = _InkColor;
		InkAmount = 10;
	}

	// Member methods
	public void Draw()
	{
		if (InkAmount > 0)
		{
			InkAmount--;
		}
	}

	public void Refill()
	{
		InkAmount = 10;
	}

	// Let's add another Refill function that lets us specify ink color
	public void Refill(string InkColor)
	{
		this.InkColor = InkColor;
		InkAmount = 10;
	}
}

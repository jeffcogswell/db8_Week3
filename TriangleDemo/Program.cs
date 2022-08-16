
Triangle first = new Triangle(4, 3);
double area = first.GetArea();
Console.WriteLine(area);
Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());

class Triangle
{

	// We have a package, like a capsule
	// The verb we use is "encapsulate"
	// We've packaged together Length and Height
	// into a triangle concept.
	// We have "encapsulated" Length and Height
	// into a triangle.

	public double Length;
	public double Height;

	// Initializing the data
	// Create a constructor
	public Triangle(double _length, double _height)
	{
		Length = _length;
		Height = _height;
	}

	public double GetArea()
	{
		return Length * Height / 2;
	}

	public double GetHypotenuse()
	{
		return Math.Sqrt(Length * Length + Height * Height);
	}

	public double GetPerimeter()
	{
		return Length + Height + GetHypotenuse();
	}
}

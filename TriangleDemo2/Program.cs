
Triangle first = new Triangle(4, 3);
Console.WriteLine(first.GetArea());
Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());

// first.Height = 10; Can't do this now, because Height is private.

class Triangle
{

	// We have a package, like a capsule
	// The verb we use is "encapsulate"
	// We've packaged together Length and Height
	// into a triangle concept.
	// We have "encapsulated" Length and Height
	// into a triangle.

	private double Length;
	private double Height;
	private double Area;

	// Initializing the data
	// Create a constructor
	public Triangle(double _length, double _height)
	{
		Length = _length;
		Height = _height;
		Area = Length * Height / 2;
	}

	public double GetArea()
	{
		return Area;
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

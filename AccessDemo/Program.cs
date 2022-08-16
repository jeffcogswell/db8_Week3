
Car first = new Car("Chevy", "Trax", Color.Blue);
Console.WriteLine(first.GetMake()); // We can read the value of Make through this function
Console.WriteLine(first.GetModel());
Console.WriteLine(first.GetColor());
first.SetColor(Color.Red);
Console.WriteLine(first.GetColor());
//first.SetColor("White");
Console.WriteLine(first.GetColor());

// first.Make = "Ford";  // We cannot write the value of Make.


//bool yesno = false; // Two possible choices for a boolean variable
//int n = 100;
//double p = 3.14;
//Color carcolor = Color.Blue; // Four possible choices because of how we created our enum

//Color pianocolor = Color.Black; // We have four possible choices: Red, Blue, Black, Silver
//pianocolor = Color.Red;


enum Color
{
	Red,
	Blue,
	Black,
	Silver
}


class Car
{
	// Attributes that cannot be changed
	private string Make;
	private string Model;

	// Attributes that can be changed
	private Color CarColor;

	public Car(string _make, string _model, Color _color)
	{
		Make = _make;
		Model = _model;
		CarColor = _color;
	}

	// Make only has a "getter" method, so we can only look at it. We cannot change it.
	public string GetMake()
	{
		return Make;
	}

	// Model only has a "getter" method, so we can only look at it. We cannot change it.
	public string GetModel()
	{
		return Model;
	}

	// Color has both a "getter" and "setter" so we can look at it AND change it.
	public Color GetColor()
	{
		return CarColor;
	}

	public void SetColor(Color _color)
	{
		// Let's do some validation. Make sure it's a valid color.
		//if (_color == Color.Red || _color == Color.Blue || _color == Color.Black || _color == Color.Silver)
		//{
		//	CarColor = _color;
		//}

		// With an enum, we don't need to validate
		CarColor = _color;
	}
}

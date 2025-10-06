using System;
using static System.Console;
using System.Globalization;
class CarDemo
{
	static void Main()
	{
		Car aCar = new Car("Tesla", 45);
		Car bCar = new Car("Ford");
		
		WriteLine("Car #1 Before >> Model {0}, MPG {1}", aCar.Model, aCar.Mpg);
		WriteLine("Car #2 Before >> Model {0}, MPG {1}", bCar.Model, bCar.Mpg);
		aCar++;
		bCar++;
		WriteLine("Car #1 After >> Model {0}, MPG {1}", aCar.Model, aCar.Mpg);
		WriteLine("Car #2 After >> Model {0}, MPG {1}", bCar.Model, bCar.Mpg);
	}
}

class Car 
{
	public string Model {get; set;}
	public double Mpg {get; set;}

	public Car(string model, double mpg)
	{
		Model = model;
		Mpg = mpg;
	}
	public Car(string model) 
	{
		Model = model;
		Mpg = 20;
	}
	public static Car operator ++ (Car car)
	{
		car.Mpg++;
		return car;
	}
}
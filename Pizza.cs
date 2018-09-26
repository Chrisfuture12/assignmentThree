using System;

namespace assignemntThree
{
	class Pizza
	{
		const int small = 5;
		const int large = 8;

		public static void Main()
		{
		   DisplayTitle();
		   double numPizza = getInput("chris");
		   double numPizza2 = getInput("rafay");
		   double numPizza3 = getInput("darren");
		   // double diameter = 
		   double totalDiameter = calculateDiameter();
		   double allEaters = calculateEaters();
		   displayResults(totalDiameter);
		   displayResults(allEaters);
		}
		public static void DisplayTitle()
		{
            Console.WriteLine("Pizza calculator: Presented by chris morris");
		}
		public static double getInput(string x)
		{
			string userIn;
			Console.WriteLine("how many pizzas do you want " + x + " ?");
			userIn = Console.Readline();
			double pizzaNum = double.Parse(userIn);
            return pizzaNum; // or  return double.Parse(inputValue);
		}
		public static double inputDiameter()
		{
			string pizzaChoice;
			Console.WriteLine("You can order a small or large, What size would you like?");
			// Console.WriteLine("if desiring more information on sizes of the pizza enter 'sizes'");
			pizzaChoice = Console.Readline();
			return pizzaChoice;
		}
		public static double calculateEaters(double )
		{}
		public static void displayResults()
		{
			Console.WriteLine("The diameter of all of the pizzas togeather is " + totalDiameter + " in inches.");
			Console.WriteLine("The number of eaters will be " + allEaters + ".");
		}

	}
}

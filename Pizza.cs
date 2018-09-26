using System;

namespace assignemntThree
{
	class Pizza
	{
		//const int small = 5;
		//const int large = 8;
		// int Eaters;
		// string chris;
		// string rafay;
		// string darren;

		public static void Main()
		{
		   DisplayTitle();
		   double numPizza = getInput("chris");
		   string pizzaSize = inputDiameter("chris");
		   Console.ReadKey();
		  // double numPizza2 = getInput('rafay');
		  // double pizzaSize2 = inputDiameter('rafay');
		  // double numPizza3 = getInput('darren');
		   //double pizzaSize3 = inputDiameter('darren');
		   //double allEaters = calculateEaters();
		   //displayResults(numPizza);
		  // displayResults(allEaters);

		}
		public static void DisplayTitle()
		{
            Console.WriteLine("Pizza calculator: Presented by chris morris");
		}
		public static double getInput(string x)
		{
			string userInN;
			Console.WriteLine("how many pizzas do you want " + x + " ?");
			userInN = Console.ReadLine();
			double pizzaNum = double.Parse(userInN);
            return pizzaNum; // or  return double.Parse(inputValue);
		}
		public static string inputDiameter(string x)
		{
			string pizzaChoice;
			Console.WriteLine("You can order either a 'small' or 'large', What size would you like your pizza to be " + x +"? (Only 1 size per order).");
			// Console.WriteLine("if desiring more information on sizes of the pizza enter 'sizes'");
			pizzaChoice = Console.ReadLine();
			return pizzaChoice;
		}
		/*public static double calculateEaters(double )
		{}
		public static void displayResults(double x)
		{
			Console.WriteLine("The diameter of all of the pizzas for togeather is " + totalDiameter + " in inches.");
			//Console.WriteLine("The number of eaters will be " + allEaters + ".");
		}*/

	}
}

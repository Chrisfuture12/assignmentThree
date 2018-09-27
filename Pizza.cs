using System;

namespace assignemntThree
{
	class Pizza
	{
		  int smallPrice = 10; // instance variable 
		  int largePrice = 16; 
		  int numPizza;
			
		  Pizza(int numPizza){
			  this.numPizza = numPizza;
		  }

		  




		public static void DisplayTitle()
		{
            Console.WriteLine("Pizza calculator: Presented by chris morris");
		}
		
		public static double getInput(string x)
		{
			string userInN;
			Console.WriteLine("how many pizzas do you want " + x + "?");
			userInN = Console.ReadLine();
			double pizzaNum = double.Parse(userInN);
            return pizzaNum;
		}
		public static string inputDiameter(string x)
		{
			string pizzaChoice;
			Console.WriteLine("You can order either a 'small' or 'large', What size would you like your pizza to be " + x +"? (Only 1 size per order).");
			pizzaChoice = Console.ReadLine();
			return pizzaChoice;
		}

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
		
		
		
		/* public static double calculateCost(double x, string y)
		{
			if (y == "small") 
			{
				return smallPrice*x;
			} 
			else if (y == "large") 
			{
				return largePrice*x;
			}
		}

		public static double calculateEaters(double )
		{}
		public static void displayResults(double x)
		{}*/

	}
}

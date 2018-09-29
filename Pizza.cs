using System;

namespace assignemntThree
{
	class Pizza
	{
		static int smallPrice = 10; // class variable 
		static int largePrice = 16; // only static variables can be used with static methods.
		static int smallSize = 8;
		static int largeSize = 16;



		public static void DisplayTitle()
		{
            Console.WriteLine("Pizza calculator: Presented by chris morris");
		}
		public static int numEaters()
		{
			string userInE;
			Console.WriteLine("\nHow many people will be eating?");
			userInE = Console.ReadLine();
			int eatNumber = int.Parse(userInE);
			return eatNumber;
		}
		public static double getInput()
		{
			string userInN;
			Console.WriteLine("\nhow many pizzas do you want?");
			userInN = Console.ReadLine();
			double pizzaNum = double.Parse(userInN);
            return pizzaNum;
		}
		public static string inputDiameter()
		{
			string pizzaChoice;
			Console.WriteLine("\nYou can order either a 'small' or 'large', What size would you like your pizza to be? (Only 1 size per order).");
			Console.WriteLine("For more information regarding the size of the pizza and price, enter 'sizes'.");
			pizzaChoice = Console.ReadLine();
			if (pizzaChoice == "sizes"){
				Console.WriteLine("\nThe small pizza cost $10 and is 8 inches in diameter.");
				Console.WriteLine("The large pizza cost $16 and is 16 inches in diameter.");
				Console.WriteLine("Please enter your desired size: 'small' or 'large'.");
				pizzaChoice = Console.ReadLine();
			} 
			return pizzaChoice;
		}
		public static double calculateCost(string x, double y)
		{ 
			 if (x == "small") 
			{
				double orderTotal = smallPrice*y;
				return orderTotal;
			} 
			else if (x == "large") 
			{
				double orderTotal = largePrice*y;
				return orderTotal;
			} else
			{
				Console.WriteLine("Wrong!");
				return 0;
			}
		}
		public static double calcSlicePer(string x, double z, double y){
			if (x == "small") 
			{
				double sizePerPer = smallSize/y*z;
				return sizePerPer;
			} 
			else if (x == "large") 
			{
				double sizePerPer = largeSize/y*z;
				return sizePerPer;
			} else
			{
				Console.WriteLine("Wrong!");
				return 0;
			}
		}
		public static void displayResults(double a, double b, string c, double d, double e)
		{
			Console.WriteLine("");
			Console.WriteLine("\t Order report:");
			Console.WriteLine("\t The number of people eating will be: "+a+".");
			Console.WriteLine("\t The number of pizzas ordered will be: "+b+".");
			Console.WriteLine("\t The size of the pizza(s) will be: "+c+".");
			Console.WriteLine("\t Each person will get: "+d+" total inches of pizza, if equally split.");
			Console.WriteLine("\t The cost of the order will be: $"+e+".");
		}
		public static void Main()
		{
		   DisplayTitle();
		   double numPplEat = numEaters();
		   double numPizza = getInput();
		   string pizzaSize = inputDiameter();
		   double sizePer = calcSlicePer(pizzaSize, numPizza,numPplEat);
		   double orderCost = calculateCost(pizzaSize,numPizza);
		   displayResults(numPplEat,numPizza,pizzaSize,sizePer,orderCost);
		   Console.ReadKey();
		}
	}
}

using System;

namespace Niflheim
{	
	class MainClass
	{
		public static void Main (string[] args)
		{			
			Console.WriteLine ("Welcome to Niflheim!");

			int b = 0;
			int a = 0;

			a = 5;

			int c = a + b;

			Console.WriteLine ("a: {0} ",a);
			Console.WriteLine ("a: " + a);
			Console.WriteLine ("a: {0}, b: {1}, c: {2}. ({0} + {1} = {2})", a, b, c);

			bool isOpen = true;
			string input = Console.ReadLine ();

			if( input == "open")
			{			
				isOpen = true;
			}
			else if (input == "close")
			{
				isOpen = false;
			}

			if (isOpen == true) 
			{
				Console.WriteLine ("Je otevřeno, zavírám...");
				isOpen = false;
			} 
			else 
			{
				Console.WriteLine ("Je zavřeno, otevírám...");
				isOpen = true;
			}

			Console.WriteLine (isOpen);


			Console.ReadKey ();
		}
	}
}

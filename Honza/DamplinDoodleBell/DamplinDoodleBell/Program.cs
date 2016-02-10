using System;

namespace DamplinDoodleBell
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			int b = 0;
			int a = 0;
			a = 5;
			bool isOpen = false;
			string input = Console.ReadLine ();

			int c = a + b;

			if (input == "open") {
				isOpen = true;
			} else if (input == "close") 
			{
				isOpen = false;
			}

			Console.WriteLine ("a:{0}", a);
			Console.WriteLine ("a: " +a);
			Console.WriteLine ("a:{0} b:{1} C:{2}",a, b, c); 
			if (isOpen == true) 
			{
				Console.WriteLine ("Okno je otevřené, zavírám...");
				isOpen = false;
			} 
			else 
			{
				Console.WriteLine ("Okno je zavřené...");
				isOpen = true;
			}

			Console.WriteLine (isOpen);

			Console.ReadKey ();
		}
	}
}

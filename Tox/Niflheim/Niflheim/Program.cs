using System;

namespace Niflheim
{	
	class MainClass
	{
		static void RandomWhat()
		{
			string[] answers = new string[3] {"Sorry what?", "I did not get that one.", "Hmm, I do not understand."};
			Random rnd = new Random();
			int randomIndex = rnd.Next (0, answers.Length);													

			Console.WriteLine (answers[randomIndex]);
		}

		public static void Main (string[] args)
		{			
		
			Start:
			string travellerName = "";
			bool exit = false;	
			bool entered = false;
			int daysSurvived = 0;
			Console.Clear ();
			Console.WriteLine ("You see big stone portal glowing with green light. And hear dark deep voice..");
			Console.WriteLine ("Greetings traveller! So you wish to enter to realm of Niflheim?");

			while (!exit) 
			{				
				string answer = Console.ReadLine ();

					switch (answer.Trim ().ToLower ()) {
					case "yes":
						{
							Console.WriteLine ("Of course you wish! Tell me your name traveller:");	
							travellerName = Console.ReadLine ();

							entered = true;
							exit = true;
							break;
						}
					case "no":
						{
							Console.WriteLine ("So get out! Why are you bothering me? (TIP: Type exit to leave)");						
						break;
						}
					case "exit":
					case "quit":
					case "leave":
						{							
							exit = true;
							break;
						}
					default:
						{
							RandomWhat ();
							break;
						}											
					}											
			}

			if (entered) 
			{
				exit = false;
				Console.WriteLine ("Welcome to Niflheim {0}!", travellerName);
				Console.WriteLine ("What you wanna do? (TIP: Type HELP for help.)");
				while(!exit)
				{					
					string command = Console.ReadLine();
					switch (command.Trim().ToLower())
					{
					case "eat":
						{
							Console.WriteLine ("What you want to eat? There is only snow and rocks");
							break;
						}
					case "live":
						{
							Random rnd = new Random();
							int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
							Console.WriteLine ("Started to live in realm of Niflheim.");
							if (dice < 4)
							{
								daysSurvived++;
								Console.WriteLine ("Congratulation {0}, you survived a day in Niflheim! this was your {1}. day.",travellerName, daysSurvived);
							}
							else
							{																
								Console.WriteLine("But the horrible freezing weather killed you.");
								Console.WriteLine ("Sorry, this is where your journey ends, you survived for {0} days...",daysSurvived);
								Console.WriteLine ("And no one will remember you, {0}...", travellerName);
								Console.WriteLine ();
								Console.WriteLine ("Gods gave you another chance do you wish to try to go to Niflheim again? (yes/no");
								string again = Console.ReadLine ();
								if(again == "yes")
								{									
									goto Start;
								}
								else
								{
									exit = true;		
								}
							}

							break;
						}
					case "help":
						{
							Console.WriteLine ("You can EXIT or QUIT to leave program. Also you can try to LIVE, EAT");
							break;
						}
					case "exit":
					case "leave":
					case "quit":
					case "qq":
						{
							exit = true;
							break;
						}
						default:
						{
							
							RandomWhat ();
							break;
						}

					}

				}

			}
				
			Console.WriteLine ();
			Console.WriteLine ("Farewell! (Press any key to end program)");			
			Console.ReadKey ();
		}
	}
}

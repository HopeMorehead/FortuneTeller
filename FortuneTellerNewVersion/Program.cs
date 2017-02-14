using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String transportation = "";
            string vacation = "";
            string bankAccount = "";

            while (true)
            {

                Console.WriteLine("What is your  first name?");
                string firstName = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();

                Console.WriteLine("What is your age?");
                int userAge = int.Parse(Console.ReadLine());

                if (userAge > 80)
                    Console.WriteLine("Much respect for elders!");


                Console.WriteLine("What month were you born?");
                int userBirthMonth = int.Parse(Console.ReadLine());


                Console.WriteLine("What is your favorite ROYGBIV color? If you do not know enter help.");
                string favColor = Console.ReadLine();
                {
                    switch (favColor.ToLower())
                    {
                        case "help":
                            string[] royColors = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
                            foreach (string arrayColors in royColors)
                                Console.WriteLine(arrayColors);
                            Console.WriteLine("Pick a color.");
                            Console.ReadLine();
                            break;
                    }
                }
                Console.WriteLine("How many siblings do you have?");
                int siblingNum = int.Parse(Console.ReadLine());

                Console.WriteLine((userAge % 2 == 0) ? "You will retire in 6 years for tax purposes." : "You will retire in 7 years for tax purposes.");

                switch (siblingNum)
                {
                    case 0:
                        vacation = "You will have a vacation home in Tokyo, Japan.";
                        break;
                    case 1:
                        vacation = "You will have a vacation home in Paris, France.";
                        break;
                    case 2:
                        vacation = "You will have a vacation home in Alexandria, Egypt.";
                        break;
                    default:
                        Console.WriteLine("No vacation for you!");
                        break;
                }
                if (siblingNum < 0)
                {
                    vacation = "You will have a vacation home in the sewers.";
                    if (siblingNum >= 3)
                    {
                        vacation = "you will have a vacation home in Cleveland, U.S.A";
                    }
                }

                switch (favColor.ToLower())

                {
                    case "red":
                        transportation = "You will drive a red Corvet!";
                        break;
                    case "orange":
                        transportation = "You will drive an orange Yamaha motocycle!";
                        break;
                    case "yellow":
                        transportation = "You will ride in a big yellow taxi!";
                        break;
                    case "green":
                        transportation = "You will fly a green Piper Cherokee plane!";
                        break;
                    case "blue":
                        transportation = "You will often row a little blue row boat!";
                        break;
                    case "indigo":
                        transportation = "You will use indigo city buses!";
                        break;
                    case "violet":
                        transportation = "You will use violet rollerblades for mobility!";
                        break;
                    default:
                        transportation = "You will use your feet to get around town!";
                        break;
                }

                if (userBirthMonth <= 4 && userBirthMonth > 0)

                    bankAccount = "You have 10000.00 dollars in the bank.";

                else if (userBirthMonth >= 5 && userBirthMonth <= 8)

                    bankAccount = "You have 20000.00 dollars in the bank.";

                else if (userBirthMonth >= 9 && userBirthMonth <= 12)

                    bankAccount = "You have 30000.00 dollars in the bank.";

                else if (userBirthMonth <= 0)

                    bankAccount = "You have 0.00 dollars in the bank.";

                else

                    bankAccount = "Your bank account is -10.0000.";


                Console.WriteLine(vacation + "\n" + transportation + "\n" + bankAccount + "\n");



                {
                    Console.WriteLine("GAME OVER QUIT NOW! type quit");
                    string input = Console.ReadLine();

                    if (input == "quit" || input == "exit")
                        break;


                }
            }
        }
    }
}


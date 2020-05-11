using System;

namespace dotnet_mini_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //int count = 0;
        //int maxTries = 2;
        //while(true) {
            try
            {
                Console.WriteLine("Hi There! This tiny App will ask you for 2 numbers and do any operation you decide with them.");
                float getFirstNumber;
                Console.Write("Shoot the first number: ");
                getFirstNumber = Convert.ToInt32(Console.ReadLine());
                float getSecondNumber;
                Console.Write("Shoot the second number: ");
                getSecondNumber = Convert.ToInt32(Console.ReadLine());
                int chooseOperation;
                Console.WriteLine("What operation you would like to perform with the numbers you've chosen? (1 - Add, 2 - Substruct, 3 - Multiply, 4 - Division)");
                chooseOperation = Convert.ToInt32(Console.ReadLine());

                switch(chooseOperation)
                {
                  case 1:
                    Console.WriteLine("Result of add operation: " + (getFirstNumber + getSecondNumber));
                    break;
                    case 2:
                    Console.WriteLine("Result of substruct operation: " + (getFirstNumber - getSecondNumber));
                    break;
                    case 3:
                    Console.WriteLine("Result of multiply operation: " + (getFirstNumber * getSecondNumber));
                    break;
                    case 4:
                        if (getSecondNumber != 0) 
                        Console.WriteLine("Result of division operation: " + (getFirstNumber / getSecondNumber));
                        else Console.WriteLine("Sorry, can't divide by O!");
                    break;
                    default: // Statement executed if no case matches
                    Console.WriteLine("You can choose between 1-4 only!");
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("You can use only numbers!", ex.Message);
                //if (count++ == maxTries) throw new Exception("You can use only numbers!");
            }
        //}

        }
    }
}
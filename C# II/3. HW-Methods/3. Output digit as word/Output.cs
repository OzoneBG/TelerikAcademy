using System;

//Write a method that returns the last digit of given
//integer as an English word. Examples: 512  "two",
//1024  "four", 12309  "nine".


    class Output
    {
        //The method
        static void OutputDigitAsWord(string input)
        {
            //Declare a variable
            char toSwitch = new char();

            //Finding the last character
            for (int i = 0; i < input.Length; i++)
			{
			    if (i == input.Length - 1)
                {
                    toSwitch = input[i];
                }
	
		    }
            
            //Converting it to int32
            int converted = toSwitch - '0';


            //Outputing it as a word
            switch (converted)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

            }
        }

        static void Main()
        {
            //Input and variables
            Console.Write("Input your string! => ");
            string input = Console.ReadLine();

            //Using the method
            OutputDigitAsWord(input);
        }
    }


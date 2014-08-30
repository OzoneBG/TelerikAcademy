using System;

//Write a program that creates an array containing all 
//letters from the alphabet (A-Z). Read a word from
//the console and print the index of each of its letters
//in the array.


    class Alphabet
    {
        static void Main()
        {
            //Input and variables
            char[] alphabet = new char[26] {'A', 'B', 'C', 'D', 'E',
                                            'F', 'G', 'H', 'I', 'J',
                                            'K', 'L', 'M', 'N', 'O',
                                            'P', 'Q', 'R', 'S', 'T',
                                            'U', 'V', 'W', 'X', 'Y', 
                                            'Z'};

            Console.Write("Hello! Please write any word to find it's alphabet numbers: ");
            string word = Console.ReadLine();

            //Find each char's number

            Console.WriteLine("The \"{0}\" represented by numbers will be: ", word);

            for (int w = 0; w < word.Length; w++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if(Char.ToUpper(word[w]) == Char.ToUpper(alphabet[i]))
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
            Console.WriteLine();
        }
    }


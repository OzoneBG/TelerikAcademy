using System;

//Write a program that fills and prints a matrix of size
//(n, n) as shown below: (examples for n = 4)


    class Matrix
    {
        static void Main()
        {
            //Input and variables
                //Console.WriteLine("Input N: ");
                //int N = int.Parse(Console.ReadLine());

            //In case N = 4
            int N = 4;
            int[,] matrix = new int[N, N];
            int value = 1;

            //Condition A
            Console.WriteLine("Condition A: ");
            Console.WriteLine();
            Console.WriteLine();
            for (int rows = 0; rows < N; rows++)
            {
                for (int cols = 0; cols < N; cols++)
                {
                    matrix[cols, rows] = value;
                    value++;
                }
            }

            
            for (int row = 0; row < N; row++)
            {
                for (int cols = 0; cols < N; cols++)
                {
                    Console.Write("{0} ", matrix[row, cols]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            //End of Condition A

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Condition B:
            value = 1;
            Console.WriteLine("Condition B: ");
            Console.WriteLine();
            Console.WriteLine();

            for (int rows = 0; rows < N; rows++)
            {
                if (rows % 2 == 0)
                {
                    for (int cols = 0; cols < N; cols++)
                    {
                        matrix[cols, rows] = value;
                        value++;
                    }
                }
                else
                {
                    for (int cols = N-1; cols >= 0; cols--)
                    {
                        matrix[cols, rows] = value;
                        value++;
                    }
                }
            }

            for (int row = 0; row < N; row++)
            {
                for (int cols = 0; cols < N; cols++)
                {
                    Console.Write("{0} ", matrix[row, cols]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            //End of Condition B

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Condition C:
             Console.WriteLine("Condition C: ");
            Console.WriteLine();
            Console.WriteLine();
            value = 1;
            int columns = 0;
            int rowss = 0;

            for (int i = N - 1; i >= 0; i--)
            {
                rowss = i;
                columns = 0;
                while (rowss < N && columns < N)
                {
                    matrix[rowss++, columns++] = value++;
                }
            }

            for (int j = 1; j < N; j++)
            {
                rowss = j;
                columns = 0;
                while (rowss < N && columns < N)
                {
                    matrix[columns++, rowss++] = value++;
                }
            }

            for (int row = 0; row < N; row++)
            {
                for (int cols = 0; cols < N; cols++)
                {
                    Console.Write("{0} ", matrix[row, cols]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            //End of Condition C
        }
    }


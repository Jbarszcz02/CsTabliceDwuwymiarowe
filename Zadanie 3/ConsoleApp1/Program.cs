using System;

namespace Cw_6_zajecia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int size;
            bool isValidSize = int.TryParse(Console.ReadLine(), out size);

            if (!isValidSize || size <= 0)
            {
                Console.WriteLine("Niepoprawny rozmiar tablicy.");
                return;
            }

            int[,] array = new int[size, size];

            int currentCol = 0;
            int currentRow = 0;
            int direction = 0; // 0 - prawo; 1 - dół; 2 - lewo; 3 - góra

            for (int currentNumber = 1; currentNumber <= size * size; currentNumber++)
            {
                array[currentRow, currentCol] = currentNumber;
                switch (direction)
                {
                    case 0: //right
                        if (currentCol + 1 >= size || array[currentRow, currentCol + 1] != 0)
                        {
                            direction = 1;
                            currentRow++;
                        }
                        else
                        {
                            currentCol++;
                        }
                        break;
                    case 1: //down
                        if (currentRow + 1 >= size || array[currentRow + 1, currentCol] != 0)
                        {
                            direction = 2;
                            currentCol--;
                        }
                        else
                        {
                            currentRow++;
                        }
                        break;
                    case 2: //left
                        if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                        {
                            direction = 3;
                            currentRow--;
                        }
                        else
                        {
                            currentCol--;
                        }
                        break;
                    case 3: //up
                        if (array[currentRow - 1, currentCol] != 0)
                        {
                            direction = 0;
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Tablica {0}x{0}:", size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,3} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
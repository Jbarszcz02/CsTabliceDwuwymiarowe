using System;

namespace Ćw_6_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Size = 10;

            int[,] array = new int[Size, Size];

            int currentCol = 0;
            int currentRow = 0;
            int direction = 0; // 0 - prawo; 1 - dół; 2 - lewo; 3 - góra

            for (int currentNumber = 1; currentNumber <= Size * Size; currentNumber++)
            {
                array[currentRow, currentCol] = currentNumber;
                switch (direction)
                {
                    case 0: //right
                        if (currentCol + 1 >= Size || array[currentRow, currentCol + 1] != 0)
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
                        if (currentRow + 1 >= Size || array[currentRow + 1, currentCol] != 0)
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

            Console.WriteLine("Tablica{0}x{0}:", Size);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("{0,3} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

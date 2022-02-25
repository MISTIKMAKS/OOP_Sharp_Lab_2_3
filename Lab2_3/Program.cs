using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    class Program
    {

    static void Create(int[,] a, int rowCount, int colCount, int Low, int High)
    {
        Random random = new Random();
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                //-------Random-------
                a[i, j] = random.Next(Low, High);
                //-------Input-------
                //Console.Write("a[" + i + ", " + j + "] = ");
                //a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
    }
    static void Print(int[,] a, int rowCount, int colCount)
    {
        Console.WriteLine("");
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                Console.Write(a[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
    static void Sort(int[,] a, int rowCount, int colCount)
    {
    for (int j0 = 0; j0 < colCount - 1; j0++) {
        for (int j1 = 0; j1 < colCount - j0 - 1; j1++) {
            if ((a[0, j1] < a[0, j1 + 1]) || (a[0, j1] == a[0, j1 + 1] && a[1, j1] < a[1, j1 + 1]) || (a[0, j1] == a[0, j1 + 1] && a[1, j1] == a[1, j1 + 1] && a[2, j1] > a[2, j1 + 1])) {
                Change(a, j1, j1 + 1, rowCount);
            }
        }
    }
}
    static void Change(int[,] a, int col1, int col2, int rowCount)
    {
        int tmp;
        for (int i = 0; i < rowCount; i++)
        {
            tmp = a[i, col1];
            a[i, col1] = a[i, col2];
            a[i, col2] = tmp;
        }
    }
    static void Calc(int[,] a, int rowCount, int colCount, int S, int k)
    {
        S = 0;
        k = 0;
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                if (!(a[i, j] < 0) && (a[i, j] % 3 == 0))
                {
                    S += a[i, j];
                    k++;
                    a[i, j] = 0;
                }
            }
        }
        Console.WriteLine("S = " + S);
        Console.WriteLine("k = " + k);
    }
    static void Main(string[] args)
    {
        int Low = -21;
        int High = 24;
        int rowCount = 9;
        int colCount = 6;
        int[,] a = new int[rowCount, colCount];
        //-------Done-------
        //int[,] a = new int[9, 6] { { -7, -11, 13, -2, 19, 24 }, { 20, 19, -2, 13, 3, -17 }, { -17, -14, 14, 4, 13, -3 }, { -7, 4, 18, -1, -16, 6 }, { 13, 0, -8, 3, 3, 13 }, { 22, -5, 1, -18, 1, 19 }, { 23, -3, -20, 7, -18, 7 }, { -11, -7, 20, 7, -4, 8 }, { -6, 22, 6, 0, 19, 15 } };
        Create(a, rowCount, colCount, Low, High);
        Print(a, rowCount, colCount);
        Sort(a, rowCount, colCount);
        Print(a, rowCount, colCount);
        int S = 0;
        int k = 0;
        Calc(a, rowCount, colCount, S, k);
        Print(a, rowCount, colCount);
        Console.ReadKey();
        }
    }
}

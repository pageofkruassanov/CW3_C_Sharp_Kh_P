using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3_C_Sharp_Kh_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE_ARR = 10;
            int[] firstArr = new int[SIZE_ARR];
            int[] secondArr = new int[SIZE_ARR];
            Random random = new Random();
            for (int i = 0; i < SIZE_ARR; i++)
            {
                firstArr[i] = random.Next(1, 10);
            }
            for (int i = 0; i < SIZE_ARR; i++)
            {
                secondArr[i] = random.Next(1, 10);
            }
            int[] tempArr = new int[SIZE_ARR + SIZE_ARR];
            int k = 0;
            for (int i = 0; i < SIZE_ARR; i++)
            {
                if (tempArr.Length > 0)
                {
                    bool isFound = false;
                    int tempNum = firstArr[i];
                    for(int j = 0; j < tempArr.Length; j++) 
                    {
                        if ((tempArr[j] == tempNum)) 
                        {
                            isFound = true;
                            break;
                        }
                    }
                    if(isFound == false) 
                    {
                        tempArr[k] = tempNum;
                        k++;
                    }
                }
            }
            for (int i = 0; i < SIZE_ARR; i++)
            {
                if (tempArr.Length > 0)
                {
                    bool isFound = false;
                    int tempNum = secondArr[i];
                    for (int j = 0; j < tempArr.Length; j++)
                    {
                        if ((tempArr[j] == tempNum))
                        {
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound == false)
                    {
                        tempArr[k] = tempNum;
                        k++;
                    }
                }
            }
            int[] thirdArr = new int[k];
            for(int i = 0; i < thirdArr.Length; i++) 
            {
                thirdArr[i] = tempArr[i];
            }
            Console.WriteLine("Первый массив: ");
            for(int i = 0; i < SIZE_ARR; i++) 
            {
                Console.Write(firstArr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Второй массив: ");
            for(int i = 0;i < SIZE_ARR; i++) 
            {
                Console.Write(secondArr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Третий массив: ");
            for (int i = 0; i < thirdArr.Length; i++)
            {
                Console.Write(thirdArr[i] + " ");
            }
            Console.ReadLine();
        }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            seventyExercise();
        }
        static void seventyExercise()
        {
            int[][] arr = new int[][] 
            { 
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0}
            };


            List<int> arrayHourGlasses = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arrayHourGlasses.Add(arr[0 + i][0 + j] + arr[0 + i][1 + j] + arr[0 + i][2 + j] + arr[1 + i][1 + j] + arr[2 + i][0 + j] + arr[2 + i][1 + j] + arr[2 + i][2 + j]);
                }
            }

            Console.WriteLine(arrayHourGlasses.Max());
        }
        static void sixtyExercise()
        {
            int[] a = {1, 2, 3, 4, 5};
            int d = 4;
            // Complete the rotLeft function below.

            int size = a.Length;
            int[] rotated_arr = new int[size];

            int i = 0;
            int rotate_index = d;

            while (rotate_index < size)
            {
                rotated_arr[i] = a[rotate_index];
                i++;
                rotate_index++;

            }

            rotate_index = 0;
            while (rotate_index < d)
            {
                rotated_arr[i] = a[rotate_index];
                i++;
                rotate_index++;
            }

            foreach (int arrElement in rotated_arr)
            {
                Console.WriteLine(arrElement);
            }
        }
        static void fiftyExercise()
        {
            int[] arr = { 3, 3, 2, 1, 3 };
            Dictionary<int, int> dictNumbers = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int previous_value = 0;


                    if (dictNumbers.TryGetValue(arr[i], value: out previous_value))
                    {
                        dictNumbers.Remove(arr[i]);
                    }
                dictNumbers.Add(arr[i], ++previous_value);
            }
            foreach (KeyValuePair<int, int> keyValuePair in dictNumbers)
            {

                Console.WriteLine("Number: {0}, Quantity: {1}", keyValuePair.Key, keyValuePair.Value);
            }

        }
        static void fourtyExercise()
        {
            string s = "gfcaaaecbg";
            long n = 24;
            long sizeString = s.Length;
            long timesToMultiple = n / sizeString;
            long moduleDivision = n % sizeString;
            long count = 0;
            for (int i = 0; i < n && i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                }
            }

            long result = count;
            if (timesToMultiple > 0)
            {
                result = count * timesToMultiple;
                if (moduleDivision != 0)
                {
                    for (int i = 0; i < n - (s.Length * timesToMultiple); i++)
                    {
                        if (s[i] == 'a')
                        {
                            result++;
                        }
                    }
                }
            }
            
            Console.WriteLine("Result: {0}", result);

        }
        static void thirdExercise()
        {

        }
        static void secondExercise()
        {
            int n = 8;
            string s = "DDUDUDDUDDUDDUUUUDUDDDUUDDUUDDDUUDDUUUUUUDUDDDDUDDUUDUUDUDUUUDUUUUUDDUDDDDUDDUDDDDUUUUDUUDUUDUUDUDDD";
            int qtdValley = 0;
            int actualLevel = 0;
            bool isOnValley = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                {
                    actualLevel++;
                }
                else if (s[i] == 'D')
                {
                    actualLevel--;
                }

                if (actualLevel < 0 && !isOnValley)
                {
                    isOnValley = !isOnValley;
                    qtdValley++;
                }
                else if (actualLevel >= 0 && isOnValley)
                {
                    isOnValley = !isOnValley;
                }
            }
            Console.WriteLine("The quantity of valleys are: {0}, and the actual level of the player is: {1}", qtdValley, actualLevel);
        }
        static void firstExercise()
        {
            Dictionary<string, int> teste = new Dictionary<string, int>();
            int[] ar = {
                10,
                20,
                10,
                20,
                10,
                5,
                3,
                3,
                1
            };
            for (int i = 0; i < ar.Length; i++)
            {
                if (teste.ContainsKey(ar[i].ToString()))
                {
                    int resultado;
                    if (teste.TryGetValue(ar[i].ToString(), out resultado))
                    {
                        teste.Remove(ar[i].ToString());
                        teste.Add(ar[i].ToString(), ++resultado);

                    }
                }
                else
                {
                    teste.Add(ar[i].ToString(), 1);
                }
            }
            foreach (KeyValuePair<string, int> keyValuePair in teste)
            {
                Console.WriteLine("A meia com cor de ID {0} contém {1} par(es).", keyValuePair.Key, keyValuePair.Value / 2);
            }
        }
    }
}

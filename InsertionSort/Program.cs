using System;

namespace SortiertAlgorithmen
{
    class Program
    {
        static string GetInputForAlgorithm()
        {
            Console.WriteLine("Insertion-Sort");
            Console.WriteLine($"Sortieren durch einfügen\n");

            Console.WriteLine("Geb eine beliebige Zahlenfolge ohne Leerzeichen ein!(Bsp.:1234546789)");
            return Console.ReadLine();
        }
        static int[] InputCharaktarToInt(char[] tempCharaktarArray)
        {
            int count = 0;
            int[] inputCharaktarToInt = new int[tempCharaktarArray.Length];

            try
            {
                foreach (var charkter in tempCharaktarArray)
                {
                    inputCharaktarToInt[count] = Convert.ToInt32(Char.GetNumericValue(charkter));
                    count++;
                }

                return inputCharaktarToInt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        static void StartAlgorithm(int[] intArray)
        {
            InsertionSort insertionSortAlgorithmen;
            insertionSortAlgorithmen = new InsertionSort(intArray);
            insertionSortAlgorithmen.SortArray();
            Console.WriteLine(insertionSortAlgorithmen.ToString());
        }

        static void Main(string[] args)
        {
            string input = GetInputForAlgorithm();
            char[] singleInputCharaktar = null;
            int[] intArray = null;

            if (input != null)
            {
                singleInputCharaktar = input.ToCharArray();
                intArray = InputCharaktarToInt(singleInputCharaktar);
            }
            else
            {
                Console.WriteLine($"\nEingabe war nicht korrekt. Insertion-Sort wird beendet");
            }

            if (intArray != null)
                StartAlgorithm(intArray);



        }
    }
}
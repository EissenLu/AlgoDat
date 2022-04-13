using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Timers;

namespace SortiertAlgorithmen
{
    public class InsertionSort
    {
        private int[] _input;
        private int[] _copyInput;
        private long elapsedTime = 0;
        private Stopwatch time;

        public InsertionSort(int[] input)
        {
            this._input = input;
            time = new Stopwatch();
        }

        public void SortArray()
        {
            time.Start();
            
            for (int i = 1; i < _input.Length; i++)
            {
                int key = _input[i];
                int j = i - 1;

                while (j > -1 && _input[j] > key)
                {
                    _input[j + 1] = _input[j];
                    j = j - 1;
                }
                _input[j+1] = key;
            }
            
            time.Stop();
            elapsedTime = time.ElapsedMilliseconds;
            time.Reset();
        }

        public override string ToString()
        {
            string outputString = $"\nArray nach Sortierung: ";
            foreach (var zahl in _input)
            {
                outputString += $"{zahl} ";
            }

            outputString += $"\n\nBenötigte Zeit: {elapsedTime} milliseconds";

            return outputString;
        }
    }
}
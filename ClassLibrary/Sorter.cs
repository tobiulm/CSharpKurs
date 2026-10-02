using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    public class Sorter
    {

        private delegate bool CompareFunction(int x, int y);


        private static bool CompareAscending(int x, int y)
        {
            bool result = false;
            if (x > y)
            {
                result = true;
            }
            return result;
        }


        private static bool CompareDescending(int x, int y)
        {
            bool result = false;
            if (x < y)
            {
                result = true;
            }
            return result;
        }


        public static void BubbleSort(int[] numbers, SortDirection direction)
        {
            int tempValue;

            CompareFunction pointer;
            if (direction == SortDirection.Ascending)
            {
                pointer = CompareAscending;
            }
            else
            {
                pointer = CompareDescending;
            }


            for(int i = 0; i <= numbers.GetUpperBound(0); i++)
            {
                tempValue = numbers[i];
                for (int j = i + 1; j <= numbers.GetUpperBound(0); j++)
                {
                    if(pointer(tempValue, numbers[j]))
                    {
                        numbers[i] = numbers[j];
                        numbers[j] = tempValue;
                        tempValue = numbers[i];
                    }
                    //if (direction == SortDirection.Ascending)
                    //{
                    //    if (CompareAscending(tempValue, numbers[j]))
                    //    {
                    //        numbers[i] = numbers[j];
                    //        numbers[j] = tempValue;
                    //        tempValue = numbers[i];
                    //    }
                    //}
                    //else
                    //{
                    //    if(CompareDescending(tempValue, numbers[j]))
                    //    {
                    //        numbers[i] = numbers[j];
                    //        numbers[j] = tempValue;
                    //        tempValue = numbers[i];
                    //    }
                    //}
                }
            }
        }
    }


    public enum SortDirection
    {
        Ascending,
        Descending
    }

}

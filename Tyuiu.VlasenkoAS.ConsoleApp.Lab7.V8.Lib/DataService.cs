using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab7.V8.Lib
{
    public class DataService
    {
        public int GetNegativeNumArray(int[] intArray)
        {
            int Get = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < 0)
                {
                    Get++;
                }
            }
            return Get;
        }
        public int GetPositiveNumArray(int[] intArray)
        {
            int Get = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] >= 0)
                {
                    Get++;
                }
            }
            return Get;
        }

        public int GetEvenNumArray(int[] intArray)
        {
            int Get = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    Get++;
                }
            }
            return Get;
        }

        public int GetNotEvenNumArray(int[] intArray)
        {
            int Get = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    Get++;
                }
            }
            return Get;
        }

        public Boolean GetNumArray(int[] intArray, int num)
        {
            Boolean flag = false;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == num)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public float GetMiddleNumArray(int[] intArray)
        {
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            float result = sum / intArray.Length;

            return result;
        }

        public int GetMinNumArray(int[] intArray)
        {
            int minNum = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (minNum > intArray[i])
                {
                    minNum = intArray[i];
                }
            }

            return minNum;
        }
    }
}

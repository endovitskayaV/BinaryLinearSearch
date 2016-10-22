using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLinearSearch
{
    class Search
    {
        public static int counter=0;

        static public int Linear (int[] inputArray, int digit)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                counter++;
                if (digit == inputArray[i])
                    return i;
            }
            return -1;
        }

        static public object Binary (int[] inputArray, int min, int max, int digit)
        {
            if (min > max)
            {
                return null;
            }
            else
            {
                int mid = (min + max) / 2;

                counter++;

                if (digit == inputArray[mid])
                {
                    return ++mid;
                }
                else {
                    if (digit < inputArray[mid])
                    {
                        return Binary(inputArray, min, mid-1, digit );
                    }
                    else
                    {
                        return Binary(inputArray, mid + 1, max, digit );
                    }
                }

            }
        }
    }
}

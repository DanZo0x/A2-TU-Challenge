using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 18)
            {
                if (age > 145)
                {
                    throw new ArgumentException();
                }
                return true;
            }
            else
            {
                if (age < 0)
                {
                    throw new ArgumentException();
                }
                return false;
            }
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrimary(int a)
        {
            if (a == 2 || a == 3)
            {
                return true;
            }

            if (a <= 1 || a % 2 == 0 || a % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= a; i += 6)
            {
                if (a % i == 0 || a % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> listPrimary = new List<int>();

            for (int i = 0; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    listPrimary.Add(i);
                }
            }

            return listPrimary;
        }

        public static int Power2(int a)
        {
            int result = a * a;
            return result;
        }

        public static int Power(int a, int b)
        {
            int result = a;

            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            else if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }

            return 0;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int temp = 0;

            for (int i = 0; i < toSort.Count - 1; i++)
            {
                for (int j  = i + 1; j < toSort.Count; j++)
                {
                    if (toSort[i] > toSort[j])
                    {
                        temp = toSort[i];
                        toSort[i] = toSort[j];
                        toSort[j] = temp;
                    }
                }
            }

            return toSort;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }
    }
}

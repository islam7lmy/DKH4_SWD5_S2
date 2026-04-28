using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal static class Helper
    {
        #region Ex01: Swap
        #region Non-Generics
        ///wirte static method to do swap betwwen two int numbers
        //public static void Swap(ref int a,ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //public static void Swap(ref string a, ref string b)
        //{
        //    string temp = a;
        //    a = b;
        //    b = temp;
        //}
        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
        #endregion
        #region Generics
        /// T => Template
        public static void Swap<hamada>(ref hamada a, ref hamada b)
        {
            hamada temp = a;
            a = b;
            b = temp;
        }
        #endregion
        #endregion

        #region EX02: Search
        #region Non-Generics
        ///write method take int[] array and int value 
        ///and return the first index of that value 
        ///and if not exists return -1
        public static int SearchArray(int[] arr, int value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == value)
                        return i;
                }
            }
            return -1;
        }
        #endregion
        #region Genrics
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }
        #endregion
        #endregion


    }
}

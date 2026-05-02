using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    //interface IGenricCompare<T> where T : IGenricCompare<T>
    //{
    //    static abstract bool operator >(T left, T right);
    //    static abstract bool operator <(T left, T right);
    //}

    interface ISum<T> where T : ISum<T>
    {
        static abstract T operator +(T left, T right);
    }

    internal static class Helper//<T> where T : IComparable<T>
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

        #region EX03: BubbleSort
        #region nonGenerics
        //write static method to do bubble sort on int[] arr
        //public static void BubbleSort(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSort(Employee[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}
        #endregion
        #region Genrics
        public static void BubbleSort<T,T1>(T[] arr) where T : IComparable<T> //Point,IComparable<T>,IEnumerable<T>,new() where T1 : class , IEnumerable<T1> //IComparable //IGenricCompare<T>
        {
            //T x = new T();
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #endregion
        #endregion
        ///c# 11 .net 7.0
        public static T Sum<T>(T x, T y) where T : INumber<T> //ISum<T>
        {
            return x + y;
        }

        #region Generics Constrains
        ///primary Constaint [0:1]
        ///1.general primary constraint
        ///         class => T Must Be Class
        ///         Struct => T must be struct
        ///         enum => T must be enum
        ///         notnull=> T Must Be Not Null (C# 8.0)
        ///         default => speacial case to use
        ///2.special Primary Constraint (User-Defined Class (Except Seald))
        ///         Point => T Must Be Point Or anthor class Inherits from point
        ///         
        ///secondary constaint (Interfaces) [0 : M]
        ///T Must Be Class / struct Implmenting Interface
        ///
        /// paramerterless Constructor Constraint [0 : 1]
        /// T must be datatype having accessable[Non - private] parameterless constructor
        /// can't use new() [constructor constraint] with struct [special primary constraint]


        #endregion
    }

    class Employee : IComparable<Employee> //IComparable
    {
        public Employee()
        {
            
        }
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string? ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        public int CompareTo(object? obj)
        {
            ////this keyword => refer to caller of method
            Employee other = (Employee) obj; // explicit cast [un safe cast]
            ////if (this.Salary > other.Salary)
            ////    return 1;
            ////else if(this.Salary < other.Salary)
            ////    return -1;
            ////else return 0;

            return this.Salary.CompareTo(other.Salary);



            //1. is Type Check : return true or false
            //obj is object of type "Employee"
            //obj is object of type inhert from "Employee"
            //if (obj is Employee hamada)
            //{
            //    return this.Salary.CompareTo(hamada.Salary);
            //}
            //else return +1;

            //2. as casting operator : refence type or nullable type
            //int? x = obj as int?;
            //Employee hamada = obj as Employee;
            //if (hamada is null) return +1;
            //return this.Salary.CompareTo(hamada.Salary);
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return +1;
            return this.Salary.CompareTo(other.Salary);
        }

        public static bool operator >(Employee left , Employee right)
        {
            return (left?.Salary ?? 0) > (right?.Salary ?? 0);
        }
        public static bool operator <(Employee left, Employee right)
        {
            return (left?.Salary ?? 0) < (right?.Salary ?? 0);
        }



    }
}

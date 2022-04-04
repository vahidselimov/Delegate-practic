using System;
using System.Collections.Generic;

namespace homework1
{

    internal class Program
    {
        #region Delegate

        //public delegate void Convert(int number);
        //public delegate bool Callback(int arr);
        //public delegate string Customcontan(string name, string surname);
        #endregion
        static void Main(string[] args)
        {
            #region practic1.1
            //int[] arr = { 12, 23, 32, 43, 56, 75, 89, 90, 20, 45 };
            //Console.WriteLine(sumeven(arr));
            //Console.WriteLine(sumid(arr));
            //Console.WriteLine(sumby(arr));
            //Console.WriteLine("\n Delegate \n");
            //Console.WriteLine(sum(arr, IsEven));

            //Console.WriteLine(sum(arr, Isby));

            //Console.WriteLine(sum(arr, Isid));
            #endregion practic1.1
            #region practic2.1
            //Customcontan customcontan = new Customcontan(Fullname);
            //Console.WriteLine(customcontan("Vahid", "Selimov"));
            //    Customcontan abr = Abr;
            //    Console.WriteLine(abr(Console.ReadLine(),Console.ReadLine()));
            //    Console.WriteLine(Fullname("vahid", "selimov"));
            #endregion
            #region practic3.1
            //Console.WriteLine("\n Multi Delegate \n");

            //ConvertDollar(12);

            //ConvertEuro(12);
            //Convert convert = new Convert(ConvertDollar);
            //Convert convert1 = ConvertEuro;
            //convert(13);
            //convert1(14);
            //convert1 += ConvertDollar;
            //convert1(12);

            //Convert convert2 = convert1 + ConvertDollar;
            //convert2(12);
            #endregion
            #region practic4.1
            //ANONYMOS METHODS
            //Convert converttoAzn = delegate (int num)
            //{
            //    Console.WriteLine(num + "Azn");
            //};
            ////converttoAzn(12);
            //converttoAzn += delegate(int num)
            //{

            //    Console.WriteLine(num + "TL");

            //};
            //converttoAzn(123);
            #endregion
            #region practic5.1  
            //lambda usulu
            //int ile
            //Callback callback1 = num => num % 2 == 0;
            //Console.WriteLine(callback1(1232132718));
            //String ile
            //Customcontan customcontan = (name, surname) => name + " " + surname;
            //Console.WriteLine(customcontan(Console.ReadLine(),Console.ReadLine()));
            //Void ile
            //Convert convert3 = number => Console.WriteLine(number % 2 == 0);
            //convert3(12);
            #endregion
            #region practic6.1
            //Action DELEGATE
            //Action<string,string> action = Foraction;
            //action(Console.ReadLine(),Console.ReadLine());
            #endregion
            #region practic7.1
            //FUNC DELEGATE!!!
            //Func<int> func = Test;
            //Console.WriteLine(func());

            //Func<string, int> func1 = delegate (string num)
            //    {
            //        int number;
            //        bool result = int.TryParse(num, out number);
            //        if (result)
            //        {
            //            return number;


            //        }
            //        return 0;
            //    };
            //Console.WriteLine(func1("2232"));
            #endregion
            #region practices8
            //Predicate<string> predicate = word => word[0] == 'A';
            //Console.WriteLine(predicate(Console.ReadLine()));
            //Predicate<string> predicate1 = word => word.Equals(word.ToUpper()) && word.Contains('A');
            //Console.WriteLine(predicate1("VAHID"));
            //List<int> list = new List<int>();

            //list.Add(20);
            //list.Add(2);
            //list.Add(12);
            //list.Add(30);
            //list.Add(21);

            //int number = list.Find(num => num % 3 == 0);



            //    Console.WriteLine(number);
            #endregion
        }

        #region practic1.2
        //public static int sum(int[] arr, Callback Method)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (Method(num))
        //        {
        //            total += num;
        //        }

        //    }
        //    return total;


        //}
        //public static int sumeven(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (IsEven(num))
        //        {
        //            total += num;
        //        }


        //    }
        //    return total;
        //}
        //public static int sumid(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (Isid(num))
        //        {
        //            total += num;
        //        }


        //    }
        //    return total;
        //}
        //public static int sumby(int[] arr)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (Isby(num))
        //        {
        //            total += num;

        //        }


        //    }
        //    return total;
        //}
        //public static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}
        //public static bool Isid(int number)
        //{
        //    return number % 2 == 1;
        //}
        //public static bool Isby(int number)
        //{
        //    return number % 3 == 0;
        //}




        #endregion
        #region practic2.2


        //public static string Fullname(string name, string surname)
        //{

        //    return $"{name} {surname}";

        //}
        //public static string Abr(string name,string surname)
        //{
        //    return $"{char.ToUpper(name[0])}.{char.ToUpper(surname[0])}";
        //}

        #endregion
        #region practic3.2
        public static void ConvertDollar(int number)
        {
            Console.WriteLine(number + "$");
        }
        public static void ConvertEuro(int number)
        {
            Console.WriteLine(number + "?");
        }
        #endregion
        #region practic6.2
        //public static void Foraction(string word,string word1)
        //{
        //    Console.WriteLine(word+" "+word1);
        //}
        #endregion   
        #region practic7.2
        public static int Test()
        {
            return 5;
        }
        #endregion
    }
}




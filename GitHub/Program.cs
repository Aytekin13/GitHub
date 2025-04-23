using System.Runtime.Intrinsics.X86;

namespace GitHub_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            /*Console.WriteLine("Birinci ededi daxil edin");
            int num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ikinci ededi daxil edin");
            int num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Üçüncü ededi daxil edin");
            int num3 = Convert.ToInt32((Console.ReadLine()));
            if (num1 > num2 & num1 > num3) { if (num2 > num3) { Console.WriteLine(num2); } else { Console.WriteLine(num3); } }
            else if (num2 > num1 & num2 > num3) { if (num1 > num3) { Console.WriteLine(num1); } else { Console.WriteLine(num3); } }
            else if (num3 > num1 & num3 > num2) { if (num1 > num2) { Console.WriteLine(num1); } else { Console.WriteLine(num2); } }*/
            #endregion

            #region Task2
            /*Console.WriteLine("Birinci terefi qeyd edin");
            int s1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ikinci terefi qeyd edin");
            int s2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Üçüncü terefi qeyd edin");
            int s3 = Convert.ToInt32((Console.ReadLine()));
            if (s1 == s2 && s2==s3) { Console.WriteLine("1"); }
            else if (s1 == s2 || s2 == s3 || s1 == s3) { Console.WriteLine("2"); }
            else if (s1 != s2 && s2 != s3 && s1 != s3) { Console.WriteLine("3"); }*/
            #endregion

            #region Task3
            /* Console.WriteLine("Birinci terefi qeyd edin");
             int s1 = Convert.ToInt32((Console.ReadLine()));
             Console.WriteLine("Ikinci terefi qeyd edin");
             int s2 = Convert.ToInt32((Console.ReadLine()));
             Console.WriteLine("Üçüncü terefi qeyd edin");
             int s3 = Convert.ToInt32((Console.ReadLine()));
             if(s1>s2 && s1>s3)
             {

                 if (s2 * s2 + s3 * s3 == s1 * s1) { Console.WriteLine("YES"); }
                 else { Console.WriteLine("NO"); }

             }
             if (s2 > s1 && s2 > s3)
             {

                 if (s1 * s1 + s3 * s3 == s2 * s2) { Console.WriteLine("YES"); }
                 else { Console.WriteLine("NO"); }

             }
             if (s3 > s1 && s3 > s2)
             {
                 if (s1 * s1 + s2 * s2 == s3 * s3) { Console.WriteLine("YES"); }
                 else { Console.WriteLine("NO"); }*/
            #endregion

            #region Task4
            /*Console.WriteLine("Ayın nömresini daxil edin:");
             int month = Convert.ToInt32(Console.ReadLine());
              if (month==12 || month == 1 || month == 2 ) 
             { Console.WriteLine("Winter"); }
             else if(month == 3 || month == 4 || month == 5)
             { Console.WriteLine("Spring"); }
             else if (month == 6 || month == 7 || month == 8)
             { Console.WriteLine("Summer"); }
             else if (month == 9 || month == 10 || month == 11)
             { Console.WriteLine("Autumn"); }
             else
             {
                 Console.WriteLine("Ayın nömresini düzgün daxil edin");
             }*/
            #endregion

            #region Task5
            /* Console.WriteLine("Birinci ededi daxil edin");
            int num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ikinci ededi daxil edin");
            int num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Üçüncü ededi daxil edin");
            int num3 = Convert.ToInt32((Console.ReadLine()));
            if((num1%2==0 || num2%2==0 || num3 % 2 == 0) && (num1%2==1 || num2 % 2 == 1 || num3 % 2 == 1))
            { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }*/
            #endregion





        }
    }
}





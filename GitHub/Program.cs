using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GitHub_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.OutputEncoding = Encoding.UTF8;


            //Loops
            #region TASK1
            /*int sagird_sayi=Convert.ToInt32(Console.ReadLine());
           
            for(int i=1;i<=sagird_sayi;i++)
            {
                
                Console.Write(i+ ",");
            }*/
            #endregion

            #region TASK2
            /* int N=int.Parse(Console.ReadLine());
             int cem=0;
             if (N > 0 && N <= 100)
             {
                 for (int i = 0; i <= N; i++)
                 {
                     if (i % 2 == 1)
                     {
                         Console.Write(i+"  ");
                         cem = cem + i; }
                 }
             Console.WriteLine();
               Console.WriteLine("Tek ededlerin cemi=" + cem);
             }*/

            #endregion

            #region TASK3
            /* Console.WriteLine("Eded daxil edin");
             int s=int.Parse(Console.ReadLine());
             Console.WriteLine("Ededin reqemlerinin sayi");
             int n=int.Parse(Console.ReadLine());
             if (n == 1)
             {
                 for (int i = 0; i <= 9; i++)
                 { 

                     if (s == i)
                     { Console.WriteLine(i); }

                 }
             }
             else if (n == 2)
             {
                 for (int i = 10; i <= 99; i++)
                 {
                     int eded = i;
                     int cem = 0;
                     while (eded > 0)
                     {
                         cem += eded % 10;
                         eded /= 10;
                     }
                     if (cem==s)
                     { Console.WriteLine(i); }

                 }
             }
             else if (n == 3)
             {
                 for (int i = 100; i <= 999; i++)
                 {
                     int eded = i;
                     int cem = 0;
                     while (eded > 0)
                     {
                         cem += eded % 10;
                         eded /= 10;
                     }
                     if (cem == s)
                     { Console.WriteLine(i); }

                 }
             }
             else if (n == 4)
             {
                 for (int i = 1000; i <= 9999; i++)
                 {
                     int eded = i;
                     int cem = 0;
                     while (eded > 0)
                     {
                         cem += eded % 10;
                         eded /= 10;
                     }
                     if (cem == s)
                     { Console.WriteLine(i); }

                 }
             }
             else if (n == 5)
             {
                 for (int i = 10000; i <= 99999; i++)
                 {
                     int eded = i;
                     int cem = 0;
                     while (eded > 0)
                     {
                         cem += eded % 10;
                         eded /= 10;
                     }
                     if (cem == s)
                     { Console.WriteLine(i); }

                 }
             }
             else if (n == 6)
             {
                 for (int i = 100000; i <= 999999; i++)
                 {
                     int eded = i;
                     int cem = 0;
                     while (eded > 0)
                     {
                         cem += eded % 10;
                         eded /= 10;
                     }
                     if (cem == s)
                     { Console.WriteLine(i); }

                 }
             }*/
            #endregion

            #region TASK4
            /*Console.WriteLine("Birinci ededi daxil edin");
            int num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ikinci ededi daxil edin");
            int num2 = Convert.ToInt32((Console.ReadLine()));
            double a, b;
            for(int i = num1; i <= num2; i++)
            {
                a = Math.Pow(i,2);
                b = Math.Pow(i, 3);
                Console.WriteLine("Eded   "+i+"  "+"Ededin kvadrati   "+a+"   "+"Ededin kubu   "+b);
            }*/
            #endregion

            #region TASK5
            /*int n=int.Parse(Console.ReadLine());
            Console.WriteLine();
            double a;
            for(int i=1; i <= n; i++)
            {
                a = Math.Pow(i, 2);
                if (a < n)
                Console.WriteLine(a);
            }*/

            #endregion

            #region TASK6
            /*Console.WriteLine("Eded daxil edin");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Reqemi daxil edin");
            int a=int.Parse(Console.ReadLine());
            int say = 0,b;
           
            while (n >0)
            {
                b = n % 10;
                n = n / 10;
                if (b == a)
                { say = say + 1; }
            }
            Console.WriteLine("Reqemin sayi   " + say);*/
            #endregion

            #region TASK7
            /* Console.WriteLine("Birinci ededi daxil edin");
             int a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ikinci ededi daxil edin");
             int b = Convert.ToInt32(Console.ReadLine());
             int cem=0;
             for (int i = a; i <= b; i++)
             {
                 cem = cem + i;
             }
             Console.WriteLine("Cem   " + cem);*/
            #endregion

            #region TASK8
            /* Console.Write("n ededini daxil edin: ");
             int n = int.Parse(Console.ReadLine());
             int say = 0;

             for (int i = 1; i <= n; i++)
             {
                 if (n % i == 0)
                 {
                     say++;
                 }
             }
             Console.WriteLine("Ədədin bölənlərinin sayı: " + say);*/
            #endregion

            #region TASK9
            /*Console.Write("n ededini daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int say = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i%2==1)
                {
                    say++;
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine("Ədədin bölənlərinin sayı: " + say);*/
            #endregion

            #region TASK10
            /*Console.WriteLine("Ededi daxil edin");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ededlerin siyahisi:");
            for (int i = 100; i <= 999; i++)
            {
                int eded = i;
                int cem = 0;
                while (eded > 0)
                {
                    cem += eded % 10;
                    eded /= 10;
                }
                if (cem == n)
                { Console.WriteLine(i); }}*/

            #endregion



            //DATETIME
            //task1
            /*DateTime birthday = new DateTime(2007, 09, 13);
            Console.WriteLine(birthday.DayOfWeek);*/

            //task2
            /*DateTime dateofbirth = new DateTime(2007, 09, 13);
            DateTime dateTime = DateTime.Now;
            TimeSpan timeSpan;
            timeSpan = dateTime - dateofbirth;
            Console.WriteLine(timeSpan.TotalDays);*/

            //task3
            /*DateTime dateTime = DateTime.Now;
            dateTime = dateTime.AddDays(40);
            Console.WriteLine(dateTime.DayOfWeek);*/

            //task4
            /*Console.WriteLine("Tarixi daxil edin");
            DateTime datetime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($" The formatted Date is :{datetime.ToShortDateString()} ");
            DateTime datenow = DateTime.Now;

            if(datetime==datenow.Date)
                Console.WriteLine("The current date status : True");
            else
                Console.WriteLine("The current date status : False");*/

            //task5
            // Verilmiş tarixə qarşı həftənin son gününü tapmaq üçün C# Sharp dilində proqram yazın. Test məlumatları: Gün daxil edin: 16
            // Ayın daxil edilməsi: 06 Giriş ili: 2016 Gözlənilən Nəticə: Formatlaşdırılmış tarix: 16/06/2016. Yuxarıda göstərilən tarix üçün həftənin son günü: 18/06/2016
            /* Console.WriteLine("Günü daxil edin");
               int day=Convert.ToInt16(Console.ReadLine());
               Console.WriteLine("Ayı daxil edin");
               int month = Convert.ToInt16(Console.ReadLine());
               Console.WriteLine("İli daxil edin");
               int year = Convert.ToInt16(Console.ReadLine());
               DateTime dateTime = new DateTime(year, month, day);
               Console.WriteLine($"Formatlaşdırılmış tarix: {dateTime.ToShortDateString()}");
               string dayofweek=Convert.ToString(dateTime.DayOfWeek);
               if (dayofweek == "Saturday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.AddDays(1).ToShortDateString());
               }
               else if (dayofweek == "Sunday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.ToShortDateString());
               }
               else if (dayofweek == "Monday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.AddDays(6).ToShortDateString());
               }
               else if (dayofweek == "Tuesday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.AddDays(5).ToShortDateString());
               }
               else if (dayofweek == "Wednesday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.AddDays(4).ToShortDateString());
               }
               else if (dayofweek == "Thursday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.AddDays(3).ToShortDateString());
               }
               else if (dayofweek == "Friday")
               {
                   Console.WriteLine("Həftənin son günü: " + dateTime.AddDays(2).ToShortDateString());

               }
               else
               {
                   Console.WriteLine("Yanlış tarix daxil etdiniz");
               }*/

            //task6
            //İstifadəçidən iki tarix alın (yyyy-MM-dd formatında). Bu tarixlər arasındakı fərqi gün olaraq hesablayın və çıxışda göstərin.
           // Nümunə çıxış: Birinci tarixi daxil edin: 2024 - 01 - 01 İkinci tarixi daxil edin: 2025 - 04 - 29 Bu tarixlər arasında 484 gün fərq var.
           /*Console.WriteLine("Birinci tarixi daxil edin (yyyy-MM-dd formatında)");
            DateTime start = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ikinci tarixi daxil edin (yyyy-MM-dd formatında)");
            DateTime stop = Convert.ToDateTime(Console.ReadLine());
            TimeSpan timespan;
            timespan = stop - start;
            if (start > stop)
            { Console.WriteLine("Dogru tarixi daxil et");}
            else if (stop > start)
            {
             Console.WriteLine($"Bu tarixlər arasında {timespan.Days} gün fərq var.");
            }*/

            





        }
    }
}





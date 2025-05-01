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


            //task7
            /*Console.Write("Hadisənin tarixi (yyyy-MM-dd):");
            DateTime datetime = Convert.ToDateTime(Console.ReadLine());
            DateTime datenow = DateTime.Now;
            TimeSpan timespan;
            timespan = datetime - datenow;
            if (datetime < datenow)
            {

                Console.WriteLine("Duzgun tarix daxil edin");
            }
            else if (datetime > datenow)
            {
                
                Console.WriteLine($"Bu tarixə {timespan.TotalDays} gün qalıb.");
                
            }*/

            //task8
            /*Console.WriteLine("Başlama tarixini daxil edin(yyyy-MM-dd HH:mm):");
            DateTime start = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Bitmə tarixini daxil edin(yyyy-MM-dd HH:mm):");
            DateTime stop = Convert.ToDateTime(Console.ReadLine());
            TimeSpan timespan;
            timespan = stop - start;
            if (start > stop)
            { Console.WriteLine("Dogru tarixi daxil et");}
            else if (stop > start)
            {
                Console.WriteLine($"Hadisə müddəti:{ timespan.TotalHours} saat"); }*/





        }
    }
}





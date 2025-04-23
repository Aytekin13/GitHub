using System.Runtime.Intrinsics.X86;
using System.Text;

namespace GitHub_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.OutputEncoding = Encoding.UTF8;
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


            // Switch case
            #region  TASK1
            /*Console.Write("Həftənin gününü daxil edin===");
            int heftenin_gunu=Convert.ToInt16(Console.ReadLine());
            switch (heftenin_gunu) 
            { case 1:
                    Console.WriteLine("Bazar ertəsi");
                    break;
                case 2:
                    Console.WriteLine("Çərşənbə axşamı");
                    break;
                case 3:
                    Console.WriteLine("Çərşənbə");
                    break;
                case 4:
                    Console.WriteLine("Cümə axşamı");
                    break;
                case 5:
                    Console.WriteLine("Cümə");
                    break;
                case 6:
                    Console.WriteLine("Şənbə");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("Düzgün gün daxil edin");
                    break;
            }*/
            #endregion

            #region TASK2
            /*Console.Write("Ayın nömrəsini daxil edin----");
            int ayin_nomresi = int.Parse(Console.ReadLine());
            switch (ayin_nomresi)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Qış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Yaz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yay");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Payız");
                    break;

                default:
                    Console.WriteLine("Düzgün ədəd daxil edin");
                    break;
            }*/
            #endregion

            #region TASK3
            /*Console.WriteLine("0-9 aralığında ədəd daxil edin");
            int eded = Convert.ToInt16(Console.ReadLine());
            switch (eded)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                case 4:
                    Console.WriteLine("Dörd");
                    break;
                case 5:
                    Console.WriteLine("Beş");
                    break;
                case 6:
                    Console.WriteLine("Altı");
                    break;
                case 7:
                    Console.WriteLine("Yeddi");
                    break;
                case 8:
                    Console.WriteLine("Səkkiz");
                    break;
                case 9:
                    Console.WriteLine("Doqquz");
                    break;
                case 0:
                    Console.WriteLine("Sıfır");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Düzgün ədəd daxil edin");
                    break;
            }*/
            #endregion

            #region TASK4
            /*Console.Write("Eded1    ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Eded2    ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Simvol   ");
            char simvol = char.Parse(Console.ReadLine());
            switch (simvol)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Duzgun simvolu daxil edin");
                    break;
            }*/

            #endregion

            #region TASK5
            /*Console.Write("Imtahan qiymətini daxil edin   ");
            char imtahan_qiymeti=char.Parse(Console.ReadLine());
            switch (imtahan_qiymeti)
            {
                case 'A':
                    Console.WriteLine("Əla");
                    break;
                case 'B':
                    Console.WriteLine("Çox Yaxşı");
                    break;
                case 'C':
                    Console.WriteLine("Yaxşı");
                    break;
                case 'D':
                    Console.WriteLine("Kafi");
                    break;
                case 'F':
                    Console.WriteLine("Qeyri-kafi");
                    break;
                default:
                    Console.WriteLine("Düzgün qiymət daxil edin");
                    break;
            }*/
            #endregion

            #region TASK6
            /*Console.Write("Ayın nömrəsini daxil edin    ");
            int ayin_nomresi = Convert.ToInt16(Console.ReadLine());
            switch (ayin_nomresi) 
            {
                case 1:
                    Console.WriteLine("Yanvar ayında 31 gün var");
                    break;
                case 2:
                    Console.WriteLine("Fevral ayında 28 və ya 29 gün var");
                    break;
                case 3:
                    Console.WriteLine("Mart ayında 31 gün var");
                    break;
                case 4:
                    Console.WriteLine("Aprel ayında 30 gün var");
                    break;
                case 5:
                    Console.WriteLine("May ayında 31 gün var");
                    break;
                case 6:
                    Console.WriteLine("İyun ayında 30 gün var");
                    break;
                case 7:
                    Console.WriteLine("İyul ayında 31 gün var");
                    break;
                case 8:
                    Console.WriteLine("Avqust ayında 31 gün var");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr ayında 30 gün var");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr ayında 31 gün var");
                    break;
                case 11:
                    Console.WriteLine("Noyabr ayında 30 gün var");
                    break;
                case 12:
                    Console.WriteLine("Dekabr ayında 31 gün var");
                    break;
                default:
                    Console.WriteLine("Düzgün nömrə daxil edin");
                    break;
            }*/
            #endregion

            #region TASK7
           /* Console.WriteLine("Həftənin gününü daxil edin");
            int heftenin_gunu = Convert.ToInt16(Console.ReadLine());
            switch(heftenin_gunu)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İş günü");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Həftəsonu");
                    break;
                default:
                    Console.WriteLine("Düzgün gün daxil edin");
                    break;
            }*/
            #endregion




        }
    }
}





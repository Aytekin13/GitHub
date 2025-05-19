using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GitHub_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRING
            //12.sozu tersine ceviren funksiya
            //Console.WriteLine("Bir soz daxil edin");
            //string word=Console.ReadLine();
            //word = word.Trim();
            //string reversed = "";
            //for(int i=word.Length-1;i>=0;i--)
            //{
            //   reversed+=word[i];
            //}
            //Console.WriteLine(reversed);



            //13.cumlenii tersine ceviren funksiya
            //Console.WriteLine("Bir cumle daxil edin:");
            //string sentence = Console.ReadLine();
            //sentence = sentence.Trim();
            //string reversed = "";
            //string[] words = sentence.Split(" ");
            //for (int i =0; i <=words.Length-1; i++)
            //{
            //    for(int j = words[i].Length - 1; j >= 0; j--)
            //    {
            //        reversed += words[i][j];
            //    }
            //    reversed += " ";
            //}
            //Console.WriteLine(reversed);



            //17.Verilmis cumledeki sozlerin sayini tapin
            //Console.WriteLine("Bir cumle daxil edin:");
            //string sentence = Console.ReadLine();
            //sentence = sentence.Trim();
            //string[] words = sentence.Split(" ");
            //Console.WriteLine($"Sozlerin sayi:{words.Length} ");




            //18.Artiq bosluq simvollarini silin
            //Console.WriteLine("Bir cumle daxil edin:");
            //string sentence = Console.ReadLine();
            //sentence = sentence.Trim();
            //string[] words = sentence.Split(" ");
            //string newSentence = "";
            //for (int i = 0; i <= words.Length - 1; i++)
            //{
            //    if (words[i] != "")
            //    {
            //        newSentence += words[i] + " ";
            //    }
            //}
            //Console.WriteLine(newSentence.Trim());


            //19.Verilmis metnde cumlenin ilk sozunde olan bas herfi boyuk yazmaq
            //Console.WriteLine("Metni daxil edin");
            //string metn = Console.ReadLine();
            //metn = metn.Trim();
            //string[] cumle = metn.Split('.');
            //for (int i = 0; i <= cumle.Length - 1; i++)
            //{
            //    cumle[i] = cumle[i].Trim();
            //}
            //for (int i = 0; i <= cumle.Length - 1; i++)
            //{
            //    string[] sozler = cumle[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    if (sozler.Length > 0)

            //    {
            //        sozler[0] = char.ToUpper(sozler[0][0]) + sozler[0].Substring(1);
            //        cumle[i] = string.Join(" ", sozler);
            //    }
            // }
            //string newMetn = string.Join(".", cumle);
            //Console.WriteLine(newMetn);





            //26 27 alinmadi
            //26.tekrarlanan sozlerin sayi BRO I DONT KNOW IT
            //Console.WriteLine("Metni daxil edin");

            //string metn = Console.ReadLine();
            //metn = metn.Trim().ToLower();
            //string[] metn1 = { };
            //string[] words = metn.Split(' ');
            //for (int i = 0; i <= words.Length - 1; i++)
            //{ int say = 0;
            //    for(int j=0;j<=words.Length-1;j++)
            //    { if(words[i] == words[j])
            //        {
            //            say++;
            //        }
            //    }
            //   if(say>1)
            //    {    metn1=metn1.Append(words[i]).ToArray();
            //        if (!metn1.Contains(words[i]))

            //        { Console.WriteLine($"Söz: {words[i]} Say: {say}"); }
            //    }
            //}

        }
   

    }
}





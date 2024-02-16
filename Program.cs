using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_5
{
    internal class Program
    {
        static string[] SplitText(string Text)
        {
           
            string[] res = Text.Split(' ');


            return res;
        }


        static void PrintText(String[] Arr)
        {
            foreach (var e in Arr)
                Console.WriteLine($"{e}");


        }
        static void Pause()
        { Console.ReadKey(); }

        static string ReversWords (string text)
        {          

            string[] arr = SplitText(text);

            string ResultString = string.Empty;

            foreach (var e in arr)           
            {
                ResultString = e+ ' '+ ResultString;
                
            }



            string res = ResultString;
            return res;
        }

        static void Main(string[] args)
        {
            #region Задание 1.Метод разделения строки на слова


            //Console.WriteLine("Введите предложение, каждое слово отделяйте пробелом. В результате ожидается вывод каждого слова в отдельной строке");

            //String text = Console.ReadLine();

            //string[] arr = SplitText(text);

            //PrintText(arr);

            //Pause();




            #endregion

            #region Задание 2.Перестановка слов в предложении

            //Что нужно сделать
            //Пользователь вводит в программе длинное предложение.
            //Каждое слово отделено пробелом. После ввода пользователь нажимает клавишу Enter. Необходимо создать два метода:

            //первый разделяет слова в предложении;
            //            второй меняет эти слова местами(в обратной последовательности).
            //            Учтите, что один метод вызывается внутри другого метода, то есть в методе main вызывается метод c сигнатурой ReversWords(string inputPhrase).
            //            Внутри этого метода вызывается метод по разделению входной фразы на слова.
            //            Метод должен выглядеть так: static string Reverse(string text), где text — это предложение, в котором необходимо поменять местами слова.

            //Советы и рекомендации
            //Для сложения строк можно использовать конкатенацию строк.
            //Выражение вида ResultString += NewString + “ ” добавит к текущей строке, которая представлена переменной ResultString,
            //новую строку из переменной NewString, а также пробел к концу строки. 
            //Для реализации алгоритма разделения строки на слова можно воспользоваться рекомендациями из задания 1.
            //В программе не должно быть глобальных переменных.Все данные между методами должны передаваться через параметры и возвращаемые значения.

            //Что оценивается
            //Вызов метода по разделению на слова происходит внутри метода, который отвечает непосредственно за инвертирование слов в предложении.

            Console.WriteLine("Введите предложение, каждое слово отделяйте пробелом. В результате ожидается замена слов местами в обратной последовательности");

            String text = Console.ReadLine();            

            string res = ReversWords(text);

            Console.WriteLine(res);

            Pause();

            #endregion



        }
    }
}

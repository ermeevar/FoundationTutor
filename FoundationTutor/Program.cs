using System;

namespace FoundationTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Blocks(comments)
            {
                int age;
            }
            //age = 3;

            string name;
            name = "Rufina";
            #endregion

            #region Literals(переменные, типы, значения, присвоения, значимые типы, ссылочные типы)
            // Есть несколько типов данных, которые используются намного чаще
            // Но их гораздо больше!

            string county = "Russia";
            char sign = '&';

            int num = 10;
            double numWith = 10.3;

            bool isTodayFriday = true;

            DateTime todayDate = DateTime.Now;
            #endregion

            #region Output-Input
            //Console.WriteLine(sign);
            //Console.WriteLine(todayDate);
            //Console.WriteLine(num);

            //int userNumber = Convert.ToInt32(Console.ReadLine());

            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine(userNumber);

            //Console.WriteLine(todayDate.DayOfWeek);
            #endregion

            #region Maths
            Console.WriteLine(num + numWith);
            Console.WriteLine(num / numWith);
            Console.WriteLine(num * numWith);
            Console.WriteLine(numWith % 10);

            Console.WriteLine(num > numWith);
            Console.WriteLine(num >= Convert.ToInt32(Math.Round(numWith)));
            Console.WriteLine();
            Console.WriteLine((num > numWith) && isTodayFriday);
            Console.WriteLine((num > numWith) || isTodayFriday);
            Console.WriteLine();
            Console.WriteLine(todayDate == null);

            //Console.WriteLine(num * country);
            #endregion

            #region Conditions
            if (isTodayFriday)
            {
                Console.WriteLine("Сегодня пятница");
            }
            else
            {
                Console.WriteLine("Сегодня не пятница");
            }

            Console.WriteLine(isTodayFriday ? "Сегодня пятница" : "Сегодня не пятница");

            if(DateTime.Now.Year == 2021 && DateTime.Now.Month == 10)
            {
                Console.WriteLine("Текущий месяц октябрь, год 2021");
            }
            else if(DateTime.Now.Year == 2021)
            {
                Console.WriteLine("Текущий год 2021");
            }
            else
            {
                Console.WriteLine("Неопределено");
            }

            switch (DateTime.Now.Month)
            {
                case 1:
                    Console.WriteLine("Сейчас январь");
                    break;
                case 2:
                    Console.WriteLine("Сейчас февраль");
                    break;
                case 3:
                    Console.WriteLine("Сейчас март");
                    break;
                case 4:
                    Console.WriteLine("Сейчас апрель");
                    break;
                case 5:
                    Console.WriteLine("Сейчас май");
                    break;
                case 6:
                    Console.WriteLine("Сейчас июнь");
                    break;
                case 7:
                    Console.WriteLine("Сейчас июль");
                    break;
                case 8:
                    Console.WriteLine("Сейчас август");
                    break;
                case 9:
                    Console.WriteLine("Сейчас сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Сейчас октябрь");
                    break;
                case 11:
                    Console.WriteLine("Сейчас ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Сейчас декабрь");
                    break;
                default:
                    Console.WriteLine("Месяц неизвестен");
                    break;
            }
            #endregion
        }
    }
}
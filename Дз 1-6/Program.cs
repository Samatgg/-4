using System;

namespace Дз_1_6
{
    enum Days //Для упр 4
    {
        Понедельник,
        Вторник, 
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    enum Cards //Для упр 2
    {
        Шестерка,
        Семерка,
        Восьмерка,
        Девятка,
        Десятка,
        Валет,
        Дам,
        Король,
        Туз
    }
    internal class Program
    {
        static void Main(string[] args)
        {   // Упр 1. - 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию,в случае отриц. ответа
            // определить порядковый номер первого числа, который нарушает этот порядок
            Console.WriteLine("Упр 1. - 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию\n");
            int i = 0;            
            bool flag = true;
            int[] numbers = new int[10];
            Console.WriteLine("Введите первое число массива");
            do
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (i > 0 && numbers[i] <= numbers[i - 1])
                {
                    flag = false;
                    break;
                }
                
            } while (i++ < 9);
            if (flag)
            {
                Console.WriteLine("Последовательность упорядочена");
            }
            else
            {
                Console.WriteLine($"Порядок сбился на числе - {numbers[i]}, его индекс - {i}");
            }
            // Упр 2 - Номера и названия карт, использовать try-catch-finally
            Console.WriteLine("\nУпр 2 - Номера и названия карт, использовать try-catch-finally\n");
            Console.WriteLine("Введите число от 6 до 14");
            int nuumber;
            bool a = int.TryParse(Console.ReadLine(), out nuumber);
            if (a)
            {
                switch (nuumber)
                {
                    case 6:
                        Console.WriteLine($"6 - это {Cards.Шестерка}");
                        break;
                    case 7:
                        Console.WriteLine($"7 - это {Cards.Семерка}");
                        break;
                    case 8:
                        Console.WriteLine($"8 - это {Cards.Восьмерка}");
                        break;
                    case 9:
                        Console.WriteLine($"9 - это {Cards.Девятка}");
                        break;
                    case 10:
                        Console.WriteLine($"10 - это {Cards.Десятка}");
                        break;
                    case 11:
                        Console.WriteLine($"11 - это {Cards.Валет}");
                        break;
                    case 12:
                        Console.WriteLine($"12 - это {Cards.Дам}");
                        break;
                    case 13:
                        Console.WriteLine($"13 - это {Cards.Король}");
                        break;
                    case 14:
                        Console.WriteLine($"14 - это {Cards.Туз}");
                        break;
                    default:
                        Console.WriteLine("Вы ввели ненужное число");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неправильно введено число");
            }

            // Упр 3. - На входе строку и производит выходные данные в соответствии с таблицей
            Console.WriteLine("\nУпр 3. На входе строку и производит выходные данные в соответствии с таблицей\n");
            Console.WriteLine("Кто вы?");
            string profession = Console.ReadLine().ToLower();
            switch (profession)
            {
                case ("jabroni"):
                    Console.WriteLine("Patron Tequila");
                    break;
                case ("school Counselor"):
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case ("programmer"):
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case ("bike Gang Members"):
                    Console.WriteLine("Moonshine");
                    break;
                case ("politican"):
                    Console.WriteLine("Yout taxi dollars");
                    break;
                case ("rapper"):
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }


            // Упр 4. Порядковый номер недели и его название (использовать enum)
            Console.WriteLine("\nУпр 4. Порядковый номер недели и его название (использовать enum)\n");
            Console.WriteLine("Введите число от 1 до 7");
            int day ;
            bool chislo = int.TryParse(Console.ReadLine(), out day);
            if (chislo)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine($"{day} - {Days.Понедельник}");
                            break;
                    case 2:
                        Console.WriteLine($"{day} - {Days.Вторник}");
                        break;
                    case 3:
                        Console.WriteLine($"{day} - {Days.Среда}");
                        break;
                    case 4:
                        Console.WriteLine($"{day} - {Days.Четверг}");
                        break;
                    case 5:
                        Console.WriteLine($"{day} - {Days.Пятница}");
                        break;
                    case 6:
                        Console.WriteLine($"{day} - {Days.Суббота}");
                        break;
                    case 7:
                        Console.WriteLine($"{day} - {Days.Воскресенье}");
                        break;
                    default:
                        Console.WriteLine("Ваше число не подходит данному диапазону");
                        break;
                }   
            }
            else
            {
                Console.WriteLine("Неправильно ввели число");
            }


            // Упр 5 - создать массив, искать в нем при помощи foreach 'Barbie doll' or 'Hello Kitty'
            int bag = 0;
            Console.WriteLine("\nУпр 5 - создать массив, искать в нем при помощи foreach 'Barbie doll' or 'Hello Kitty'\n");
            string[] dolls = new string[] { "Dogs", "Cats", "Barbie doll", "rats", "proga", "crash", "Hello Kitty", "comp", "Barbie doll" };
            foreach ( string doll in dolls ) 
            { 
                if (doll == "Barbie doll" || doll == "Hello Kitty")
                {
                    bag++;
                }
            }
            Console.WriteLine($"Общее количество нужных нам игрушек - {bag}");
        }
    }
}

using System;


namespace Тумаков_Лабораторка_4
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ДЗ Тумакова, Упр 4.1 лабораторка - написать число от 1 до 365, определить какой это день месяца и месяц
            //Учесть високосный год или нет
            Console.WriteLine("Упр 4.1 - написать число от 1 до 365, определить какой это день месяца и месяц\n");
            Console.WriteLine("Введите число от 1 до 365");
            int day;
            bool chislo = int.TryParse(Console.ReadLine(), out day);
            if (chislo)
            {
                if (day >= 1 && day <= 365)
                {
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine($"Число {day} соотвествует {day} {Months.January}");
                    }
                    else if (day >= 32 && day <= 59)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 31} {Months.February}");
                    }
                    else if (day >= 60 && day <= 90)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 59} {Months.March}");
                    }
                    else if (day >= 91 && day <= 120)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 90} {Months.April}");
                    }
                    else if (day >= 121 && day <= 151)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 120} {Months.May}");
                    }
                    else if (day >= 152 && day <= 181)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 151} {Months.June}");
                    }
                    else if (day >= 182 && day <= 212)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 181} {Months.July}");
                    }
                    else if (day >= 213 && day <= 243)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 212} {Months.August}");
                    }
                    else if (day >= 244 && day <= 273)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 243} {Months.September}");
                    }
                    else if (day >= 274 && day <= 304)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 273} {Months.October}");
                    }
                    else if (day >= 305 && day <= 334)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 304} {Months.November}");
                    }
                    else if (day >= 335 && day <= 365)
                    {
                        Console.WriteLine($"Число {day} соответствует {day - 334} {Months.December}");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не то число, которое нужно"); // Упр 4.2 - если число меньше 1 или больше 365 выработать исключение
                }
            }
            else
            {
                Console.WriteLine("Вы ввели число неправильно");
            }

            
            // Д.з 4.1 - Учесть високосный год или нет
            Console.WriteLine("\nД.з 4.1 - Учесть високосный год или нет\n");
            Console.WriteLine("Введите число от 1 до 366");
            int day1, year;
            bool chislo1 = int.TryParse(Console.ReadLine(), out day1);
            Console.WriteLine("Введите год");
            bool yr = int.TryParse(Console.ReadLine(), out year);
            if (yr)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("Год високосный");
                    if (chislo1)
                    {
                        if (day1 >= 1 && day1 <= 366)
                        {
                            if (day1 >= 1 && day1 <= 31)
                            {
                                Console.WriteLine($"Число {day1} соответсвует {day1} {Months.January}");
                            }
                            else if (day1 >= 32 && day1 <= 60)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 32} {Months.February}");
                            }
                            else if (day1 >= 61 && day1 <= 91)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 60} {Months.March}");
                            }
                            else if (day1 >= 92 && day <= 121)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 91} {Months.April}");
                            }
                            else if (day1 >= 122 && day <= 152)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 121} {Months.May}");
                            }
                            else if (day1 >= 153 && day1 <= 182)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 152} {Months.June}");
                            }
                            else if (day1 >= 183 && day <= 213)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 182} {Months.July}");
                            }
                            else if (day1 >= 214 && day1 <= 244)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 213} {Months.August}");
                            }
                            else if (day1 >= 245 && day1 <= 274)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 244} {Months.September}");
                            }
                            else if (day1 >= 275 && day1 <= 305)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 274} {Months.October}");
                            }
                            else if (day1 >= 306 && day1 <= 335)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 305} {Months.November}");
                            }
                            else if (day1 >= 336 && day <= 366)
                            {
                                Console.WriteLine($"Число {day1} соответствует {day1 - 335} {Months.December}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не то число, которое нужно");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправильно ввели число");
                    }
                }
                else
                {
                    Console.WriteLine("Год невисокосный");
                }
            }
            else
            {
                Console.WriteLine("Неправильно ввели год");
            }
        }
    }
}

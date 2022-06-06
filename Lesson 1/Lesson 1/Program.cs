/*Соколова Любовь*/
using System;
using System.Threading;

namespace Lesson_1
{
    class Program
    {
        /// <summary>
        /// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        /// а) используя склеивание;
        /// б) используя форматированный вывод;
        /// в) используя вывод со знаком $.
        /// </summary>
        static void Questionnaire()
        {
            Console.WriteLine("АНКЕТА");
            string name = "";
            string lastName = "";
            byte age = 0;    // до 255 лет
            byte height = 0; // до 255 см
            byte weight = 0; // до 255 кг
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            lastName = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост:");
            height = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            weight = byte.Parse(Console.ReadLine());
            Console.WriteLine("Имя: " + name + " Фамилия: " + lastName + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, lastName, age, height, weight);
            Console.WriteLine($"Имя: {name} Фамилия: {lastName} Возраст: {age} Рост: {height} Вес: {weight}");
        }


        /// <summary>
        /// 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
        /// </summary>
        static void BodyMassIndex()
        {
            
            Console.WriteLine("ИНДЕКС МАССЫ ТЕЛА");
            int weight = 0;
            double height = 0;
            double index;
            Console.WriteLine("Введите вес:");
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост:");
            height = double.Parse(Console.ReadLine());
            index = weight / (height * height);
            Console.WriteLine($"Индекс массы тела: {index}");
        }


        /// <summary>
        /// 3.
        /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        /// </summary>
        static void DistanceBetweenPoints()
        {
            Console.WriteLine("РАССТОЯНИЕ МЕЖДУ ДВУМЯ ТОЧКАМИ");
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double r = 0.00;
            Console.Write("Введите x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            y2 = int.Parse(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            if (r == 0)
            {
                Console.WriteLine("Расстояние между точками равно 0");
            }
            else Console.WriteLine($"Расстояние между точками равно: {r:f2}");
        }

        /// <summary>
        /// 3.
        /// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        /// </summary>
        static void DistanceBetweenPoints(int x1, int x2, int y1, int y2)
        {
            Console.WriteLine("РАССТОЯНИЕ МЕЖДУ ДВУМЯ ТОЧКАМИ (ПРИ ПОМОЩИ МЕТОДА)");
            int x11 = x1, x22 = x2, y11 = y1, y22 = y2;
            double r = 0.00;
            r = Math.Sqrt(Math.Pow(x22 - x11, 2) + Math.Pow(y22 - y11, 2));
            if (r == 0)
            {
                Console.WriteLine("Расстояние между точками равно 0");
            }
            else Console.WriteLine($"Расстояние между точками равно: {r:f2}");
        }

        /// <summary>
        /// 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        /// а) с использованием третьей переменной;
        /// </summary>
        static void Swap()
        {
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ ДВУХ ПЕРЕМЕННЫХ");
            int a = 0, b = 0, temp = 0;
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a: {a} b: {b}"); 
        }

        /// <summary>
        /// 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        /// б) *без использования третьей переменной.
        /// </summary>
        static void Swap(int a, int b)
        {
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ ДВУХ ПЕРЕМЕННЫХ БЕЗ ТРЕТЬЕЙ ПЕРЕМЕННОЙ");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a: {a} b: {b}");
        }

        /// <summary>
        /// 5.
        ///а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        ///б) Сделать задание, только вывод организовать в центре экрана.
        /// </summary>
        static void PersonData()
        {
            Console.WriteLine("ПЕРСОНАЛЬНЫЕ ДАННЫЕ");
            string name = "";
            string lastName = "";
            string currentCity = "";
            int indent = 0;
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Введите город: ");
            currentCity = Console.ReadLine();
            string[] perDate = { name, lastName, currentCity };
            int top = (Console.WindowHeight / 2) - (perDate.Length / 2) - 1;
            int center = Console.WindowWidth / 2;
            foreach (var pd in perDate)
            {
                indent = center - (pd.Length / 2);
                Console.SetCursorPosition(indent, top);
                Console.WriteLine(pd);
                top = Console.CursorTop;
            }

            // 5. в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            Print(perDate, 2, 2); // верно отображает текст относительно окна, но не положения курсора
        }

        /// <summary>
        /// 5. в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Print(string[] ms, int x, int y)
        {
            // извлечь последнюю координату курсора по Y и прибавить ее к заданным координатам 
            //int top = Console.CursorTop;
            //Console.SetCursorPosition(x, top+y);
            foreach (var s in ms)
            {
                Console.SetCursorPosition(x, y);
                y = Console.CursorTop;
            }
        }

        static void Main(string[] args)
        {
            //Questionnaire();
            //BodyMassIndex();
            //DistanceBetweenPoints();
            //DistanceBetweenPoints(1, 2, 3, 4);
            //Swap();
            //Swap(1, 6);
            PersonData();
            //Formatting fm = new Formatting();
            //fm.Print("имя фамилия город! ", 1, 1);
            //fm.Pause(10000);
        }
    }

    /// <summary>
    /// 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
    /// </summary>
    class Formatting
    {
        public void Print(string ms, int x, int y)
        { 
            foreach (var s in ms)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(s);
                y = Console.CursorTop;
            }
        }

        public void Pause(int ms)
        {
            Thread.Sleep(ms);
        }
    }
}

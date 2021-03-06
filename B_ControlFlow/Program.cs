using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            

           
        }

        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        static void Homework05()
        {
            string yourLogin = "johnsilver";
            string yourPassword = "qwerty";
            int counterOfTries = 0;

            while (counterOfTries <= 3)
            {
                if (counterOfTries == 3)
                {
                    Console.WriteLine("The number of available tries have been exceeded");
                    break;
                }

                Console.WriteLine("Enter login");
                string login = Console.ReadLine();
                login = login.ToLower();
                Console.WriteLine("Enret the password");
                string password = Console.ReadLine();
                counterOfTries++;

                if (login == yourLogin && password == yourPassword)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }

            }
        }
        static void Homework04()
        {
            Console.WriteLine("Введите число, факториал которого требуется вычислить");

            int n = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Факториал числа {n} равен {factorial}");
        }
        static void Homework03()
        {
            int counter = 0;
            int newNumber = 0;
            int sum = 0;

            Console.WriteLine("Введите не больше 10ти чисел");
            Console.WriteLine("Чтобы прекратить ввод чисел, введите 0");

            for (int i = 1; i <= 10; i++)
            {

                do
                {
                    Console.WriteLine($"Введите целое положительное число №{i}");
                    newNumber = int.Parse(Console.ReadLine());

                } while (newNumber < 0);

                if (newNumber == 0)
                    break;

                if (newNumber % 3 == 0)
                {
                    sum += newNumber;
                    counter++;
                }

            }

            double average = (double)sum / counter;

            Console.WriteLine($"Среднее значение чисел, кратных трем равно {average}");
        }
        static void Homework02()
        {
            Console.WriteLine("Вычислим последовательность Фибоначчи");
            int numberOfElements = 0;

            do
            {
                Console.WriteLine("Введите нужное кол-во значений");
                numberOfElements = int.Parse(Console.ReadLine());
            }
            while (numberOfElements <= 0);
            

            int[] elements = new int[numberOfElements];
            elements[0] = 0;
            elements[1] = 1;

            for (int i = 2; i < numberOfElements; i++)
            {
                elements[i] = elements[i - 1] + elements[i - 2];
            }

            foreach (int n in elements)
            {
                Console.Write(n + " ");
            }
        }
        static void DebuggingDemo()
        {
            // основы отладки или дебагинга
            // клавиша F5 запускает программу в режиме отладки
            // клавиша F9 ставит точку остановки на выбранную строку кода
            // F10 и F11 перемещаются по коду по одной строчке
            // F11 заходит во внутрь вызываемых функций, тогда как F10 их пропускает
            // F5 при уже работающей отладке перескакивает на следующую точку остановки
            // Shift + F5 - выход из отладки
            Console.WriteLine("Hello! Please, put in the length of the triangle sides.");

            Console.WriteLine("Put in the side a");
            double sideA = GetDouble();

            Console.WriteLine("Put in the side b");
            double sideB = GetDouble();

            Console.WriteLine("Put in the side c");
            double sideC = GetDouble();

            double p = (sideA + sideB + sideC) / 2;
            double s = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"Square of the triangle = {Math.Round(s, 3)}");
        }
        static void SwitchCase()
        {
            Console.WriteLine("Введите юбилейный год вашей свадьбы");
            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;
            // конструкция switch-case может заменить конструкцию if-else
            // по производительности она чуть быстрее, но главное, что она легче читается, если условий много
            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебряная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                // нужно прописать дефолтное условие, на случай, если другие не подойдут
                default:
                    name = "Не знаю такого юбилея";
                    break;
            }

            Console.WriteLine(name);

            Console.ReadLine();

            Console.WriteLine("Введите номер месяца");
            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;

            // кейсы или условия можно объединять
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Fall";
                    break;
                // если мы уверены, что в дефолт попасть невозможно, то можно прописать исключение
                default:
                    throw new ArgumentException("Invalid number of the month");
            }

            Console.WriteLine(season);
        }
        static void BreakAndContinue()
        {
            // break - команда полностью останавливает действие кода (прим. выходит из цикла)
            // continue - команда продолжает работу цикла, но со следующим элементом массива, не выполняя тот участок кода, который был после этой команды
            // задача - вывести четные числа
            int[] numbers1 = { 0, 3, 2, 4, 1, 9, 6, 7, 5, 8 };

            // выполнить данный цикл для каждого значения в массиве 
            foreach (int n in numbers1)
            {
                /*if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }*/

                // второй способ с применением команды continue
                // если остаток при делении числа на 2 НЕ равен нулю, то перейти к следующему итератору (элементу массива)
                if (n % 2 != 0)
                    continue;
                Console.WriteLine(n);
            }

            Console.ReadLine();

            // задача - вывести такое кол-во букв по порядку, какое число стоит в каждом следующем индексе массива чисел
            // те если стоит 3, то вывести abc 
            int[] number = { 0, 3, 2, 4, 1, 9, 6, 7, 5, 8 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < number.Length; i++)
            {
                // выводим значение каждого индекса 
                Console.WriteLine($"Number = {number[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    // выходит из цикла, когда значение первого массива становится равно индексу следующего не выведенного значения второго массива
                    if (number[i] == j)
                        break;

                    Console.Write($"{letters[j]}");

                }

                Console.WriteLine();
            }

            Console.ReadLine();

            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            // счетчик найденных пар чисел, равных нулю
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }

                    // break - команда, завершающая работу цикла досрочно
                    // в данном случае, выход из цикла происходит, когда найдено три пары чисел
                    if (counter == 3)
                        break;
                }

                // после выхода из внутреннего цикла, нужно выйти из внешнего с тем же условием
                if (counter == 3)
                    break;
            }
        }
        static void WhileDoWhile()
        {
            int age = 30;

            // если условие изначально не верно, в тело цикла не зайдет
            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            // даже если условие не верно, зайдет в цикл хотя бы один раз
            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            // с помощью цикла while так же можно проходиться по элементам массива, но это не так удобно, как цикл for
            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
        }
        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplet ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }

                }
            }
        }
        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            // при выделении переменной нажать ctrl + R + R 
            // переименовывает эту переменную во всех местах, где она используется в данном блоке кода
            Console.WriteLine();
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }

            // не имеет доступа по индексу, сразу выводит все значения от 0го до последнего
            foreach (int val in numbers)
            {
                Console.WriteLine(val + " ");
            }
        }
        static void Homework01()
        {
            Console.WriteLine("Hello, please, put in a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, please, put in a number");
            int b = int.Parse(Console.ReadLine());

            // способ 1
            if (a > b)
            {
                Console.WriteLine($"Max number is {a}");
            }
            else
            {
                Console.WriteLine($"Max number is {b}");
            }

            // способ 2
            int max = a;
            if (b > a)
                max = b;
            Console.WriteLine($"Max number is {max}");

            // способ 3
            int maxNumber = a > b ? a : b;
            Console.WriteLine($"Max number is {maxNumber}");
        }
        static void IfElseDemo()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight in kg?");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your height in meters?");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            // && - "и" когда оба условия должны быть выполнены
            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            // || - "или" когда хотя бы одно выражение должно быть выполнено
            bool isFat = isAboveNormal || isTooFat;

            // если код состоит из одной строки, то скобки после условия ставить не обязательно
            /*if (условие)
                строка кода;
            else
                строка кода;*/

            if (isFat) // (isFat == true)
            {
                Console.WriteLine("You'd better lose some weight");
            }
            else
            {
                Console.WriteLine("Oh, you are in a good shape");
            }

            if (!isFat) // (isFat == false)
            {
                Console.WriteLine("You are definitely not fat");
            }

            // можно добавлять сколько угодно условий с помощью else if, после else указывается дефолтное действие для оставшихся условий
            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("You are okay");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("It's time to get on a diet");
            }

            // сначала проверяется условие, а потом результат присваевается в переменную
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";

            // тернарная операция - тоже самое, что и конструкция is-else
            /*if (age > 18)
            {
                description = "You can drink alcohol";
            }
            else
            {
                description = "You should get a bit older";
            }*/

            Console.WriteLine(description);
        }
    }
}

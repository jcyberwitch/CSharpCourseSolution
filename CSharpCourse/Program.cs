using System;
using System.Text;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void HomeworkThree()
        {
            Console.WriteLine("Hello! Let's found out your body mass index");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string surName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight in kg?");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your height in meters?");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            string profile =
                $"Your profile: {Environment.NewLine}" +
                $"Full name: {surName}, {name} {Environment.NewLine}" +
                $"Age: {age} {Environment.NewLine}" +
                $"Weight: {weight} {Environment.NewLine}" +
                $"Height: {height} {Environment.NewLine}" +
                $"Body Mass Index: {Math.Round(bodyMassIndex)}";

            Console.WriteLine();
            Console.WriteLine(profile);
        }
        static void HomeworkTwo()
        {
            Console.WriteLine("Hello! Please, put in the length of the triangle sides.");

            Console.WriteLine("Put in the side a");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Put in the side b");
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine("Put in the side c");
            double sideC = double.Parse(Console.ReadLine());

            double p = (sideA + sideB + sideC) / 2;
            double s = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"Square of the triangle = {Math.Round(s, 3)}");
        }
        static void HomeworkOne()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Console.ReadLine();
            Console.WriteLine("Please, put in an integer");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, put in an integer");
            int b = int.Parse(Console.ReadLine());
            int c;
            Console.WriteLine($"a = {a}, b = {b}");

            // обмен значений местами 
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}, b = {b}");

            Console.ReadLine();
            Console.WriteLine("Please, put in a number");
            string number = Console.ReadLine();
            Console.WriteLine($"Колличество цифр в числе {number}: {number.Length}");
        }
        static void DateTimeDemo()
        {
            // тип DateTime работает с временем и обладает множеством методов и свойств
            // выдает дату и время "сейчас" 
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            // можно указывать отдельные части (дату/часы/минуты/тд) с помощью свойств на экземпляре
            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            // можно создать экземпляр указывая нужные дату и время 
            DateTime dt = new DateTime(2016, 2, 28);
            // не модифицирует изначальный экземпляр, а создает новый с результатом
            // из-за различных тонкостей в календарях лучше пользоваться именно методами, а не считать самостоятельно
            DateTime newDt = dt.AddDays(1); // добавляет дни с учетом работы календарей
            Console.WriteLine(newDt);

            // TimeSpan помогает вычислить сколько прошло времени 
            TimeSpan ts = now - dt;
            // ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }
        static void IntroToArrays()
        {
            // массив - набор экземпляров одного определенного типа
            int[] a1; // объявление массива
            // выделение памяти под массив
            a1 = new int[10]; 
            // можно сразу выделить память
            int[] a2 = new int[5];
            // можно сразу внести значения
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 }; 
            // компилятор сам может понять сколько памяти нужно, если сразу внести значения
            int[] a4 = { 1, 3, 2, 4, 5 };
            Console.WriteLine(a4[0]);

            // обращение по индексу
            int number = a4[4];
            Console.WriteLine(number); // 5
            // можно перезаписать значение по индексу
            a4[4] = 6;
            Console.WriteLine(a4[4]); // 6

            // длина массива (кол-во элементов)
            Console.WriteLine(a4.Length); // 5
            // обращение к последнему индексу, если ты не знаешь длину массива
            Console.WriteLine(a4[a4.Length - 1]); // 6

            // обращение по индексу в строке
            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"First: {first}. Last: {last}");

            //s1[0] = "z"; 
            // таким образом перезаписать элементы строки невозмжно
        }
        static void MathDemo()
        {
            // Math - статический метод, создать его экземпляр нельзя
            Console.WriteLine(Math.Pow(2, 3)); // возведение первого числа в степень второго
            Console.WriteLine(Math.Sqrt(9)); // корень из числа
            Console.WriteLine(Math.Sqrt(8)); // выдаст как целое число, так и с плавающей точкой

            // округление
            Console.WriteLine(Math.Round(1.7)); // 2
            Console.WriteLine(Math.Round(1.4)); // 1

            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5)); // 2 - по умолчанию ToEven
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // 3 - в большую сторону (дальше от нуля)
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // 2
        }
        static void Comments()
        {
            // однострочный комментарий 

            /*
             * многострочный 
             * комментарий
             * можно заккомментировать 
             * сразу несколько строк кода
             * 
             */

            // при описании кода лучше писать как и почему происходит, а не что конкретно происходит

            int a = 1;
            // инкремент а на единицу - плохой комментарий, другому программисту итак понятно, что делает данный код
            // [почему в рамках задачи необходимо это сделать] - хороший комментарий
            a++;
        }
        static void CastingAndParsing()
        {
            // байтовая репрезентция чисел в разных типах
            byte b = 3; // 0000 0011
            int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            // по факту даже целое число представлено в float или double числом с точкой
            float f = i; // 3.0

            // явное приведение к типу
            // просто в тип с меньшей вместимостью записать тип больше нельзя
            // мы должны указать, что значение большего типа точно влезет в меньший тип
            b = (byte)i;
            Console.WriteLine(b);

            //при приведение к int типа с плавающей точкой мы теряем все, что было после запятой
            i = (int)f;
            Console.WriteLine(i);

            // здесь 8 будет обрезана (не округление!)
            f = 3.8f;
            i = (int)f;
            Console.WriteLine(i); // 3

            // строку к численному типу явно привести нельзя
            string str = "1";
            // i = (int)str;
            i = int.Parse(str);
            Console.WriteLine(i);

            // при делении интов нужно привести их к даблу, если мы не хотим терять знаки после запятой
            int x = 5;
            int result = x / 2;
            // приведение имеет больший приоритет, чем любые вычисления
            // сначала х будет приведен к double, а потом поделен
            double result2 = (double)x / 2; // 5.0 / 2
            Console.WriteLine(result); // 2
            Console.WriteLine(result2); // 2.5
        }
        static void ConsoleBasics()
        {
            Console.WriteLine("Hi! Please, tell me your name.");

            // дожидается ввода от пользователя и записывает результат в переменную
            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Tell me your age");

            // получение переменной типа string
            string input = Console.ReadLine();
            // приведение типа string к типу int
            // [нужный тип] [имя новой переменной] = [нужный тип].Parse([переменная]);
            int age = int.Parse(input);
            sentence = $"Your name is {name} and you are {age}!";
            Console.WriteLine(sentence);

            // можно использовать для того, чтобы пользователь нажал enter перед переходом к дальнейшему коду
            Console.ReadLine();
            // для очищения консоли
            Console.Clear();
            // настрока цвета консоли
            Console.BackgroundColor = ConsoleColor.DarkBlue; // фон
            Console.ForegroundColor = ConsoleColor.DarkCyan; // шрифт

            // Console.Write не переводит курсор на новую строку 
            Console.Write("New Style ");
            // но для этого все еще можно использовать \n
            Console.Write("New Style \n");
            Console.Write("New Style ");
        }
        static void StringComparing()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2; // сравнение двух строк
            Console.WriteLine(areEqual); // true

            // функция, сравнивающая две строки ([нужные строки], [параметр])
            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual); // true

            string s1 = "Strasse";
            string s2 = "Straße";

            // Ordinal используется чаще всего и работает быстрее всего 
            // сравнивает строки посимвольно
            areEqual = string.Equals(s1, s2, StringComparison.Ordinal);
            Console.WriteLine(areEqual); // false

            // InvariantCulture просмаривает возможные конструкции и работает дольше всего
            // сравнивает с учетом особых лингвистических конструкций, поэтому знает, что ß и ss - значат одно и тоже
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual); // true

            // CurrentCulter просматривает одну установленную "культуру" и работает быстрее InvariantCulture, поэтому при необходимости лучше использовать его
            // так же понимает особые лингвистические особенности "культур" 
            // нужную "культуру" можно установить перед проверкой
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(название культуры)
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual); // true
        }
        static void StringFormats()
        {
            string name = "Jeremy";
            int age = 25;
            // цифры указывают на индекс аргументов, используемых в строке, после строки сами аргументы в нужном порядке
            string str1 = string.Format("My name is {0} and I am {1}.", name, age);
            string str2 = "My name is " + name + " and I am " + age + ".";
            string str3 = $"My name is {name} and I am {age}.";

            string str4 = "My name is \nJeremy"; // переход на новую строку
            string str5 = "I am \t25"; // табуляция 

            // переход на новую строку (если не уверены, что программа будет использоваться именно на windows) 
            string str6 = $"My name is {Environment.NewLine}Jeremy";

            //string str7 = "I am Jeremy and I am a "good" programmer"; 
            //компилятор не поймет где кончается строка, тк "" используется для определения границ строки
            string str7 = "I am Jeremy and I am a \"good\" programmer"; // слеш (\) ставится перед кавычками, чтобы они считались частью строки

            string str8 = "C:\\tmp\\test_file.txt"; // чтобы слеш считался частью строки перед ним нужно поставить еще один слеш
            string str9 = @"C\tmp\test_file.txt"; // @ ставися для того, чтобы все слеши считались частью строки 

            Console.WriteLine(str9);

            int answer = 42;
            string result = string.Format("{0:d}", answer); // d - для выведения целого числа
            string result2 = string.Format("{0:d4}", answer); // число после d указывает на кол-во символом (слева добавляются нули, если число меньше указанного кол-ва)
            Console.WriteLine(result); // 42
            Console.WriteLine(result2); // 0042

            result = string.Format("{0:f}", answer); // f используется для дробного числа
            result2 = string.Format("{0:f4}", answer); // число после f указывает на кол-во знаков после запятой
            Console.WriteLine(result); // 42,00
            Console.WriteLine(result2); // 42,0000

            double answer2 = 42.08;
            result = string.Format("{0:f}", answer2); // по умолчанию два знака после запятой
            result2 = string.Format("{0:f1}", answer2); // если указать число меньше знаков после запятой, то число округлится 
            Console.WriteLine(result); // 42,08 
            Console.WriteLine(result2); // 42,1

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money); // по умолчанию 2 знака после запятой + C - приписывает знак денег в установленной валюте
            result2 = string.Format("{0:C4}", money);
            Console.WriteLine(result); // 12,80 Р
            Console.WriteLine(result2); // 12,8000 Р
            Console.WriteLine(money.ToString("C")); // формат можно указать сразу в аргументе при переводе типа в string (12,80 Р)

            // еще один способ нужного форматирования без использования string.Format
            result = $"{money:C2}";
            Console.WriteLine(result); // 12,80 Р
        }
        static void StringBuilderDemo()
        {
            // StringBuilder тип данных из пространства имен System.Text, который позволяет складывать строки
            // используется, если нужно сложить большое кол-во строк, тк его производительность в этом случае гораздо быстрее других способов
            // модифицирует изначальную строку, поэтому изменения не нужно каждый раз записывать в переменную
            // новый экземпляр создается с помощью оператора new
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Jeremy");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            // после создания преобразовываем в тип string, записывая в переменную, и производим нужные действия
            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringModification()
        {
            // функция, объединяющая строки
            string nameConcat = string.Concat("My ", "name ", "is ", "Jeremy ");
            Console.WriteLine(nameConcat);
            // еще один способ объединения строк
            // отличаются они различной скоростью производительности в разных случаях
            nameConcat = "My " + "name " + "is " + "Jeremy";
            Console.WriteLine(nameConcat);
            // эта функция поддерживает введение разделителя между соединяемыми строками, в данном случае - пробел
            nameConcat = string.Join(" ", "My", "name", "is", "Jeremy"); // string.Join("разделитель", "строка", "строка"....);
            Console.WriteLine(nameConcat);

            // ! обязательно нужно указать экземпляр для присвоения результата !
            // такие функции не модифицируют изначальную строку, они ВОЗВРАЩАЮТ результат модификации, который нужно присвоить в переменную

            // вставляет подстроку с указанного индекса
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat); // By the way, My name is Jeremy

            // удаляет символы из строки с указанного индекса, второе число указывает на кол-во символов для удаления
            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat); // удалит первый символ

            // замена символа на символ
            string replaced = nameConcat.Replace('m', 'z');
            Console.WriteLine(replaced); // заменит все вхождения m на z

            string data = "12; 28; 34; 25; 64";
            // создает массив из строк, где каждый элемент - это части строки, между указанным разделителем 
            string[] splitData = data.Split(';'); // в аргументе указывается разделитель 
            string first = splitData[0]; // теперь можно вызывать элементы созданного массива
            Console.WriteLine(first); // 12

            // преобразовывает строку в массив символов
            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]); // y
            // можно сделать тоже самое и с самой строкой, тк по сути это уже массив из символов
            Console.WriteLine(nameConcat[0]); // y

            // приведение к нижнему регистру
            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);
            // приведение к верхнему регистру
            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            // убирает пробелы в начале и в конце строки
            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }
        static void StringEmptiness()
        {
            // свойство, которое создает пустую строку, тоже самое, что ""
            string strEmp = string.Empty; 

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " F";
            string nullString = null; // пустота; объект, в котором ничего не хранится

            Console.WriteLine("IsNullOrEmpty");
            // статический метод, позволяющий проверить пустоту строки
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty); // true

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty); // false

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty); // false, тк пробел технически является символом

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty); // true 

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpaced");
            // статический метод, проверяющий пустоту строки, включая пробел
            bool isNullOrWhiteSpaced = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpaced); // true

            isNullOrWhiteSpaced = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpaced); // false

            isNullOrWhiteSpaced = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpaced); // true

            isNullOrWhiteSpaced = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpaced); // true
        }
        static void QueryingStrings()
        {
            string name = "abracadabra";
            //содержит ли строка нужный нам символ, возвращает true/false
            bool contA = name.Contains('a');
            bool contE = name.Contains('E');

            Console.WriteLine(contA); // true
            Console.WriteLine(contE); // false

            //заканчивается ли строка на определенный символ или строку, возвращает true/false
            bool endsAbra = name.EndsWith("abra");
            Console.WriteLine(endsAbra); // true

            // начинается ли строка с определенного символа или строки, возвращает true/false
            bool startsAbra = name.StartsWith("abra");
            Console.WriteLine(startsAbra); // true

            // показывает расположение в строке нужного символа, называет индекс, возвращает int
            // отсчет символовов начинается с 0
            // если таких символов несколько, возвращает первое вхождение
            int indexOfA = name.IndexOf('a', 1); // можно после запятой указать с какого индекса начать проверять 
            Console.WriteLine(indexOfA); // 3

            // возвращает индекс последнего вхождения нужного символа
            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR); // 9

            //свойство, подсчитывающее длину строки (указывает кол-во всех символов, те отсчет начинается с 1
            // ! при вызове метода в скобках указываются аргументы, при вызове свойства аргументы не нужны !
            Console.WriteLine(name.Length); // 11

            // возвращает подстроку (создает новый экземпляр строки, в которую будет входить часть изначальной строки
            string substFrom5 = name.Substring(5);  // если указать в аргументе одно число, то возьмет с указанного индекса до конца
            string substFromTo = name.Substring(0, 3); // если указать два числа через запятую, возьмет с указанного первго индекса по указанный второй, НЕ включая его 

            Console.WriteLine(substFrom5); // dabra
            Console.WriteLine(substFromTo); // abr
        }
        static void StaticAndInstaticMembers()
        {
            string name = new string("abracadabra"); // новый экземпляр строки с именем name
            // НЕ статические методы (или "член уровня экземпляра") вызываются на экземпляре (в данном случае на нашей строке с именем name)
            bool contA = name.Contains('a'); // [название экземпляра].[название метода](аргумент)
            bool contE = name.Contains('E');

            Console.WriteLine(contA);
            Console.WriteLine(contE);

            // статический метод вызывается на типе данных, и в данном случае возвращает созданный экземпляр
            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue); // статическое свойство, тк вызывается напрямую на типе, показывает минимально возможное значение типа int

            int x = 1;
            string xstr = x.ToString(); // не статический метод, тк вызывается на экземпляре, преобразует int в string
        }
        static void ComparisonOperations()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y; // равенство 
            Console.WriteLine(areEqual); // false

            bool result = x > y; // больше
            Console.WriteLine(result); // false

            result = x >= y; // больше или равно 
            Console.WriteLine(result); // false

            result = x < y; // меньше
            Console.WriteLine(result); // true

            result = x <= y; // меньше или равно
            Console.WriteLine(result); // true

            result = x != y; // не равно 
            Console.WriteLine(result); // true
        }
        static void MathOperations()
        {
            int x = 1;
            int y = 2;
            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z); // 3
            Console.WriteLine(k); // -1
            Console.WriteLine(a); // 0

            int b = z * 2; // 6
            int c = k / 2; // 0 тк тип данных int обрезает все числа после запятой (не округляет!)

            Console.WriteLine(b);
            Console.WriteLine(c);

            //вычесление остатка от деления
            a = 4 % 2; // 4 / 2 = 2 -> остатка нет -> в результат идет 0
            b = 5 % 2; // 5 / 2 = 2(1) -> остаток 1

            Console.WriteLine(a); // 0
            Console.WriteLine(b); // 1

            a = 3;
            a = a * a;

            a = 2 + 2 * 2;
            Console.WriteLine(a); // 6 тк в языке C# прописаны приоритеты арифметических вычислений 
            a = (2 + 2) * 2;
            Console.WriteLine(a); // 8 тк скобки дают максимальный приоритет выполнения

            a *= 2; // a = a * 2;
            Console.WriteLine(a);
            a /= 2; // a = a / 2;
            Console.WriteLine(a);
        }
        static void IncrementDecrementDemo()
        {
            int x = 1;
            x = x + 1; //сначала происходит вычесление, после чего значение присваевается в x
            Console.WriteLine(x);

            //инкремент
            x++; //постфиксная запись (х + 1)
            Console.WriteLine(x);
            ++x; //префиксная запись (х + 1) 
            Console.WriteLine(x);

            //декремент
            x = x - 1;
            x--;
            --x;
            Console.WriteLine(x);

            Console.WriteLine($"Learn about increments \nThe last x state is {x}");

            int j = x++; //сначала происходит присвоение значения в j потом инкремент икса на единицу
            Console.WriteLine(j); // 1
            Console.WriteLine(x); // 2
            j = ++x; //сначала происходит инкремент икса на единицу, а потом присвоение этого значения в j
            Console.WriteLine(j); // 3
            Console.WriteLine(x); // 3

            x += 2; // x = x + 2;
            j -= 2; // j = j - 2;
            Console.WriteLine(x);
            Console.WriteLine(j);
        }
        static void Overflaw()
        {
            checked //проверка ошибок, компилятор выдаст предупреждение об исключении, используется редко тк замедляет производительность программы
            {
                uint x = uint.MaxValue;

                Console.WriteLine(x);
                x = x + 1;
                Console.WriteLine(x); // = 0 тк произошло переполнение, что может привести к ошибкам в математических вычислениях
                x = x - 1;
                Console.WriteLine(x);
            }
        }
        static void ValiablesScopes()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c); 
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //внешние области видимости распространяются на внутренние, а внутренние на внешние - нет
        }
        static void Literals()
        {
            //для записи в бинарном виде перед литералом(значением) ставится 0b
            int x = 0b11; //3
            int y = 0b1101; //9
            int k = 0b10001001; // 137
            int m = 0b1000_1001; //137 значения можно разделять _ для удобства чтения

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine();

            //для записи в шестнадцатиричном виде перед литералом ставится 0x
            x = 0x1F; //31
            y = 0xFF0D; //65293
            k = 0x1FAB30EF; //531312879
            m = 0x1FAB_30EF; //531312879

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine();

            Console.WriteLine(4.5e2); //4.5 * 10^2 = 450
            Console.WriteLine(3.1E-1); //3.1 * 10^-1 = 0,31

            //для записи с помощью значений символьной таблицы перед значением ставится \x, значение заключяется в ''
            Console.WriteLine('\x78'); //x
            Console.WriteLine('\x5A'); //Z
            //значения таблицы юникод \u
            Console.WriteLine('\u0420'); //P
            Console.WriteLine('\u0421'); //C
        }
        static void Variables()
        {
            // целочисленный тип данных
            int x = -1;
            int y;
            y = 2;

            Int32 x1 = -1; // эквивалентная запись int x = -1

            //uint z = -1; - не скомпилируется и выдаст ошибку, тк в тип данных uint входят только положительные числа

            float f = 1.1f; //чтобы число скомпилировалось в тип данных float после значения нужно поставить f

            double d = 2.3; //дробные значения компилятор по умолчанию присваивает в double

            int x2 = 0;
            int x3 = new int(); // оператор new используется для инстанциации (создания экземпляров), после этого ставятся ()

            var a = 1; // оператор var сам выявляет тип данных по значению, которое нужно присвоить сразу

            decimal money = 3.0m; //для большей точности тк содержит больше знаков после запятой, чем double, после значения ставится m

            char character = 'A'; // символ
            string name = "John"; // строка

            // логический тип данных
            bool canDrive = true;
            bool canDraw = false;

            //объект может содержать любой тип данных
            object obj1 = 1;
            object obj2 = "obj2"; 

            Console.WriteLine(a);
            Console.WriteLine(name);
        }

      
    }
}

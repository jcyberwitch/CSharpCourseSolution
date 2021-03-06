using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ArrayCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void OtherIndexArrays()
        {
            // у массива можно изменить начальный индекс 
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            // можно выяснить первый и последний индекс массива
            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index:{myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
            Console.WriteLine();

            for (int j = 1; j < 5; j++)
            {
                Console.WriteLine($"{myArray.GetValue(j)} at index {j}");
            }

            // ДЕЛАТЬ ТАК НЕ СТОИТ 
        }
        static void JaggedArrays()
        {
            // зубчатые массивы - когда строки в многомерном массиве разной длины

            // указываем кол-во строк
            int[][] jaggedArray = new int[4][];
            // указываем кол-во элементов в каждой строке
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the number for a jagged array.");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);

                }
            }

            Console.WriteLine();
            Console.WriteLine("Printing the elements");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");

                }
                Console.WriteLine();
            }

            // такие массивы используются очень редко ради экономии памяти
        }
        static void MultidimArrays()
        {
            // многомерные массивы - те, которые состоят из нескольких строк и столбцов 

            // одномерный массив 1 2 3 4

            // двухмерные массивы
            //  1 2 3
            //  4 5 6 
            //  7 8 9

            // [,] - инициализация двухмерного массива
            // [x, y] - кол-во строк и столбцов

            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void StackQueueDemo()
        {
            // абстрактные типы данных (имеет определенный api, но нет ограничений в том, как внутри реализован)
            // .NET реализованны, как массивы
            // stack - стек (LIFO) последний пришел, первый ушел 
            // например, как в стопке посуды. Тарелку, которую положили последней, возьмут первой
            // queue - очередь (FIFO) первый пришел, первый ушел 
            // пример - любая очередь из людей 

            var stack = new Stack<int>();
            // добавление элементов
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            // удаляет элемент, а так же возвращает его 
            stack.Pop();

            // Peek - возвращает элемент, но не удаляет его 
            Console.WriteLine($"Should print out 3: {stack.Peek()}");

            // итерация элементов с последнего до первого 
            foreach (var n in stack)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

            var queue = new Queue<int>();
            // добавление элементов
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1: {queue.Peek()}");

            // удаляет элемент, а так же возвращает его 
            queue.Dequeue();

            // Peek - возвращает элемент, но не удаляет его
            Console.WriteLine($"Should print out 2: {queue.Peek()}");

            // итерация элементов с первого до последнего 
            foreach (var n in queue)
            {
                Console.WriteLine(n);
            }
        }
        static void DictionaryDemo()
        {
            // ассоциативный массив - где ключ (например фамилия) соотносится со значением (например телеф номер)
            // для такого массива используется тип Dictionary
            // работают на поиск значения по ключу очень быстро

            var people = new Dictionary<int, string>(); // <тип ключа, тип значения>
            // для добавление связки ключ-значение используется метод Add(ключ, значение)
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            // ключи обязаны быть уникальными, иначе возникнет исключение(ошибка в коде)

            // можно инициилизировать связки сразу при декларировании нового объекта
            people = new Dictionary<int, string>()
            {
                { 1, "John"},
                { 2, "Bob"},
                { 3, "Alice"},
            };

            // доступ по ключу
            string name = people[1];
            Console.WriteLine(name);

            // тип ключи вложенный в тип словаря, можно записывать как var
            // итерирование (организация обработки данных, при которой действия повторяются многократно) по ключам
            Console.WriteLine("Итерация по ключам");
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            // тип значений. так же можно использовать var
            Console.WriteLine("Итерация по значениям");
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            // (ctrl + .) - сочетание клавиш для быстрых исправлений 

            // можно запускать цикл по самому объекту типа словарь
            Console.WriteLine("Итерация по связкам ключ-значение");
            foreach (var /*KeyValuePair<int, string>*/ pair in people)
            {
                Console.WriteLine($"Key: {pair.Key} Value: {pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Кол-во элементов: {people.Count}");

            // поиск по ключу (работает очень быстро) и по значению (работает так же как поиск по массивам те перебирает каждое значение)
            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");
            Console.WriteLine($"Contains Key 2: {containsKey}, Contains Value John: {containsValue}");

            // удаляет связку ключ-значение по ключу, возвращает bool
            people.Remove(1);

            // если мы не знаем существует ли уже ключ, по которому мы хотим добавить значение
            // можно использовать TryAdd, который возвращает bool 
            // если бы мы использовали Add по ключу, который уже существует, возникла бы ошибка
            // при TryAdd исполнение кода вернет нам false и будет действовать в соответствии с кодом
            if (people.TryAdd(2, "Jeremy"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add using key 2");
            }

            // поиск значения по ключу так же возвращает bool 
            // [имя объекта].TryGetValue(ключ, out [тип объекта] [имя нового объекта, куда запишется значение, если оно будет найдено])
            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Значение по ключу 2: {val}");
            }
            else
            {
                Console.WriteLine("Не найдено");
            }

            // удаление всех связок
            people.Clear();
        }
        static void ListDemo()
        {
            // List - тип, который динамически расширяется 
            // находится в пространстве имен System.Collections.Generic
            // На самом деле он работает так - создает массив большего размера (расширяет в два раза, если места нет) и копирует туда исходные элементы, добавляя по следующему индексу новый элемент
            // мы можем сделать тоже самое вручную, а List делает это за нас автоматически 

            var intList = new List<int> { 1, 4, 2, 7, 5, 9, 12 };
            // метод Add для добавления элементов
            // не возвращает новый List, а модифицирует исходный
            intList.Add(7);

            // можно добавить сразу целый массив
            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            // удаляет элемент по первому вхождению, возвращает bool
            if (intList.Remove(1))
            {
                // чет можно сделать 
            }
            else
            {
                // и здесь тоже
            }

            // List поддерживает доступ по индексу
            // удаляет элемент по индексу
            intList.RemoveAt(0);

            // реверсирует элементы в обратную сторону
            intList.Reverse();

            // проверяет содержит ли нужный элемент, возвращает bool
            bool contains = intList.Contains(3);
            Console.WriteLine(contains);

            // поиск минимума и максимума (метод находится в пространстве имен System.Linq)
            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min = {min}, Max = {max}");


            // нахождение индекса первого и последнего вхождения элемента
            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);

            Console.WriteLine($"Index of 2 = {indexOf}, The last index of 2 = {lastIndexOf}");

            // тк поддерживается доступ по индексам, можно использовать цикл for и foreach 
            // для нахождения кол-ва элементов вместо Lenght, как у массивов, используется Count
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void ArrayType()
        {
            // при создании массива необходимо сразу же задавать его размерность
            // динамически рассширить массив невозможно, только создать новый размером больше

            // декларирование и инициализация на разных строчках 
            int[] a1;
            a1 = new int[10];

            // в одну строчку 
            int[] a2 = new int[5];

            // можно сразу указать элементы, даже не указывая размерность напрямую
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a4 = { 1, 3, 2, 4, 5 };

            // массивы имеют свой тип в классе array, поэтому на него работают некоторые функции
            Array myArray = new int[5];

            // создание массива через метод (указание типа, указание размера)
            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            // вместо обращения по индексу используются методы set(значение, индекс) и get(индекс)
            myArray2.SetValue(12, 0);

            Console.WriteLine(myArray2.GetValue(0));

            // бинарный поиск работает с отсортированными данными (от меньшего к большему по порядку) 
            // находит и возвращает индекс первого вхождения искомого элемента
            // бинарный поиск работает очень быстро
            // принцип работы - берет значение посередине, сравнивает с искомым и отсекает ненужную половину
            // продолжает до тех пор, пока не найдет нужный элемент
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            // метод копирования уровня класса - копирование одного массива в другой (имя массива откуда копируем, куда копируем, сколько элементов
            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            // так же можно использовать метод уровня экземпляра, копирования напрямую (куда, с какого индекса)
            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            // реверсирует массив (не возвращает новый, а модифицирует тот, который передан)
            Array.Reverse(copy);
            foreach (int c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            // сортировка массива от меньшего к большему
            Array.Sort(copy);
            foreach (int c in copy)
            {
                Console.WriteLine(c);
            }

            // очищение массива (все элементы станут по умолчанию нулями) 
            // передаем (массив, с какого индекса, сколько элементов очистить) 
            Array.Clear(copy, 0, numbers.Length);
        }
    }
}

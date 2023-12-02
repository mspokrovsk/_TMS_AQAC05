﻿using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                int[] array = { 1, 8, 14, -4, 0, 7 };

                PrintArray();

                Console.WriteLine();

                Array.Reverse(array);
                PrintArray();

                Console.WriteLine();

                void PrintArray()
                {
                    foreach (var item in array)
                    {
                        Console.Write($"{item}\t");
                    }
                }

                // -=================== Метод без параметров ===================-
                void MethodWithoutParameters()
                {
                    // Тело метода
                }

                // -=================== Метод без возвращаемого значения ===================-
                void PrintMessage(string message)
                {
                    Console.WriteLine(message);
                }

                PrintMessage("Text");
                string tmp = "Taskjdkasdh";
                PrintMessage(tmp);

                // -=================== Метод c возвращаемым значенем ===================-
                string GetInfo()
                {
                    ///...
                    return "Test";
                }

                string result = GetInfo();

                Console.WriteLine(result);

                // -=================== Метод с параметрами по умолчанию ===================-
                void DisplayGreeting(string greetingMessage, string name = "Гость")
                {
                    Console.WriteLine($"{greetingMessage}, {name}!");
                }

                DisplayGreeting("Hello");
                DisplayGreeting("Hello", " Alex");
                DisplayGreeting(" Alex", "Hello");

                // -=================== Метод с переменным числом аргументов ===================-
                int CalculateSum(params int[] numbers)
                {
                    int sum = 0;

                    foreach (int num in numbers)
                    {
                        sum += num;
                    }
                    return sum;
                }

                int sum1 = CalculateSum(1, 2, 3, 4, 5);
                int sum2 = CalculateSum(); // Пустой вызов

                Console.WriteLine("Sum 1: " + sum1);
                Console.WriteLine("Sum 2: " + sum2);

                // -=================== Передача параметров ===================-
                // -=================== По значению

                void SimpleAdd(int x, int y) //По умолчанию аргументы передаются по значению,
                {
                    int ans = x + y;

                    // Вызывающий код не увидит эти изменения, т.к. модифицируется копия исходных данных,
                    // х = 10000;
                    // у = 88888;
                }

                // -=================== По ссылке
                // -=================== Out
                // Значения выходных параметров должны быть установлены внутри вызываемого метода.
                int OutAdd(int x, int y, out int ans)
                {
                    ans = x + y;

                    return x * y;
                }

                // Присваивать начальные значения локальным переменным, используемым как выходные параметры, не обязательно
                // при условии, что они впервые используются
                OutAdd(90, 90, out int ans); // - Первый вариант

                //int ans;
                //Add(90, 90, out ans); // - Второй вариант

                Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);

                // Практическое применение в тестировании - возврат данных
                void FillTheseValues(out int a, out string b, out bool c)
                {
                    a = 9;
                    b = "Enjoy your string.";
                    c = true;
                }

                // -=================== Ref
                void ModifyValue(ref int value)
                {
                    //value = value * 2;
                }

                int mainValue = 5;      // Если закоментировать - будет ошибка
                Console.WriteLine($"mainValue is {mainValue}");
                ModifyValue(ref mainValue);
                Console.WriteLine($"mainValue now is {mainValue}");

                // -=================== Возврат значений ===================-
                // -=================== Возврат значения
                int GetPersonAge()
                {
                    return 25;
                }

                Console.WriteLine($"Age: {GetPersonAge()}");

                // -=================== Возврат нескольких значений
                (string, int, string) GetPersonInfo()
                {
                    return ("John", 25, "Test");
                }

                var person1 = GetPersonInfo();
                Console.WriteLine($"Name: {person1.Item1}, Age: {person1.Item2}");

                // -=================== Сжатый метод
                int ShortAdd(int х, int у) => х + у;

                // -=================== Рекурсивная функция
                int Factorial(int n)
                {
                    if (n == 1) return 1;

                    return n * Factorial(n - 1);
                }

                int factorial4 = Factorial(4);  // 24
                int factorial5 = Factorial(5);  // 120
                int factorial6 = Factorial(6);  // 720

                Console.WriteLine($"Факториал числа 4 = {factorial4}");
                Console.WriteLine($"Факториал числа 5 = {factorial5}");
                Console.WriteLine($"Факториал числа 6 = {factorial6}");

    */
            // -=================== Классы ===================-
            // -=================== Структура класса
/*
            EmptyClass emptyClass = new EmptyClass();

            Person personObj1 = new Person();
            Person personObj2 = new Person();

            Console.WriteLine(personObj1.Equals(personObj2));

            personObj1.Print();

            personObj1.name = "Alex";
            personObj1.age = 45;
            personObj1.Print();
            personObj2.Print();

            // -=================== Создание конструкторов
            PersonWithConstructor personWithConstructor = new PersonWithConstructor();
            personWithConstructor.Print();

            ConstructorCustom constructorCustom1 = new ConstructorCustom(10);
            Console.WriteLine(constructorCustom1.GetHashCode());
            ConstructorCustom constructorCustom2 = new ConstructorCustom("text");

            constructorCustom1 = new ConstructorCustom(20);
            Console.WriteLine(constructorCustom1.GetHashCode());

            ConstructorByDefault constructorByDefault = new ConstructorByDefault();

            ConstructorFull constructorFull1 = new ConstructorFull();
            ConstructorFull constructorFull2 = new ConstructorFull(1);
            ConstructorFull constructorFull3 = new ConstructorFull("test");

            // -=================== Цепочка вызова конструкторов
            PersonChain personChain1 = new PersonChain();
            PersonChain personChain2 = new PersonChain("Alex");
            PersonChain personChain3 = new PersonChain("Alex", 45);

            personChain1.Print();
            personChain2.Print();
            personChain3.Print();

            // -=================== Первичные конструкторы
            PersonPrimaryConstructors personPrimaryConstructors4 = new PersonPrimaryConstructors(name: "Alex", age: 23);
            //PersonPrimaryConstructors personPrimaryConstructors1 = new PersonPrimaryConstructors();          - Ошибка
            PersonPrimaryConstructors personPrimaryConstructors2 = new PersonPrimaryConstructors(name: "Alex");
            //PersonPrimaryConstructors personPrimaryConstructors3 = new PersonPrimaryConstructors(age: 45);   - Ошибка

            personPrimaryConstructors2.Print();
            personPrimaryConstructors4.Print();

            // -=================== This
            PersonThis personThis = new PersonThis("Alex", 45);

            NamespaceA.NamespaceC.ClassA classA = new NamespaceA.NamespaceC.ClassA();
            classA.Print();

            NamespaceB.ClassA classAB = new NamespaceB.ClassA();
            classAB.Print();
            */

            // -=================== Практика ===================-
            // -=================== Задача 1
            Student[] students = new Student[14];

            for (int i = 0; i < 14; i++)
            {
                students[i] = new Student();
                students[i].name = "Alex" + i;
                students[i].group = new Random().Next(2);
                students[i].diplomMark = new Random().Next(1, 11);
            }

            Console.WriteLine($"Students.Length: {students.Length}");
            
            foreach (var student in students)
            {
                Console.Write($"Name: {student.name}, Group: {student.group}, Mark: {student.diplomMark}");
                Console.WriteLine();
            }
            Console.WriteLine();
            
            // -=================== Задача 2
            foreach (Student student in students)
            {
                if (student.diplomMark == 9 || student.diplomMark == 10)
                {
                    student.Print();                    
                } 
            }
            Console.WriteLine();
            
            // -=================== Задача 3
            Student[] students1 = new Student[14];
            
            for (int i = 0; i < 14; i++) students1[i] = new Student("Alex" + i);
            foreach (var student in students1) student.Print();
            Console.WriteLine();
            
            // -=================== Задача 4
            Cat cat = new Cat();
            cat.name = "Barsik";
            cat.age = 2;
            cat.maxFoodCount = 3;
            
            Console.WriteLine($"Наелся? - {cat.Feed(2)}");
            Console.WriteLine($"Наелся? - {cat.Feed(4)}");
            Console.WriteLine("Наелся? - {0}", cat.Feed(3) ? "Да" : "Нет");
            Console.WriteLine();

            //Домашнее задание
            //Задание 1
            // Создаем экземпляры класса Phone, используя разные конструкторы
            Phone phone1 = new Phone();
            Phone phone2 = new Phone(123456789, "Samsung");
            Phone phone3 = new Phone(0.2, 987654321, "iPhone");

            // Выводим значения переменных каждого объекта на консоль
            Console.WriteLine($"Телефон 1: номер {phone1.number}, модель {phone1.model}, вес {phone1.weight}");
            Console.WriteLine($"Телефон 2: номер {phone2.number}, модель {phone2.model}, вес {phone2.weight}");
            Console.WriteLine($"Телефон 3: номер {phone3.number}, модель {phone3.model}, вес {phone3.weight}");
            Console.WriteLine();
            // Вызываем метод receiveCall и getNumber для каждого объекта
            phone1.receiveCall("Мама");
            Console.WriteLine($"номер телефона: {phone1.getNumber()}");
            phone2.receiveCall("Друг");
            Console.WriteLine($"номер телефона: {phone2.getNumber()}");
            phone3.receiveCall("Коллега");
            Console.WriteLine($"номер телефона: {phone3.getNumber()}");
            Console.WriteLine();
            // Вызываем метод sendMessage с двумя и пятью номерами телефонов
            phone1.sendMessage(123456789, 987654321);
            phone2.sendMessage(111111111, 222222222, 333333333, 444444444, 555555555);
            Console.WriteLine();
            //Задание 2
            CreditCard card1 = new CreditCard { cardNumber = "1111", currentBalance = 100 };
            CreditCard card2 = new CreditCard { cardNumber = "2222", currentBalance = 200 };
            CreditCard card3 = new CreditCard { cardNumber = "3333", currentBalance = 300 };
            //Выводим на консоль текущую сумму на счете
            card1.PrintCardInfo();
            card2.PrintCardInfo();
            card3.PrintCardInfo();
            //Пополняем счета первой и второй карты
            Console.WriteLine("Введите сумму для пополнения первого счета:");
            decimal deposit1 = decimal.Parse(Console.ReadLine());
            card1.Deposit(deposit1);

            Console.WriteLine("Введите сумму для пополнения второго счета:");
            decimal deposit2 = decimal.Parse(Console.ReadLine());
            card2.Deposit(deposit2);
            //Снимаем сумму с третьей карты
            Console.WriteLine("Введите сумму для снятия с третьего счета:");
            decimal withdraw3 = decimal.Parse(Console.ReadLine());
            card3.Withdraw(withdraw3);
            //Выводим на консоль текущее состояние всех карт
            card1.PrintCardInfo();
            card2.PrintCardInfo();
            card3.PrintCardInfo();


        }
    }
}
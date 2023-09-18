using System;

namespace Тумаков___Лабораторная_работа__3
{
    class Program
    {
        enum Bank
        {
            Текущий_счет,
            Сберегательный_счет
        }
        struct BankAccaunt
        {
            public int accauntNumber;
            public string accauntType;
            public double accauntBalance;
            public void dataPrint()
            {
                Console.WriteLine($"{accauntType} счет под номером {accauntNumber} содержит {accauntBalance} рублей");
            }
        }
        enum ВУЗ
        {
            КГУ,
            КАИ,
            КХТИ
        }
        struct Worker
        {
            public string personName;
            public ВУЗ workingPlace;
            public void dataPrint()
            {
                Console.WriteLine($"{personName} работает в {workingPlace}");
            }
        }
        static void Main(string[] args)
        {
            // Упражнение 3.1. Создание перечисляемого типа данных, отображающего виды банковских счетов.
            Console.WriteLine("{0, 106}", "УПРАЖНЕНИЕ 3.1. СОЗДАНИЕ ПЕРЕЧИСЛЯЕМОГО ТИПА ДАННЫХ, ОТОБРАЖАЮЩЕГО ВИДЫ БАНКОВСКИХ СЧЕТОВ \n");

            Bank curentAccount = Bank.Текущий_счет;
            Bank savingAccaunt = Bank.Сберегательный_счет;

            Console.WriteLine($"Банк имеет {curentAccount} и {savingAccaunt}");


            // Упражнение 3.2. Создание структуры, которая содержит основную информацию о банкоском счете.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,107}", "УПРАЖНЕНИЕ 3.2. СОЗДАНИЕ СТРУКТУРЫ, КОТОРАЯ СОДЕРЖИТ ОСНОВНУЮ ИНФОРМАЦИЮ О БАНКОВСКОМ СЧЕТЕ \n");

            BankAccaunt myAccaunt = new BankAccaunt();
            myAccaunt.accauntType = "Сберегательный";
            myAccaunt.accauntNumber = 848646268;
            myAccaunt.accauntBalance = 13483294;

            myAccaunt.dataPrint();

            // Домашнее задание 3.1. Создание перечисляемого типа, содержащего вузы, и структуры с данными работника.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,110}", "ДОМАШНЕЕ ЗАДАНИЕ 3.1. СОЗДАНИЕ ПЕРЕЧИСЛЯЕМОГО ТИПА, СОДЕРЖАЩЕГО ВУЗЫ, И СТРУКТУРЫ С ДАННЫМИ РАБОТНИКА \n");

            Worker universityWorker = new Worker();
            universityWorker.personName = "Иванов Иван Иванович";
            ВУЗ universitiy = ВУЗ.КАИ;
            universityWorker.workingPlace = universitiy;

            universityWorker.dataPrint();
        }
    }
}

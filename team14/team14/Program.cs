using System;
using System.Collections.Generic;

namespace team14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Бесконечный цикл работы программы {
                Вывод главного меню  
                Выбор команды
                Выполнить выбранную команду
            }
             */
            IList<Worker> list = new List<Worker>();
            Worker.Filter = new Filter();
            string ch;
            // Бесконечный цикл работы программы
            do
            {
                // Вывод главного меню
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввод нового работника");
                Console.WriteLine("2. Вывод работников");
                Console.WriteLine("3. Ввод значений фильтра");
                Console.WriteLine("4. Вывод отфильтрованных значений");

                // Выбор команды
                ch = Console.ReadLine();

                // Выполнить выбранную команду
                switch (ch)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ввод нового работника: ");
                        Worker.AddNewWorker(list);
                        break;

                    case "2":
                        Console.Clear();
                        Worker.PrintAllWorkers(list);
                        break;

                    case "3":
                        Console.Clear();
                        Worker.Filter.Input();
                        break;

                    case "4":
                        Console.Clear();
                        Worker.PrintFilteredWokers(list);
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (int.Parse(ch) < 5);
        }
    }


    /// <summary>
    /// Структура "Фильтр"
    /// </summary>
    struct Filter
    {
        #region Поля фильтра

        public string Surname;                     // Фамилия
        public string Position;                    // Должность

        public DateTime? ContractSigningDateMin;   // Дата подписания контракта (min)
        public DateTime? ContractSigningDateMax;   // Дата подписания контракта (max)

        public uint? ContractTermMin;              // Срок действия контракта (min)
        public uint? ContractTermMax;              // Срок действия контракта (max)

        public uint? SalaryMin;                    // Срок действия контракта (min)
        public uint? SalaryMax;                    // Срок действия контракта (max)

        #endregion

        #region Методы для ввода полей фильтра с клавиатуры
        
        /// <summary>
        /// Ввод значений фильтра с клавиатуры
        /// </summary>
        public void Input()
        {
            Console.WriteLine("Введите значение фильтра поля \"Фамилия\":");
            Surname = Console.ReadLine();

            Console.WriteLine("Введите значение фильтра поля \"Позиция\":");
            Position = Console.ReadLine();

            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMin = Filter.InputDateTime();

            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMax = Filter.InputDateTime();

            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMin = Filter.InputUint();

            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMax = Filter.InputUint();

            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Оклад\"");
            SalaryMin = Filter.InputUint();

            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Оклад\"");
            SalaryMax = Filter.InputUint();
        }
        #endregion
        
        /// <summary>
        /// Ввод даты с консоли
        /// </summary>
        /// <returns> Введенна дата</returns>
        private static DateTime? InputDateTime()
        {
            /*
            Прочитать строку с клавиатуры
            if введеная строка не пуста {
                Преобразуем строку в дату
                if преобразование успешно {
                    вернуть дату
                }
                else {
                    Вывести сообщение об ошибке
                }
            }
            вернуть NULL
            */
            
            // Прочитать строку с клавиатуры
            string temp = Console.ReadLine();
            // if введеная строка не пуста
            if (temp != String.Empty)
            {
                try
                {
                    // Преобразуем строку в дату
                    var result = DateTime.Parse(temp);
                    //  if преобразование успешно {
                    //      вернуть дату
                    //  }
                    return result;
                }
                catch (Exception e)
                {
                    //  else {
                    //      Вывести значение об ошибке
                    //  }
                    Console.WriteLine("Некорректный ввод! Повторите операцию.");
                }
            }
            return null;
        }

        /// <summary>
        /// Чтение числа с клавиатуры 
        /// </summary>
        /// <returns> Введенное число </returns>
        private static uint? InputUint()
        {
            /*
            Прочитать строку с клавиатуры
            if введеная строка не пуста {
                Преобразуем строку в число
                if преобразование успешно {
                    вернуть число
                }
                else {
                    Вывести сообщение об ошибке
                }
            }
            вернуть NULL
            */

            string temp = Console.ReadLine();
            // if введеная строка не пуста
            if (temp != String.Empty)
            {
                try
                {
                    // Преобразуем строку в дату
                    var result = UInt32.Parse(temp);
                    //  if преобразование успешно {
                    //      вернуть число
                    //  }
                    return result;
                }
                catch (Exception e)
                {
                    //  else {
                    //      Вывести значение об ошибке
                    //  }
                    Console.WriteLine("Некорректный ввод! Повторите операцию.");
                }
            }
            return null;
        }
    }

    /// <summary>
    /// Структура "Работник"
    /// </summary>
    struct Worker
    {
        #region Свойства

        public string Surname;               // Фамилия
        public string Position;              // Должность
        public DateTime ContractSigningDate; // Дата подписания контракта
        public uint ContractTerm;            // Срок действия контракта
        public uint Salary;                  // Оклад

        public static Filter Filter;         // Фильтр

        #endregion


        /// <summary>
        /// Ввод информации о работнике с клавиатуры
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void AddNewWorker(IList<Worker> list)
        {
            try
            {
                Worker worker = new Worker();

                Console.Write("Введите фамилию работника:  ");
                worker.Surname = Console.ReadLine();
                while (String.IsNullOrEmpty(worker.Surname))
                {
                    Console.Write("Повторите ввод фамилии:");
                    worker.Surname = Console.ReadLine();
                }

                Console.Write("Введите должность работника:  ");
                worker.Position = Console.ReadLine();
                while (String.IsNullOrEmpty(worker.Position))
                {
                    Console.Write("Повторите ввод должности:");
                    worker.Surname = Console.ReadLine();
                }
                
                Console.Write("Введите дату подписания контракта в формате (DD.MM.YYYY):  ");
                worker.ContractSigningDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Введите срок действия контракта:  ");
                worker.ContractTerm = Convert.ToUInt32(Console.ReadLine());
                
                Console.Write("Введите оклад работника:  ");
                worker.Salary = Convert.ToUInt32(Console.ReadLine());
                list.Add(worker);
            }
            catch 
            {
                Console.Clear();
                Console.WriteLine("Ошибка!");
            }           
        }

        /// <summary>
        /// Вывод информации о работнике на экран
        /// </summary>
        public void PrintWorker()
        {
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Дата подписания контракта: {ContractSigningDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Срок контракта: {ContractTerm}");
            Console.WriteLine($"Оклад: {Salary}");
        }

        /// <summary>
        /// Вывод всех работников на экран
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void PrintAllWorkers(IList<Worker> list)
        {
            int count = 0;
            foreach (var el in list)
            {
                Console.WriteLine($"{++count}-й работник:");
                el.PrintWorker();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод работников, удовлетворяющих фильтру
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void PrintFilteredWokers(IList<Worker> list)
        {
            int count = 0;
            Console.WriteLine($"Вывод отфильтрованных работников");
            foreach (var el in list)
            {
                Console.WriteLine($"{++count}-й работник:");
                if (el.CheckWithFilter())
                {
                    el.PrintWorker();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Проверка, удовлетворяет ли работник условиям фильтра
        /// </summary>
        /// <returns> Возвращает true если структура соответсвует фильтру, иначе false </returns>
        public bool CheckWithFilter()
        {
            // Проверка поля "Оклад"
            if ((Filter.SalaryMax != null) && (this.Salary > Filter.SalaryMax))
                return false;
            if ((Filter.SalaryMin != null) && (this.Salary < Filter.SalaryMin))
                return false;

            // Проверка поля "Срок действия контракта"
            if ((Filter.ContractTermMax != null) && (this.ContractTerm > Filter.ContractTermMax))
                return false;
            if ((Filter.ContractTermMin != null) && (this.ContractTerm < Filter.ContractTermMin))
                return false;

            // Проверка поля "Дата подписания котракта"
            if ((Filter.ContractSigningDateMax != null) && (this.ContractSigningDate > Filter.ContractSigningDateMax))
                return false;
            if ((Filter.ContractSigningDateMin != null) && (this.ContractSigningDate < Filter.ContractSigningDateMin))
                return false;

            // Проверка поля "Должность"
            if ((Filter.Position != null) && (!this.Position.Contains(Filter.Position)))
                return false;

            // Проверка поля "Фамилия"
            if ((Filter.Surname != null) && (!this.Surname.Contains(Filter.Surname)))
                return false;

            // Все поля прошли проверку
            return true;
        }
    }
}

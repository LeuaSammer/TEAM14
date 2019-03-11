using System;
using System.Collections.Generic;

namespace team14
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    struct Filter
    {
        #region Поля фильтра
        /// <summary>
        /// Значение фильтра для поля "Фамилия"
        /// </summary>
        public string SurnameFilterValue { get; set; }

        /// <summary>
        /// Значение фильтра для поля "Должность"
        /// </summary>
        public string PositionFilterValue { get; set; }

        /// <summary>
        /// Значение минимальной границы диапазона для поля "Дата подписания контракта"
        /// </summary>
        public DateTime? ContractSigningDateMinValue { get; set; }

        /// <summary>
        /// Значение максимальной границы диапазона для поля "Дата подписания контракта"
        /// </summary>
        public DateTime? ContractSigningDateMaxValue { get; set; }

        /// <summary>
        /// Значение минимальной границы диапазона для поля "Срок действия контракта"
        /// </summary>
        public uint? ContractTermMinValue { get; set; }

        /// <summary>
        /// Значение максимальной границы диапазона для поля "Срок действия контракта"
        /// </summary>
        public uint? ContractTermMaxValue { get; set; }

        /// <summary>
        /// Значение минимальной границы диапазона для поля "Оклад"
        /// </summary>
        public uint? SalaryMinValue { get; set; }
        /// <summary>
        /// Значение максимальной границы диапазона для поля "Оклад"
        /// </summary>
        public uint? SalaryMaxValue { get; set; }
        #endregion

        #region Методы для ввода полей фильтра с клавиатуры 
        /// <summary>
        /// Ввод значения фильтра для поля "Фамилия"
        /// </summary>
        public void InputSurnameFilterValue()
        {
            Console.WriteLine("Введите значение филтра поля \"Фамилия\":");
            SurnameFilterValue = Console.ReadLine();
        }
        /// <summary>
        /// Ввод значения фильтра для поля "Должность"
        /// </summary>
        public void InputPositionFilterValue()
        {
            Console.WriteLine("Введите значение филтра поля \"Позиция\":");
            SurnameFilterValue = Console.ReadLine();
        }

        /// <summary>
        /// Ввод значения верхней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputContractSigningDateMaxFilterValue()
        {
            Console.WriteLine("Введите значение верхней страницы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMaxValue = Helper.InputDateTime();
        }
        /// <summary>
        /// Ввод значения нижней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputContractSigningDateMinFilterValue()
        {
            Console.WriteLine("Введите значение верхней страницы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMinValue = Helper.InputDateTime();
        }

        /// <summary>
        /// Ввод значения нижней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputContractTermMinValue()
        {
            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMinValue = Helper.InputUint();
        }
        /// <summary>
        /// Ввод значения верхней границы диапазона фильтра поля "Срок действия договора"
        /// </summary>
        public void InputContractTermMaxValue()
        {
            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMaxValue = Helper.InputUint();
        }

        /// <summary>
        /// Ввод значения нижней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputSalaryMinValue()
        {
            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Оклад\"");
            SalaryMinValue = Helper.InputUint();
        }
        /// <summary>
        /// Ввод значения верхней границы диапазона фильтра поля "Оклад"
        /// </summary>
        public void InputSalaryMaxValue()
        {
            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Оклад\"");
            SalaryMinValue = Helper.InputUint();
        }
        #endregion

    }

    struct Worker
    {
        #region Свойства

        public string   Surname;             // Фамилия
        public string   Position;            // Должность
        public DateTime ContractSigningDate; // Дата подписания контракта
        public uint     ContractTerm;        // Срок действия контракта
        public uint     Salary;              // Оклад

        public static Filter Filter;         // Фильтр

        #endregion


        /// <summary>
        /// Ввод информации о работнике с клавиатуры
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void AddNewWorker(IList<Worker> list)
        {
            Worker worker = new Worker();
            Console.Write("Введите фамилию работника:  ");
            worker.Surname = Console.ReadLine();
            Console.Write("Введите должность работника:  ");
            worker.Position = Console.ReadLine();
            Console.Write("Введите дату подписания контракта в формате (DD.MM.YYYY):  ");
            worker.ContractSigningDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите срок действия контракта:  ");
            worker.ContractTerm = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите оклад работника:  ");
            worker.Salary = Convert.ToUInt32(Console.ReadLine());
            list.Add(worker);
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
        /// <param name="filter"></param>
        public bool CheckWithFilter()
        {
            //Поочередная проверка полей
            //    1. Поле "Оклад"
            //    2. Поле "Срок действия контракта"
            //    3. Поле "Дата подписания контракта"
            //    4. Поле "Должность"
            //    5. Поле "Фамилия"

            //Проверка поля "Оклад"
            if ((Filter.SalaryMaxValue != null) && (this.Salary > Filter.SalaryMaxValue))
                return false;
            if ((Filter.SalaryMinValue != null) && (this.Salary < Filter.SalaryMinValue))
                return false;

            //Проверка поля "Срок действия контракта"
            if ((Filter.ContractTermMaxValue != null) && (this.ContractTerm > Filter.ContractTermMaxValue))
                return false;
            if ((Filter.ContractTermMinValue != null) && (this.ContractTerm < Filter.ContractTermMinValue))
                return false;

            //Проверка поля "Дата подписания котракта"
            if ((Filter.ContractSigningDateMaxValue != null) && (this.ContractSigningDate > Filter.ContractSigningDateMaxValue))
                return false;
            if ((Filter.ContractSigningDateMinValue != null) && (this.ContractSigningDate < Filter.ContractSigningDateMinValue))
                return false;

            //Проверка поля "Должность"
            if ((Filter.PositionFilterValue != null) && (!this.Position.Contains(Filter.PositionFilterValue)))
                return false;

            //Проверка поля "Фамилия"
            if ((Filter.SurnameFilterValue != null) && (!this.Surname.Contains(Filter.SurnameFilterValue))) return false;

            //Все поля прошли проверку
            return true;
        }
    }

    public class Helper
    {
        /// <summary>
        /// Ввод даты с клавиатуры
        /// </summary>
        public static DateTime? InputDateTime(bool nullable = true)
        {

            //Выход = false
            //Результат = null
            //Пока (Выход != true) {
            //      temp = read()
            //      Если temp пустая строка {
            //          Выход = true
            //          Результат = null
            //      }
            //      Иначе {
            //          Преобразуем строку в дату
            //          Если есть ошибки вывести сообщение об ошибке
            //          Иначе {
            //              Выход = true
            //              Результат = Введеная дата
            //          }
            //      }
            //  }
            //  Вернуть результат

            //Инициализация переменных
            bool exit = false;
            DateTime? result = null;
            while (!exit)
            {
                //Чтение строки с консоли
                string temp = Console.ReadLine();
                //Проверка на пустую строку
                if (temp == String.Empty && nullable)
                {
                    //Заносим пустое значение в результат
                    result = null;
                    exit = true;
                }
                else
                {
                    try
                    {
                        //Преобразование строки в дату и помещение в результат
                        result = DateTime.Parse(temp);
                        exit = true;
                    }
                    catch (Exception e)
                    {
                        //Вывод сообщения об ошибке
                        Console.WriteLine("Некорректный ввод! Повторите операцию.");
                    }
                }
            }
            //Возвращение результата
            return result;
        }
        /// <summary>
        /// Ввод целого числа с клавиатуры
        /// </summary>
        public static uint? InputUint(bool nullable = true)
        {

            //Выход = false
            //Результат = null
            //Пока (Выход != true) {
            //    temp = read()
            //    Если temp пустая строка {
            //        Результат = null
            //        Выход = true
            //    }
            //    Иначе {
            //        Преобразуем строку в число
            //        Если есть ошибки вывести сообщение об ошибке
            //        Иначе {
            //              Выход = true
            //              Результат = Введенное число
            //        }
            //    }
            //}
            //Вернуть результат

            uint? result = 0;
            bool exit = false;
            while (!exit)
            {
                //Чтение строки с консоли
                string temp = Console.ReadLine();
                if (temp == String.Empty && nullable)
                {
                    //Заносим пустое значение в результат
                    result = null;
                    exit = true;
                }
                else
                {
                    try
                    {
                        //Преобразование строки в число
                        result = UInt32.Parse(temp);
                        exit = true;
                    }
                    catch (Exception e)
                    {
                        //Вывод сообщения об ошибке
                        Console.WriteLine("Некорректный ввод! Повторите операцию.");
                    }
                }
            }
            return result;
        }
    }
}
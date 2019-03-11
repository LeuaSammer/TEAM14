﻿using System;
using System.Collections.Generic;

namespace team14
{

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
        public void InputSurnameFilterValue() {
            Console.WriteLine("Введите значение филтра поля \"Фамилия\":");
            SurnameFilterValue = Console.ReadLine();
        }
        /// <summary>
        /// Ввод значения фильтра для поля "Должность"
        /// </summary>
        public void InputPositionFilterValue() {
            Console.WriteLine("Введите значение филтра поля \"Позиция\":");
            SurnameFilterValue = Console.ReadLine();
        }

        /// <summary>
        /// Ввод значения верхней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputContractSigningDateMaxFilterValue() {
            Console.WriteLine("Введите значение верхней страницы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMaxValue = InputDateTime();
        }
        /// <summary>
        /// Ввод значения нижней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputContractSigningDateMinFilterValue() {
            Console.WriteLine("Введите значение верхней страницы диапазона фильтра поля \"Дата подписания договора\"");
            ContractSigningDateMinValue = InputDateTime();
        }
        
        /// <summary>
        /// Ввод значения нижней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputContractTermMinValue() {
            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMinValue = InputUint();
        }
        /// <summary>
        /// Ввод значения верхней границы диапазона фильтра поля "Срок действия договора"
        /// </summary>
        public void InputContractTermMaxValue() {
            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Срок дейстрвия контракта\"");
            ContractTermMaxValue = InputUint();
        }

        /// <summary>
        /// Ввод значения нижней границы диапазона фильтра поля "Дата подписания договора"
        /// </summary>
        public void InputSalaryMinValue() {
            Console.WriteLine("Введите значение нижней границы диапазона фильтра поля \"Оклад\"");
            SalaryMinValue = InputUint();
        }
        /// <summary>
        /// Ввод значения верхней границы диапазона фильтра поля "Оклад"
        /// </summary>
        public void InputSalaryMaxValue() {
            Console.WriteLine("Введите значение верхней границы диапазона фильтра поля \"Оклад\"");
            SalaryMinValue = InputUint();
        }
        #endregion

        #region Приватные методы
        /// <summary>
        /// Ввод даты с клавиатуры
        /// </summary>
        private DateTime? InputDateTime()
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
                if (temp == String.Empty)
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
        private uint? InputUint()
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
                if (temp == String.Empty)
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
        #endregion
    }

    struct Worker
    {
        #region Свойства

        /// <summary>
        /// Фамилия работника
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Дата подписания контракта
        /// </summary>
        public DateTime ContractSigningDate { get; set; }
        /// <summary>
        /// Срок действия контракта
        /// </summary>
        public uint ContractTerm { get; set; }
        /// <summary>
        /// Оклад
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// Фильтр
        /// </summary>
        public static Filter Filter { get; set; }

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
            foreach(var el in list)
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
            if (!this.Position.Contains(Filter.PositionFilterValue)) return false;

            //Проверка поля "Фамилия"
            if (!this.Surname.Contains(Filter.SurnameFilterValue)) return false;

            //Все поля прошли проверку
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
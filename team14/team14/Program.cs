using System;
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
        public uint SalaryMinValue { get; set; }
        /// <summary>
        /// Значение максимальной границы диапазона для поля "Оклад"
        /// </summary>
        public uint SalaryMaxValue { get; set; }
        #endregion

        #region Метод для ввода полей фильтра с клавиатуры 
        public void InputSurnameFilterValue() { }
        public void InputPositionFilterValue() { }
        public void InputContractSigningDateMaxFilterValue() { }
        public void InputContractSigningDateMinxFilterValue() { }
        public void InputContractTermMinValue() { }
        public void InputContractTermMaxValue() { }
        public void InputSalaryMinValue() { }
        public void InputSalaryMaxValue() { }
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

        #endregion


        /// <summary>
        /// Ввод информации о работнике с клавиатуры
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void AddNewWorker(IList<Worker> list)
        {
        }

        /// <summary>
        /// Вывод информации о работнике на экран
        /// </summary>
        public void PrintWorker()
        {

        }

        /// <summary>
        /// Вывод всех работников на экран
        /// </summary>
        /// <param name="list">Список работников</param>
        public static void PrintAllWorkers(IList<Worker> list)
        {

        }

        /// <summary>
        /// Вывод работников, удовлетворяющих фильтру
        /// </summary>
        /// <param name="list">Список работников</param>
        /// <param name="filter">Фильтр</param>
        public static void PrintFilteredWokers(IList<Worker> list, Filter filter)
        {

        }

        /// <summary>
        /// Проверка, удовлетворяет ли работник условиям фильтра
        /// </summary>
        /// <param name="filter"></param>
        public void CheckWithFilter(Filter filter)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

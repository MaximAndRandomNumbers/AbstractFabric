using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Абстрактный класс описывающий настройки 
    /// приложения
    /// </summary>
    abstract class Config
    {
        /// <summary>
        /// Язык приложения
        /// </summary>
        public String Language { get; protected set; }
        /// <summary>
        /// Знак валюты
        /// </summary>
        public String CurrencySign { get; protected set; }
        /// <summary>
        /// Разделитель десятичных дробей
        /// </summary>
        public char Delimeter { get; protected set; }  
        /// <summary>
        /// Приветственное сообщение
        /// </summary>
        public String HelloMessage { get; protected set; }
        /// <summary>
        /// Временная зона в виде смещения относительно UTC
        /// </summary>
        public int TimeZone { get; protected set; }
        /// <summary>
        /// Формат даты (dd::mm:yyyy или mm:dd:yyyy)
        /// </summary>
        public String DateFormat { get; protected set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация класса ConfigExtra
    /// с дополнительными настройками для России
    /// </summary>
    class RussianConfigExtra : ConfigExtra
    {
        public RussianConfigExtra()
        {
            InterfaceColor = "blue";
            NewsFilter = new string[] { "Россия", "Москва", "СПБ", "Санкт-Петербург", "российский"};
            AdsList = new string[] {"Мираторг", "Газпром", "Сбербанк"};
            ClosestServersIP = new string[] { "122.21.234.23", "122.11.244.23", "122.61.244.23" };
        }
    }
}

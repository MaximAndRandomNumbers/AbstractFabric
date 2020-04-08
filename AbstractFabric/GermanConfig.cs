using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация класса Config
    /// с настройками для Германии
    /// </summary>
    class GermanConfig : Config
    {
        public GermanConfig()
        {
            Language = "German";
            CurrencySign = "Euro";
            Delimeter = ',';
            HelloMessage = "Guten Tag!";
            TimeZone = 2;
            DateFormat = "dd:mm:yyyy";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация класса Config
    /// с настройками для России
    /// </summary>
    class RussianConfig : Config
    {
        public RussianConfig()
        {
            Language = "Russian";
            CurrencySign = "Ruble";
            Delimeter = ',';
            HelloMessage = "Здравсвуйте!";
            TimeZone = 3;
            DateFormat = "dd:mm:yyyy";
        }
    }
}

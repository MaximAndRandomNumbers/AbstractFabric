using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация класса Config
    /// с настройками для Китая
    /// </summary>
    class ChineseConfig : Config
    {
        public ChineseConfig()
        {
            Language = "Chinese";
            CurrencySign = "Yuan";
            Delimeter = ',';
            HelloMessage = "你好";
            TimeZone = 8;
            DateFormat = "yyyy-m-d";
        }
    }
}

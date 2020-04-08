using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация класса ConfigExtra
    /// с дополнительными настройками для Китая
    /// </summary>
    class ChineseConfigExtra : ConfigExtra
    {
        public ChineseConfigExtra()
        {
            InterfaceColor = "red";
            NewsFilter = new string[] { "Китай", "Пекин", "КНР" };
            AdsList = new string[] { "Huawei", "Xiaomi" };
            ClosestServersIP = new string[] { "172.21.244.23", "172.51.244.23", "172.41.244.23" };
        }
    }
}

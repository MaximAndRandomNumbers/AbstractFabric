using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация класса ConfigExtra
    /// с дополнительными настройками для Германии
    /// </summary>
    class GermanConfigExtra : ConfigExtra
    {
        public GermanConfigExtra()
        {
            InterfaceColor = "black";
            NewsFilter = new string[] { "Германия", "немецкий", "Берлин" };
            AdsList = new string[] {"BMW","Bayer" };
            ClosestServersIP = new string[] { "182.21.244.23", "182.51.224.63", "182.71.244.23" };
        }
    }
}

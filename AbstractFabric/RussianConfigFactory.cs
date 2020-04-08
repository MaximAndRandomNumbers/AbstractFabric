using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация AbstractConfigFactory
    /// для генерации настроек для России
    /// </summary>
    class RussianConfigFactory : AbstractConfigFactory
    {
        /// <summary>
        /// Возвращает настройки приложения для России
        /// </summary>
        /// <returns>объект Config</returns>
        public override Config GetConfig()
        {
            return new RussianConfig();
        }
        /// <summary>
        /// Возвращает дополнительные настройки приложения для России
        /// </summary>
        /// <returns>объект ConfigExtra</returns>
        public override ConfigExtra GetConfigExtra()
        {
            return new RussianConfigExtra();
        }
    }
}

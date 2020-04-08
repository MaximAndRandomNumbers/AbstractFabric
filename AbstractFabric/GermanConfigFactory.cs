using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация AbstractConfigFactory
    /// для генерации настроек для Германии
    /// </summary>
    class GermanConfigFactory  : AbstractConfigFactory
    {
        /// <summary>
        /// Возвращает настройки приложения для Германии
        /// </summary>
        /// <returns>объект Config</returns>
        public override Config GetConfig()
        {
            return new GermanConfig();
        }
        /// <summary>
        /// Возвращает дополнительные настройки приложения для Германии
        /// </summary>
        /// <returns>объект ConfigExtra</returns>
        public override ConfigExtra GetConfigExtra()
        {
            return new GermanConfigExtra();
        }
    }
}

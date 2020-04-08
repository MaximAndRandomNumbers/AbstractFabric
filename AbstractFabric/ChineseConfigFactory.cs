using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Конкретная реализация AbstractConfigFactory
    /// для генерации настроек для Китая
    /// </summary>
    class ChineseConfigFactory : AbstractConfigFactory
    {
        /// <summary>
        /// Возвращает настройки приложения для Китая
        /// </summary>
        /// <returns>объект ChineseConfig</returns>
        public override Config GetConfig()
        {
            return new ChineseConfig();
        }
        /// <summary>
        /// Возвращает дополнительные настройки приложения для Китая
        /// </summary>
        /// <returns>объект ConfigExtra</returns>
        public override ConfigExtra GetConfigExtra()
        {
            return new ChineseConfigExtra();
        }
    }
}

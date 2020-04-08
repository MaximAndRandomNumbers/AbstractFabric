using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Класс описывает абстрактную фабрику, которая 
    /// генерирует объекты типа Config и ConfigExtra
    /// </summary>
    abstract class AbstractConfigFactory
    {
        /// <summary>
        /// Возвращает объект типа Config
        /// </summary>
        /// <returns>объект Config</returns>
        public abstract Config GetConfig();
        /// <summary>
        /// Возвращает объект типа ConfigExtra
        /// </summary>
        /// <returns>объект ConfigExtra</returns>
        public abstract ConfigExtra GetConfigExtra();
    }
}

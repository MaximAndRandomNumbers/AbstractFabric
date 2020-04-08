using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    /// <summary>
    /// Абстрактный класс описывающий 
    /// дополнительные настройки приложения
    /// </summary>
    abstract class ConfigExtra
    {  
        /// <summary>
        /// Цвет пользовательского интерфейса
        /// </summary>
        public String InterfaceColor { get; protected set; }
        /// <summary>
        /// Ключевые слова для фильтрации новостей
        /// </summary>
        public String[] NewsFilter { get; protected set; }
        /// <summary>
        /// Список компаний, рекламу которых отображать
        /// </summary>
        public String[] AdsList { get; protected set; }
        /// <summary>
        /// IP адреса ближайших серверов
        /// </summary>
        public String[] ClosestServersIP { get; protected set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class Program
    {
        enum COUNTRIES
        {
            RUSSIA, CHINA, GERMANY
        }
        static void Main(string[] args)
        {
            Config config = GenerateConfig(COUNTRIES.RUSSIA);
            ConfigExtra configExtra = GenerateConfigExtra(COUNTRIES.RUSSIA);
                     
        }

        /// <summary>
        /// Возвращает настройки для конкретной страны
        /// </summary>
        /// <param name="country">страна, для которой необходимо сконфигурировать настройки</param>
        /// <returns>объект Config</returns>
        static Config GenerateConfig(COUNTRIES country)
        {
            AbstractConfigFactory confFactory;
            switch(country)
            {
                case COUNTRIES.RUSSIA:
                    confFactory = new RussianConfigFactory();
                    break;
                case COUNTRIES.CHINA:
                    confFactory = new GermanConfigFactory();
                    break;
                case COUNTRIES.GERMANY:
                    confFactory = new ChineseConfigFactory();
                    break;
                default:
                    confFactory = new RussianConfigFactory();
                    break;
            }
            return confFactory.GetConfig();
        }
        /// <summary>
        /// Возвращает дополнительные настройки для конкретной страны
        /// </summary>
        /// <param name="country">страна, для которой необходимо сконфигурировать дополнительные настройки</param>
        /// <returns>объект ConfigExtra</returns>
        static ConfigExtra GenerateConfigExtra(COUNTRIES country)
        {
            AbstractConfigFactory confFactory;
            switch (country)
            {
                case COUNTRIES.RUSSIA:
                    confFactory = new RussianConfigFactory();
                    break;
                case COUNTRIES.CHINA:
                    confFactory = new GermanConfigFactory();
                    break;
                case COUNTRIES.GERMANY:
                    confFactory = new ChineseConfigFactory();
                    break;
                default:
                    confFactory = new RussianConfigFactory();
                    break;
            }
            return confFactory.GetConfigExtra();
        }
    }
}

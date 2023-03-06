using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm
{
    public interface ILiveOrganizm
    {

        /// <summary>
        /// Химический состав
        /// </summary>
        /// <remarks>Единство химического состава.</remarks>
        System.Enum СhemicalСomposition { get; set; }
        /// <summary>
        /// Структурная организация
        /// </summary>
        /// <remarks>Единство структурной организации.</remarks>
        System.Enum StructuralOrganization { get; set; }
        /// <summary>
        /// Тип метоболизма и обмена энергией
        /// </summary>
        /// <remarks>
        /// Открытость.
        /// Обмен веществ и энергии.
        /// </remarks>
        /// <value>
        /// Open
        /// Close
        /// </value>
        System.Enum TypeMetabolismAndEnergy { get; set; }
        /// <summary>
        /// Метод репродукции
        /// </summary>
        /// <remarks>Самовоспроизведение.</remarks>
        System.Enum MethodSelfReproduction { get; set; }
        /// <summary>
        /// Гомеостаз
        /// </summary>
        /// <remarks>Саморегуляция.</remarks>
        System.Enum Homeostasis { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        System.Enum Growth { get; set; }
        /// <summary>
        /// Развитие
        /// </summary>
        System.Enum Development { get; set; }
        /// <summary>
        /// Раздражимость
        /// </summary>
        System.Enum Irritability { get; set; }
        /// <summary>
        /// Наследственность
        /// </summary>
        /// <remarks>Наследственность и изменчивость.</remarks>
        System.Enum Heredity { get; set; }
        /// <summary>
        /// Изменчивость
        /// </summary>
        /// <remarks>Наследственность и изменчивость.</remarks>
        System.Enum Variability { get; set; }
        /// <summary>
        /// * синтетическая или пластическая – строительство тела, белки-ферменты
        /// </summary>
        System.Enum SyntheticOrPlasticFunc();
        /// <summary>
        /// * энергетическая – все внутриклеточные процесы идут с затратой энергии, основным поставщиком энергии в клетке являются митохондрии
        /// </summary>
        System.Enum EnergyFunc();
        /// <summary>
        /// * метаболизм или обмен вещ-в – физиологические процессы. Питание через эндоцитоз (пиноцитоз и фагоцитоз)
        /// </summary>
        System.Enum MetabolismFunc();
        /// <summary>
        /// * барьерно-рецепторная. На плазмолемме локализованы спец структуры, участвующие в узнавании хим и физ факторов, обладает большим набором рецепторов – чувствительные участки
        /// </summary>
        /// <remarks></remarks>
        System.Enum BarrierReceptor();
        /// <summary>
        /// * транспортная – пассивный перенос ряда веществ, активный перенос с затратой энергии.
        /// </summary>
        System.Enum TransportFunc();
        /// <summary>
        /// * регуляторная функция - согласует работу синтетическоо аппарата и энергетических органелл, контролирует обмен вещ-в
        /// </summary>
        System.Enum RegulatoryFunc();
    }
}
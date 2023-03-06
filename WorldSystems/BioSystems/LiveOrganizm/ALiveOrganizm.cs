using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm
{
    public abstract class ALiveOrganizm : ILiveOrganizm
    {

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
        enum TypeMetabolismAndEnergy { 
            Open,
            Close
        }

        /// <summary>
        /// Метод репродукции
        /// </summary>
        /// <remarks>
        /// Самовоспроизведение.
        /// - митоз, или непрямое деление (характерное для большинства клеток);
        /// - амитоз, или прямое деление клеток;
        /// - мейоз, или редукционное деление (при образовании половых клеток);
        /// - эндорепродукция (образование полиплоидных и многоядерных клеток).
        /// </remarks>
        enum MethodSelfReproduction {
            mitosis,
            amitosis,
            meiosis,
            endoreproduction
        }
        /// <summary>
        /// Гомеостаз
        /// </summary>
        /// <remarks>Саморегуляция.</remarks>
        enum Homeostasis {
            Regulatory,
            Conformational
        }
        /// <summary>
        /// Рост
        /// </summary>
        enum Growth {  }
        /// <summary>
        /// Развитие
        /// </summary>
        enum Development {  }
        /// <summary>
        /// Раздражимость
        /// </summary>
        enum Irritability {  }
        /// <summary>
        /// Наследственность
        /// </summary>
        /// <remarks>Наследственность и изменчивость.</remarks>
        enum Heredity {  }
        /// <summary>
        /// Изменчивость
        /// </summary>
        /// <remarks>Наследственность и изменчивость.</remarks>
        enum Variability {  }
        /// <summary>
        /// Уровень разрушения (старение + столкновения + и т.д.)
        /// </summary>
        float entropy;
        public float Entropy { get => entropy; set => entropy = value; }

        /// <summary>
        /// * синтетическая или пластическая – строительство тела, белки-ферменты
        /// </summary>
        public abstract void SyntheticOrPlasticFunc();
        /// <summary>
        /// * энергетическая – все внутриклеточные процесы идут с затратой энергии, основным поставщиком энергии в клетке являются митохондрии
        /// </summary>
        public abstract void EnergyFunc();
        /// <summary>
        /// * метаболизм или обмен вещ-в – физиологические процессы. Питание через эндоцитоз (пиноцитоз и фагоцитоз)
        /// </summary>
        public abstract void MetabolismFunc();
        /// <summary>
        /// * барьерно-рецепторная. На плазмолемме локализованы спец структуры, участвующие в узнавании хим и физ факторов, обладает большим набором рецепторов – чувствительные участки
        /// </summary>
        /// <remarks></remarks>
        public abstract void BarrierReceptor();
        /// <summary>
        /// * транспортная – пассивный перенос ряда веществ, активный перенос с затратой энергии.
        /// </summary>
        public abstract void TransportFunc();
        /// <summary>
        /// * регуляторная функция - согласует работу синтетическоо аппарата и энергетических органелл, контролирует обмен вещ-в
        /// </summary>
        public abstract void RegulatoryFunc();

     
    }
}
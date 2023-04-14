using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm
{
    public interface ILiveOrganizm
    {


        // <summary>
        // Химический состав
        // </summary>
        // <remarks>Единство химического состава.</remarks>
        //  enum СhemicalСomposition { };
        // <summary>
        // Структурная организация
        // </summary>
        // <remarks>Единство структурной организации.</remarks>
        // enum StructuralOrganization { };
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
        enum TypeMetabolismAndEnergy {  }
        /// <summary>
        /// Метод репродукции
        /// </summary>
        /// <remarks>Самовоспроизведение.</remarks>
        enum MethodSelfReproduction {  }
        /// <summary>
        /// Гомеостаз
        /// </summary>
        /// <remarks>Саморегуляция.</remarks>
        enum Homeostasis {  }
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
        float Entropy { get; set; }

        /// <summary>
        /// * синтетическая или пластическая – строительство тела, белки-ферменты
        /// </summary>
        void SyntheticOrPlasticFunc();
        /// <summary>
        /// * энергетическая – все внутриклеточные процесы идут с затратой энергии, основным поставщиком энергии в клетке являются митохондрии
        /// </summary>
         void EnergyFunc();
        /// <summary>
        /// * метаболизм или обмен вещ-в – физиологические процессы. Питание через эндоцитоз (пиноцитоз и фагоцитоз)
        /// </summary>
         void MetabolismFunc();
        /// <summary>
        /// * барьерно-рецепторная. На плазмолемме локализованы спец структуры, участвующие в узнавании хим и физ факторов, обладает большим набором рецепторов – чувствительные участки
        /// </summary>
        /// <remarks></remarks>
         void BarrierReceptor();
        /// <summary>
        /// * транспортная – пассивный перенос ряда веществ, активный перенос с затратой энергии.
        /// </summary>
         void TransportFunc();
        /// <summary>
        /// * регуляторная функция - согласует работу синтетическоо аппарата и энергетических органелл, контролирует обмен вещ-в
        /// </summary>
         void RegulatoryFunc();




        //TODO: Убрать вторую классификацию.  

        /// <summary>
        /// Нужно кушать и т.д.
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
       // string metabolism(string food);

        /// <summary>
        /// Бог сказал плодиться
        /// </summary>
       // void self_reproduction();

        /// <summary>
        /// Развивается пацаны
        /// </summary>
      //  void improvement();

        /// <summary>
        /// Необходимость в обработке информации (хранении передачи)
        /// </summary>
      //  void InformationProcessing();

        /// <summary>
        /// Стремление\способы выживания
        /// </summary>
      //  void DesireToSurvive();
    }
}
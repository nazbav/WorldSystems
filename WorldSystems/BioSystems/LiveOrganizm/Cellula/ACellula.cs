using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm.Cellula
{
    public abstract class ACellula : ALiveOrganizm, ILiveBasicNeeds
    {
        public float WarterLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float OxygenLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float hungerLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float HungerLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float ReproductionLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float ImprovementLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        /// <summary>
        /// Память
        /// </summary>
        internal struct Memory
        {
            /// <summary>
            /// Забывать
            /// </summary>
            /// <returns></returns>
            public static string Forget()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Вспоминать
            /// </summary>
            /// <param name="context"></param>
            /// <returns></returns>
            public static string Remember(string context)
            {
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Способы саморазвития
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void improvement()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Реализация метаболизма
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string metabolism(string food)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Реализация самовоспроизведения
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void self_reproduction()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Эгоизм
        /// </summary>
        public void Egoizm() { }

        /// <summary>
        /// Черезвычайная самоуверенность
        /// </summary>
        public void ExtremeSelfConfidence() { }

        /// <summary>
        /// Обработка информации 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void InformationProcessing()
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// Стремление\способы выживания
        /// </summary>
        public void DesireToSurvive() => InformationProcessing();

        /// <summary>
        /// Доминирование (характер воздействия на элементы окружающей среды)
        /// </summary>
        abstract public void Dominance();

        /// <summary>
        /// [само]Подчинение (характер воздействия на элементы окружающей среды)
        /// </summary>
        abstract public void Dominance();


        /// <summary>
        /// Потребление
        /// </summary>
        abstract public void Consumption();

        /// <summary>
        /// Чтобы выжить необходимо потреблять (открытая система -- питательные элементы в основном, поступают из внешней среды)
        /// </summary>
        new void DesireToSurvive() => Consumption();

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm.Homo.HomoSapiansSapians.Character
{
    public interface IDefects
    {
        /// <summary>
        /// Эгоцентризм
        /// </summary>
        /// <remarks>
        /// Влияние:
        /// - Страх людей и авторитета ++ &gt;
        /// - Аддиктианое поведение ++[!]
        /// </remarks>
        float EgocentrismShift { get; set; }
        /// <summary>
        /// Оценочность
        /// </summary>
        /// <remarks>
        /// Влияние:
        /// - Панически боимся быть покинутыми ++
        /// +
        /// - Зависимы от эмоцонального возбужения ++ &gt;
        /// - Ищем одобрения+
        /// </remarks>
        float EvaluationShift { get; set; }
        /// <summary>
        /// Изоляция
        /// </summary>
        /// <remarks>
        /// Влияния:
        /// - Путаем любовь и жадность ++
        /// + 
        /// - Реагируем а не действуем (ситуация без ответа) +
        /// </remarks>
        float IsolationShift { get; set; }
        /// <summary>
        /// Нечестность
        /// </summary>
        /// <remarks>
        /// Влияние:
        /// - Путаем любовь и жадность ++ &gt;
        /// + 
        /// - Реагируем а не действуем + 
        /// +
        /// - Жестоко судим себя ++
        /// </remarks>
        float DishonestyShift { get; set; }
        /// <summary>
        /// Перфекционизм
        /// </summary>
        /// <remarks>
        /// Влияния:
        /// - Путаем любовь и жадность ++ &gt;
        /// - Жестоко судим себя +++[!]
        /// </remarks>
        float PerfectionismShift { get; set; }
        /// <summary>
        /// Вожделение
        /// </summary>
        /// <remarks>
        /// Влияние:
        /// - Зависимость от эмоционального возбуждения +++ &gt;
        /// + 
        /// - Ищем одобрения +++ &gt;
        /// +
        /// - Жертвенность +++ [!]
        /// </remarks>
        float LustShift { get; set; }
        /// <summary>
        /// Жадность
        /// </summary>
        /// <remarks>
        /// Влияние:
        /// - Путаем любовь и жадность +++ &gt;
        /// + 
        /// - Реагируем, а не действуем ++ [!]
        /// </remarks>
        float GreedShift { get; set; }
        /// <summary>
        /// Недоверчивость
        /// </summary>
        /// <remarks>
        /// Влияния:
        /// - Путаем любовь и жадность +++ &gt;
        /// +
        /// - Реагируем а не действуем +++ &gt;
        /// +
        /// - Со-зависимость (со-алкоголизм) [!]
        /// </remarks>
        float IncredulityShift { get; set; }
        /// <summary>
        /// Чувство превосходства.
        /// </summary>
        /// <remarks>
        /// Влияния:
        /// - Страх людей и авторитета +++ &gt; 
        /// +
        /// - Подавление чувств ++++ &gt; Чувство препосходства [!]
        /// </remarks>
        float SuperiorityShift { get; set; }
        /// <summary>
        /// Мелочность
        /// </summary>
        /// <remarks>
        /// Влияния:
        /// - Страх людей и авторитета +++ &gt; 
        /// +
        /// - Подавление чувств +++ &gt; Чувство препосходства
        /// </remarks>
        float PettenessShift { get; set; }
        /// <summary>
        /// Зависть
        /// </summary>
        /// <remarks>
        /// Влияния:
        /// - Путаем любовь и жадность +++ &gt; 
        /// +
        /// - Реагируем а не действуем ++++ [!]
        /// </remarks>
        float EnvyShift { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystems.BioSystems.LiveOrganizm.Cellula.Endotheria
{
    public abstract class AEndotheria : ACellula
    {
        /// <summary>
        /// Доминирование
        /// </summary>
        abstract public void Dominance();

        /// <summary>
        /// Потребление
        /// </summary>
        abstract public void Consumption();

        /// <summary>
        /// Чтобы выжить нукжно потреблять
        /// </summary>
        new void DesireToSurvive() => Consumption();
    }
}

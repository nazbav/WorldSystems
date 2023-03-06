using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm
{
    public interface ILiveBasicNeeds
    {
        
        /// <summary>
        /// Потребность в воде, метаболизм
        /// </summary>
        float WarterLevel { get; set; }
        
        /// <summary>
        /// Потребность в кислороде, метаболизм
        /// </summary>
        float OxygenLevel { get; set; }
        
        /// <summary>
        /// Потребность в еде, метаболизм
        /// </summary>
        float HungerLevel { get; set; }

        /// <summary>
        /// Потребность в репродукции
        /// </summary>
        float ReproductionLevel { get; set; }
    
        /// <summary>
        /// Потребность в развитии
        /// </summary>
        float ImprovementLevel { get; set; }
 
    }
}
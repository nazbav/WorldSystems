using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WorldSystems.BioSystems.LiveOrganizm
{
    public interface INeeds
    {
        float WarterLevel { get; set; }
        float OxygenLevel { get; set; }
        float hungerLevel { get; set; }

    }
}
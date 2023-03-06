using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorldSystems.BioSystems.LiveOrganizm.Homo.HomoSapiansSapians.Character;

namespace WorldSystems.BioSystems.LiveOrganizm
{
    public abstract class Cellula : ALiveOrganizm, ILiveBasicNeeds
    {
        public float WarterLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float OxygenLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float hungerLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystems.LaguageSystems.Cyrlinc.Russian
{
    interface IRussian
    {
        /// <summary>
        /// Способность говорить
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        string Speak(string context);
        string Understand(string Speek);
    }

}

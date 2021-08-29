using System.Collections.Generic;
using System.ComponentModel;
using TuringModules.Model;

namespace TuringModules.Controller
{
    class Execute
    {

        public bool Start(string input, string code)
        {
            Extractor extractor = new Extractor();
            List<Code> TuringCode = extractor.Extract(code);

            if (TuringCode == null)
                return false;

            SimulationData simData = new SimulationData();
            simData.IO = new List<List<string>>();
            simData.TuringCode = TuringCode;

            // PERFORM SIMULATION HERE

            return true;
        }
    }
}

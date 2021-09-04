using System.Collections.Generic;
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
            simData.IO = extractor.ExtractInput(input);
            simData.TuringCode = TuringCode;
            simData.Pointer = 0;

            // PERFORM SIMULATION HERE

            Simulate simulator = new Simulate();
            simulator.Start(simData);

            return true;
        }
    }
}

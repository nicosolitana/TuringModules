using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TuringModules.Model;

namespace TuringModules.Controller
{
    class Execute
    {
        private void UpdateOutput(SimulationData simData)
        {
            TuringModGUI.Result.Invoke(new MethodInvoker(delegate
            {
                string output = String.Join("", simData.IO);
                TuringModGUI.Result.Text = ("X" + output);
            }));
        }

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

            UpdateOutput(simData);
            return true;
        }
    }
}

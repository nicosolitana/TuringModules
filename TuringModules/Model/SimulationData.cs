using System.Collections.Generic;

namespace TuringModules.Model
{
    class SimulationData
    {
        private List<List<string>> _io;
        public List<List<string>> IO
        {
            get
            {
                return _io;
            }
            set
            {
                _io = value;
            }
        }

        private List<Code> _turingCode;
        public List<Code> TuringCode
        {
            get
            {
                return _turingCode;
            }
            set
            {
                _turingCode = value;
            }
        }
    }
}

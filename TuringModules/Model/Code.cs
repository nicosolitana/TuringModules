namespace TuringModules.Model
{
    class Code
    {
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        private string _module;
        public string Module
        {
            get
            {
                return _module;
            }
            set
            {
                _module = value;
            }
        }

        private string _parameterOne;
        public string ParameterOne
        {
            get
            {
                return _parameterOne;
            }
            set
            {
                _parameterOne = value;
            }
        }

        private string _parameterTwo;
        public string ParameterTwo
        {
            get
            {
                return _parameterTwo;
            }
            set
            {
                _parameterTwo = value;
            }
        }
    }
}

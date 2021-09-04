namespace TuringModules.Model
{
    class PointerValuePair
    {
        private char _pointer;
        public char State
        {
            get
            {
                return _pointer;
            }
            set
            {
                _pointer = value;
            }
        }


        private int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}

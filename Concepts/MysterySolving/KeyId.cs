namespace Concepts.MysterySolving
{
    public partial record KeyId
    {
        private readonly string _value;
        internal KeyId(string value)
        {
            _value = value;
        }
    }

}
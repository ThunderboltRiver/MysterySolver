namespace Concepts.MysterySolving
{
    public partial record MysteryId
    {
        private readonly string _value;
        public MysteryId(string value)
        {
            _value = value;
        }
    }
}
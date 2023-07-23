using System.Text.RegularExpressions;

namespace Concepts.MysterySolving
{
    public partial record KeyId
    {
        private readonly string _value;
        internal KeyId(string value)
        {
            if (string.IsNullOrEmpty(value) || !KeyIdRegex().IsMatch(value)) throw new ArgumentException("KeyIDが不正です");
            this._value = value;
        }
        [GeneratedRegex("^mst-key-[0-9]+$")]
        private static partial Regex KeyIdRegex();
    }

}
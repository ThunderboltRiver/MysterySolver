namespace Concepts.MysterySolving
{
    /// <summary>
    /// 謎を特定するための識別情報を表す値オブジェクト
    /// </summary>
    public readonly struct MysteryId : IEquatable<MysteryId>
    {
        private readonly string _value;

        internal MysteryId(string value)
        {
            _value = value;
        }

        public bool Equals(MysteryId other)
        {
            return _value == other._value;
        }

        public override bool Equals(object? obj)
        {
            return obj is MysteryId other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public static bool operator ==(MysteryId left, MysteryId right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MysteryId left, MysteryId right)
        {
            return !left.Equals(right);
        }
    }
}

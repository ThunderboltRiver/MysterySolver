namespace Concepts.MysterySolving
{
    /// <summary>
    /// 鍵を特定するための識別情報を表す値オブジェクト
    /// </summary>
    /// <value></value>
    public partial record KeyId
    {
        private readonly string _value;
        internal KeyId(string value)
        {
            _value = value;
        }
    }

}
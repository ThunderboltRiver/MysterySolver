namespace Concepts.MysterySolving;


/// <summary>
/// 鍵オブジェクト
/// </summary>
/// <value></value>
public record Key
{
    private readonly KeyId _keyId;
    internal Key(string keyId)
    {
        _keyId = new KeyId(keyId);
    }
    internal Key(KeyId keyId)
    {
        _keyId = keyId;
    }
}

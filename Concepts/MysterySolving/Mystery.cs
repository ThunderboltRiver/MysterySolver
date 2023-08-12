namespace Concepts.MysterySolving;

/// <summary>
/// 謎オブジェクト
/// </summary>
public class Mystery
{
    /// <summary>
    /// 謎のID
    /// </summary>
    private readonly MysteryId _mysteryId;

    /// <summary>
    /// 認証に必要な鍵のID
    /// </summary>
    private readonly Key _atuhenticationKey;

    /// <summary>
    /// 解くべき前の謎のID
    /// </summary>
    private readonly MysteryId? _beforeMysteryId;

    /// <summary>
    /// 謎を作成する
    /// </summary>
    /// <param name="id">謎のID</param>
    /// <param name="keyId">認証に必要な鍵のID</param>
    /// <param name="beforeMysteryId">解くべき前の謎のID</param>
    internal Mystery(string id, string keyId, string beforeMysteryId)
    {
        _mysteryId = new MysteryId(id);
        _atuhenticationKey = new Key(keyId);
        _beforeMysteryId = new MysteryId(beforeMysteryId);
    }

    /// <summary>
    /// 最初の謎を作成する
    /// </summary>
    /// <param name="id">謎のID</param>
    /// <param name="keyId">認証に必要な鍵のID</param>
    internal Mystery(string id, string keyId)
    {
        _mysteryId = new MysteryId(id);
        _atuhenticationKey = new Key(keyId);
        _beforeMysteryId = null;
    }


    /// <summary>
    /// 鍵の認証を行う。失敗したときはnullを返す
    /// </summary>
    /// <param name="key">認証対象となる鍵</param>
    /// <returns>解かれた謎</returns>
    internal SolvedMystery? Authenticate(Key key, SolvedRoute? solvedRoute)
    {
        if (key != _atuhenticationKey) return null; //共通鍵認証
        if (_beforeMysteryId == null) return new SolvedMystery(_mysteryId); //最初の謎は共通鍵認証のみで解ける
        if (solvedRoute != null && solvedRoute.IsAuthorizedBy(_beforeMysteryId.Value)) return new SolvedMystery(_mysteryId); //前の謎を解いているか
        return null;
    }
}

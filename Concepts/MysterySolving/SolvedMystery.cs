namespace Concepts.MysterySolving;

/// <summary>
/// 解かれた謎を表すオブジェクト
/// </summary>
public record SolvedMystery
{
    private readonly MysteryId _mysteryId; //解かれた謎のID
    internal SolvedMystery(MysteryId mysteryId)
    {
        _mysteryId = mysteryId;
    }

    /// <summary>
    /// 特定の謎によって解かれたかどうかを判定する
    /// </summary>
    /// <param name="mysteryId">謎のid</param>
    /// <returns>bool</returns>
    internal bool IsAuthenticatedBy(MysteryId mysteryId)
    {
        return _mysteryId == mysteryId;
    }

}
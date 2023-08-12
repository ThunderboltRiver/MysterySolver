namespace Concepts.MysterySolving;

/// <summary>
/// 解かれた謎を表すオブジェクト
/// </summary>
public record SolvedMystery
{
    private readonly MysteryId _mysteryId;
    internal SolvedMystery(MysteryId mysteryId)
    {
        _mysteryId = mysteryId;
    }

    internal bool IsAuthenticatedBy(MysteryId mysteryId)
    {
        return _mysteryId == mysteryId;
    }

}
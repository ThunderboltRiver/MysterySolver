namespace Concepts.MysterySolving;
public abstract class SolvedRoute
{
    /// <summary>
    /// 謎を解いたことを記録する.playerだけが呼び出すことができる
    /// </summary>
    /// <param name="solvedMystery"></param>
    /// <returns>記録に成功したらtrue,それ以外はfalse</returns>
    protected internal abstract bool Save(SolvedMystery solvedMystery);

    internal SolvedMystery? Last()
    {
        return LastId() is { } id ? new SolvedMystery(id) : null;
    }
    protected abstract MysteryId? LastId();

}
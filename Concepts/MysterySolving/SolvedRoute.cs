namespace Concepts.MysterySolving;
public abstract class SolvedRoute
{
    /// <summary>
    /// 謎を解いたことを記録する.playerだけが呼び出すことができる
    /// </summary>
    /// <param name="solvedMystery"></param>
    /// <returns>記録に成功したらtrue,それ以外はfalse</returns>
    protected internal abstract bool Save(SolvedMystery solvedMystery);

    /// <summary>
    /// 最後に解いた謎を取得する.解いたことがない場合はnullを返す.playerだけが呼び出すことができる
    /// </summary>
    /// <returns></returns>
    protected internal abstract SolvedMystery? Last();

}
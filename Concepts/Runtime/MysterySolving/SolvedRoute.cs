using System.Collections.Generic;
using System.Linq;

namespace Concepts.MysterySolving
{
    /// <summary>
    /// 解かれた謎による経路を表すオブジェクト
    /// </summary>
    public class SolvedRoute
    {
        private readonly Stack<SolvedMystery> _solvedMysteries = new();//解かれた謎のスタック

        /// <summary>
        /// 解かれた謎を経路に追加する
        /// </summary>
        /// <param name="solvedMystery"></param>
        internal void AddNew(SolvedMystery solvedMystery)
        {
            if (!_solvedMysteries.Contains(solvedMystery)) _solvedMysteries.Push(solvedMystery);
        }

        /// <summary>
        /// 特定の謎によって承認されている経路かどうかを判定する
        /// </summary>
        /// <param name="mysteryId"></param>
        /// <returns></returns>
        internal bool IsAuthorizedBy(MysteryId mysteryId)
        {
            if (_solvedMysteries.Count == 0) return false;
            return _solvedMysteries.Count(solvedMystery => solvedMystery.IsAuthenticatedBy(mysteryId)) > 0;
        }
    }
}
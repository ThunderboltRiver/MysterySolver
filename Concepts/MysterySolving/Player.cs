namespace Concepts.MysterySolving
{
    /// <summary>
    /// 謎解きするプレイヤーを表すオブジェクト
    /// </summary>
    public class Player
    {
        private readonly IKeyInventry _keyInventry; //鍵のインベントリ
        private readonly SolvedRoute _solvedRoute; //謎を解いてきた経路
        public Player(IKeyInventry keyInventry, SolvedRoute solvedRoute)
        {
            _keyInventry = keyInventry;
            _solvedRoute = solvedRoute;
        }

        /// <summary>
        /// 謎を解く
        /// </summary>
        /// <param name="mystery">解く対象の謎</param>
        /// <param name="keyId">謎を解くのに必要な鍵のid</param>
        /// <returns></returns>
        public bool Solve(Mystery mystery, KeyId keyId)
        {
            var key = _keyInventry.Find(keyId) ?? throw new InvalidOperationException("ユーザーは鍵を所有していない");
            var solvedMystery = mystery.Authenticate(key, _solvedRoute);
            if (solvedMystery == null) return false;
            _solvedRoute.AddNew(solvedMystery);
            return true;
        }
    }
}
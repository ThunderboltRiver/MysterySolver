namespace Concepts.MysterySolving
{
    public class Player
    {
        private readonly IKeyInventry _keyInventry;
        private readonly SolvedRoute _solvedRoute;
        public Player(IKeyInventry keyInventry, SolvedRoute solvedRoute)
        {
            _keyInventry = keyInventry;
            _solvedRoute = solvedRoute;
        }
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
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
            var key = _keyInventry.Find(keyId);
            if (key == null) return false;
            var solvedMystery = mystery.Authenticate(key, _solvedRoute.Last());
            if (solvedMystery == null) return false;
            return _solvedRoute.Save(solvedMystery);

        }
    }
}
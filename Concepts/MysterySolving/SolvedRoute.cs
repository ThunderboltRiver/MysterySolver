namespace Concepts.MysterySolving
{
    public class SolvedRoute
    {
        private readonly Stack<SolvedMystery> _solvedMysteries = new();

        internal void AddNew(SolvedMystery solvedMystery)
        {
            if (!_solvedMysteries.Contains(solvedMystery)) _solvedMysteries.Push(solvedMystery);
        }

        internal bool IsAuthorizedBy(MysteryId mysteryId)
        {
            if (_solvedMysteries.Count == 0) return false;
            return _solvedMysteries.Count(solvedMystery => solvedMystery.IsAuthenticatedBy(mysteryId)) > 0;
        }
    }
}
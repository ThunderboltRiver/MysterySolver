namespace Concepts.Tests.MysterySolvingTest.TestObjects.Mock
{
    public sealed class FakeSolvedRoute : SolvedRoute
    {

        protected internal override bool Save(SolvedMystery solvedMystery)
        {
            return true;
        }

        protected override MysteryId? LastId()
        {
            return new MysteryId("mst-mystery-001");
        }
    }
}
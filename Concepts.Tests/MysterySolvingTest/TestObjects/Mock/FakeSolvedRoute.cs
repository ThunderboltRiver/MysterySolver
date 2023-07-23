namespace Concepts.Tests.MysterySolvingTest.TestObjects.Mock
{
    public sealed class FakeSolvedRoute : SolvedRoute
    {

        protected internal override bool Save(SolvedMystery solvedMystery)
        {
            return true;
        }

        protected internal override SolvedMystery? Last()
        {
            return new SolvedMystery(new MysteryId("mst-mystery-001"));
        }
    }
}
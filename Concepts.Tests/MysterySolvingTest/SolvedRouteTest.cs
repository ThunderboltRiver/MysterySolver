using Concepts.MysterySolving;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Concepts.Tests.MysterySolvingTest
{
    public class SolvedRouteTest
    {
        private readonly MysteryId _mysteryId = new("mst-mystery-001");
        [Fact]
        public void SolvedRoute_追加された解かれた謎によって認証を保証できる()
        {
            var solvedMystery = new SolvedMystery(_mysteryId);
            var solvedRoute = new SolvedRoute();
            solvedRoute.AddNew(solvedMystery);
            Assert.True(solvedRoute.IsAuthorizedBy(_mysteryId));
        }

        [Fact]
        public void SolvedRoute_追加されていない解かれた謎では認証を保証できない()
        {
            var solvedMystery = new SolvedMystery(_mysteryId);
            var solvedRoute = new SolvedRoute();
            Assert.False(solvedRoute.IsAuthorizedBy(new MysteryId("mst-mystery-002")));
        }
    }
}
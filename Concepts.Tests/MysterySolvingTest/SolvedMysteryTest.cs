using Concepts.MysterySolving;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Concepts.Tests.MysterySolvingTest
{
    public class SolvedMysteryTest
    {
        private readonly MysteryId mysteryId1 = new("mst-mystery-001");
        private readonly MysteryId mysteryId2 = new("mst-mystery-002");

        [Fact]
        public void SolvedMystery_同一性_MysteryIdが同じなら同じ()
        {
            var mysteryId = new MysteryId("mst-mystery-001");
            var mystery = new SolvedMystery(mysteryId);
            var mystery1 = new SolvedMystery(mysteryId1);
            Assert.Equal(mystery, mystery1);
        }
        [Fact]
        public void SolvedMystery_同一性_MysteryIdが異なるなら異なる()
        {
            var mystery1 = new SolvedMystery(mysteryId1);
            var mystery2 = new SolvedMystery(mysteryId2);
            Assert.NotEqual(mystery1, mystery2);
        }

        [Fact]
        public void SolvedMystery_等価性_MysteryIdが同じなら等価演算子はtrue()
        {
            var mysteryId = new MysteryId("mst-mystery-001");
            var mystery = new SolvedMystery(mysteryId);
            var mystery1 = new SolvedMystery(mysteryId1);
            Assert.True(mystery1 == mystery);
        }

        [Fact]
        public void SolvedMystery_等価性_MysteryIdが異なるなら等価演算子はfalse()
        {
            var mystery1 = new SolvedMystery(mysteryId1);
            var mystery2 = new SolvedMystery(mysteryId2);
            Assert.False(mystery1 == mystery2);
        }

        [Fact]
        public void SolvedMystery_AuthorizedBy_作成した謎と同じならtrue()
        {
            var mysteryId = new MysteryId("mst-mystery-001");
            var mystery = new SolvedMystery(mysteryId);
            Assert.True(mystery.IsAuthenticatedBy(mysteryId));
        }

        [Fact]
        public void SolvedMystery_AuthorizedBy_作成した謎と異なるならfalse()
        {
            var solvedMystery = new SolvedMystery(mysteryId1);
            Assert.False(solvedMystery.IsAuthenticatedBy(mysteryId2));
        }

    }
}
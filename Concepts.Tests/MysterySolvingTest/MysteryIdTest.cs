namespace Concepts.Tests.MysterySolvingTest
{
    public class MysteryIdTest
    {

        [Fact]
        public void MysteryId_同一性_同じ文字列なら同じ()
        {
            var mysteryId = new MysteryId("mst-mystery-001");
            var mysteryId1 = new MysteryId("mst-mystery-001");
            Assert.Equal(mysteryId, mysteryId1);
        }
        [Fact]
        public void MysteryId_同一性_異なる文字列なら異なる()
        {
            var mysteryId1 = new MysteryId("mst-mystery-001");
            var mysteryId2 = new MysteryId("mst-mystery-002");
            Assert.NotEqual(mysteryId1, mysteryId2);
        }

        [Fact]
        public void MysteryId_等価性_同じ文字列なら等価演算子はtrue()
        {
            var mysteryId = new MysteryId("mst-mystery-001");
            var mysteryId1 = new MysteryId("mst-mystery-001");
            Assert.True(mysteryId1 == mysteryId);
        }

        [Fact]
        public void MysteryId_等価性_異なる文字列なら等価演算子はfalse()
        {
            var mysteryId1 = new MysteryId("mst-mystery-001");
            var mysteryId2 = new MysteryId("mst-mystery-002");
            Assert.False(mysteryId1 == mysteryId2);
        }
    }
}
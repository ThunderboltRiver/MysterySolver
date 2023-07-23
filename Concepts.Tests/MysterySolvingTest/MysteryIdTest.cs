namespace Concepts.Tests.MysterySolvingTest
{
    public class MysteryIdTest
    {
        [Theory]
        [InlineData("mst-mystery-001")]
        [InlineData("mst-mystery-002")]
        public void MysteryId_Idが正しいならMysteryIdが生成される(string id)
        {
            var mysteryId = new MysteryId(id);
            Assert.NotNull(mysteryId);
        }

        [Theory]
        [InlineData("mst-mystery-ksaf")]
        [InlineData("mst-mystery-001x")]
        [InlineData("-mst-mystery-001")]
        [InlineData(null)]
        [InlineData("")]
        public void MysteryId_Idが間違っているならArgumentExceptionをスローする(string id)
        {
            Assert.Throws<ArgumentException>(() => new MysteryId(id));
        }


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
    }
}
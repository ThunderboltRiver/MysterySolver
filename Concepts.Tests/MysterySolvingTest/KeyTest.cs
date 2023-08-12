namespace Concepts.Tests.MysterySolvingTest
{
    public class KeyTests
    {
        [Theory]
        [InlineData("mst-key-001")]
        [InlineData("mst-key-002")]
        public void Key_コンストラクタでキーIDとして正しいを指定するとキーが生成される(string keyId)
        {
            var key = new Key(keyId);
            Assert.NotNull(key);
        }

        [Fact]
        public void Key_同一性_キーIDが同じなら同じキー()
        {
            var key1 = new Key("mst-key-001");
            var key2 = new Key("mst-key-001");
            Assert.Equal(key1, key2);
        }
        [Fact]
        public void Key_同一性_キーIDが異なるなら異なるキー()
        {
            var key1 = new Key("mst-key-001");
            var key2 = new Key("mst-key-002");
            Assert.NotEqual(key1, key2);
        }

        [Fact]
        public void Key_同一性_キーIDが同じならハッシュ値は同じ()
        {
            var key1 = new Key("mst-key-001");
            var key2 = new Key("mst-key-001");
            Assert.Equal(key1.GetHashCode(), key2.GetHashCode());
        }
        [Fact]
        public void Key_同一性_キーIDが異なるならハッシュ値は異なる()
        {
            var key1 = new Key("mst-key-001");
            var key2 = new Key("mst-key-002");
            Assert.NotEqual(key1.GetHashCode(), key2.GetHashCode());
        }

        [Fact]
        public void Key_同一性_キーIDが同じなら等価演算子はtrue()
        {
            var key1 = new Key("mst-key-001");
            var key2 = new Key("mst-key-001");
            Assert.True(key1 == key2);
        }
        [Fact]
        public void Key_同一性_キーIDが異なるなら等価演算子はfalse()
        {
            var key1 = new Key("mst-key-001");
            var key2 = new Key("mst-key-002");
            Assert.False(key1 == key2);
        }

        [Fact]
        public void Key_KeyId_オブジェクトによって再構築できる()
        {
            var keyId = new KeyId("mst-key-001");
            var key = new Key(keyId);
            var key2 = new Key("mst-key-001");
            Assert.Equal(key, key2);
        }
    }
}
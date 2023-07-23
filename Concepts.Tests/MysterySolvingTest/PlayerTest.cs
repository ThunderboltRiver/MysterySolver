using Concepts.Tests.MysterySolvingTest.TestObjects;
namespace Concepts.Tests.MysterySolvingTest
{
    public class PlayerTest
    {
        [Fact]
        public void Player_Solve_謎とインベントリにある鍵が対応しているならture()
        {
            var mystery = TestObjectContainer.mysteries[0];
            var player = new Player(TestObjectContainer.keyInventries[0], TestObjectContainer.solvedRoutes[0]);
            Assert.True(player.Solve(mystery, TestObjectContainer.keyIds[0]));
        }

        [Fact]
        public void Player_Solve_鍵と謎が対応していないならfalse()
        {
            var mystery = TestObjectContainer.mysteries[0];
            var player = new Player(TestObjectContainer.keyInventries[0], TestObjectContainer.solvedRoutes[0]);
            Assert.False(player.Solve(mystery, TestObjectContainer.keyIds[1]));
        }
    }
}
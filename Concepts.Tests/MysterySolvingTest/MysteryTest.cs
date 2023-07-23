using Concepts.Tests.MysterySolvingTest.TestObjects;

namespace Concepts.Tests.MysterySolvingTest;

public class MysteryTest
{
    [Fact]
    public void Mystery_Authenticate_認証に成功するとnullでないSolvedMysteryが返る()
    {
        var mystery = new Mystery("mst-mystery-001", "mst-key-001", "mst-mystery-000");
        var key = new Key("mst-key-001");
        var solvedMystery = mystery.Authenticate(key, new SolvedMystery(new MysteryId("mst-mystery-000")));
        Assert.NotNull(solvedMystery);
    }

    [Fact]
    public void Mystery_Authenticate_認証に失敗するとnullが返る()
    {
        var mystery = new Mystery("mst-mystery-001", "mst-key-001", "mst-mystery-000");
        var key = new Key("mst-key-001");
        var solvedMystery = mystery.Authenticate(key, new SolvedMystery(new MysteryId("mst-mystery-001")));
        Assert.Null(solvedMystery);
    }


}
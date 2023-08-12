using Concepts.Tests.MysterySolvingTest.TestObjects.Mock;

namespace Concepts.Tests.MysterySolvingTest.TestObjects
{
    public class TestObjectContainer
    {
        internal static readonly string[] keyIdTexts = {
            "mst-key-001",
            "mst-key-002",
            "mst-key-003",
            "mst-key-004",
            "mst-key-005",
        };

        internal static readonly string[] mysteryIdTexts = {
            "mst-mystery-001",
            "mst-mystery-002",
            "mst-mystery-003",
            "mst-mystery-004",
            "mst-mystery-005",
        };

        internal static readonly MysteryId[] mysteryIds = {
            new(mysteryIdTexts[0]),
            new(mysteryIdTexts[1]),
            new(mysteryIdTexts[2]),
            new(mysteryIdTexts[3]),
            new(mysteryIdTexts[4]),
        };

        internal static readonly KeyId[] keyIds = {
            new(keyIdTexts[0]),
            new(keyIdTexts[1]),
            new(keyIdTexts[2]),
            new(keyIdTexts[3]),
            new(keyIdTexts[4]),
        };

        internal static readonly Mystery[] mysteries = {
            new(mysteryIdTexts[0], keyIdTexts[0]),
            new(mysteryIdTexts[1], keyIdTexts[1], mysteryIdTexts[0]),
            new(mysteryIdTexts[2], keyIdTexts[2], mysteryIdTexts[1]),
            new(mysteryIdTexts[3], keyIdTexts[3], mysteryIdTexts[2]),
            new(mysteryIdTexts[4], keyIdTexts[4], mysteryIdTexts[3]),
        };

        internal static readonly Key[] keys = {
            new(keyIdTexts[0]),
            new(keyIdTexts[1]),
            new(keyIdTexts[2]),
            new(keyIdTexts[3]),
            new(keyIdTexts[4]),
        };

        internal static readonly IKeyInventry[] keyInventries = {
            new FakeKeyInventry(),
        };
    };
}

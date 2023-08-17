using Concepts.MysterySolving;

namespace Concepts.Tests.MysterySolvingTest.TestObjects.Mock
{
    public class FakeKeyInventry : IKeyInventry
    {
        public Key? Find(KeyId keyId)
        {
            return new Key(keyId);
        }
    }
}
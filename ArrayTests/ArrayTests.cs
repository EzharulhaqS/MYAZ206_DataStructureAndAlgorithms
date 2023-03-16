using ValueAndRefType;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void ArrayConstractorTests()
        {
            var array = new ReferenceType();
            Assert.Equal(4, array.Length);

        }
        [Fact]
        public void arrayParamsConstractorTest()
        {
            var array = new ReferenceType(1,2,3,4,5,6,7);
            Assert.Equal(7, array.Length);
        }

    }
}
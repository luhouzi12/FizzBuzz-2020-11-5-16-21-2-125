using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_Return_1_Given_1()
        {
            //given
            string expected = "1";

            //when
            string actual = FizzBuzz.FizzBuzz.Say(1);

            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_2_Given_2()
        {
            //given
            string expected = "2";

            //when
            string actual = FizzBuzz.FizzBuzz.Say(2);

            //then
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void Should_be_mocked()
        //{
        //    //given
        //    var mockDependencu = new Mock<Dependency>();
        //    mockDependencu.Setup(m => m.Say()).Returns("Hello World");
        //    HelloWorld helloWorld = new HelloWorld(mockDependencu.Object);

        //    //when
        //    string actual = helloWorld.BeenCalled();

        //    //then
        //    Assert.Equal("Hello World", actual);
        //}
    }
}
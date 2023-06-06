using ConsoleApp2;
namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void TestCountries()
        {
            Program project = new Program();
            // arrange
            int expected = 190;
            
            //act
            int result = project.FillDictionary();

            // assert
            Assert.Equal(expected, result);
        }
    }
}
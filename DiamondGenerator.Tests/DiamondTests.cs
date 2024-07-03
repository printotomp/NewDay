using Xunit;
using DiamondGenerator;

namespace DiamondGenerator.Tests
{
    public class DiamondTests
    {
        [Theory]
        [InlineData('A', "A\r\n")]
        [InlineData('B', " A\r\nB B\r\n A")]
        [InlineData('C', "  A\r\n B B\r\nC   C\r\n B B\r\n  A")]

        public void Create_ShouldGenerateCorrectDiamond(char target, string expectedDiamond)
        {
            // Arrange
            var inputValidator = new InputValidator();
            var diamond = new Diamond(inputValidator);

            // Act
            var result = diamond.Create(target);

            // Assert
            Assert.Equal(expectedDiamond, result);
        }

        [Fact]
        public void Create_InvalidInput_ShouldReturnErrorMessage()
        {
            // Arrange
            var inputValidator = new InputValidator();
            var diamond = new Diamond(inputValidator);

            // Act
            var result = diamond.Create('1'); // Invalid input

            // Assert
            Assert.StartsWith("Error:", result);
        }
    }
}
using AlphabetteeSpaghetti.Core;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace AlphabetteeSpaghetti.Tests
{
    public class AlphabetGeneratorTests
    {
        [Fact]
        public void CanGenerateFullAlphabet()
        {
            // Arrange & Act
            var sut = Alphabet.GenerateFullAlphabet();

            // Assert
            var expected = new List<char>
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            sut.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(1, 'A')]
        [InlineData(2, 'B')]
        [InlineData(3, 'C')]
        [InlineData(4, 'D')]
        [InlineData(5, 'E')]
        [InlineData(6, 'F')]
        [InlineData(7, 'G')]
        [InlineData(8, 'H')]
        [InlineData(9, 'I')]
        [InlineData(10, 'J')]
        [InlineData(11, 'K')]
        [InlineData(12, 'L')]
        [InlineData(13, 'M')]
        [InlineData(14, 'N')]
        [InlineData(15, 'O')]
        [InlineData(16, 'P')]
        [InlineData(17, 'Q')]
        [InlineData(18, 'R')]
        [InlineData(19, 'S')]
        [InlineData(20, 'T')]
        [InlineData(21, 'U')]
        [InlineData(22, 'V')]
        [InlineData(23, 'W')]
        [InlineData(24, 'X')]
        [InlineData(25, 'Y')]
        [InlineData(26, 'Z')]
        public void CanGetAlphabetLetterByNumber(int position, char expected)
        {
            // Arrange & Act
            var sut = Alphabet.GetLetterOfAlphabetByPosition(position);

            // Assert
            sut.Should().Be(expected);
        }
    }
}
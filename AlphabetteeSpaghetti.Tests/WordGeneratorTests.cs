using AlphabetteeSpaghetti.Core;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace AlphabetteeSpaghetti.Tests
{
    public class WordGeneratorTests
    {
        [Fact]
        public void When1DigitWordThenListContainingTheAlphabetIsReturnedInListForm()
        {
            // Arrange & Act
            var sut = WordGenerator.GeneratePermutations(1);

            // Assert
            sut.Should().Contain("A");
            sut.Should().Contain("G");
            sut.Should().Contain("M");
            sut.Should().Contain("Z");
            sut.Should().NotContain("AA");
            sut.Should().NotContain("ZZ");
            sut.Count().Should().Be(26);
        }

        [Fact]
        public void When2DigitWordIsCreatedIsContainsExpectedResults()
        {
            // Arrange & Act
            var sut = WordGenerator.GeneratePermutations(2);

            // Assert
            sut.Should().Contain("AA");
            sut.Should().Contain("AD");
            sut.Should().Contain("LD");
            sut.Should().Contain("XF");
            sut.Should().Contain("ZX");
            sut.Should().Contain("ZZ");

            sut.Where(c => c == "ZZ").Count().Should().Be(1);
        }

        [Fact]
        public void When3DigitWordIsCreatedIsContainsExpectedResults()
        {
            // Arrange & Act
            var sut = WordGenerator.GeneratePermutations(3);

            // Assert
            sut.Should().Contain("AAA");
            sut.Should().Contain("ADS");
            sut.Should().Contain("LDE");
            sut.Should().Contain("XFS");
            sut.Should().Contain("ZXX");
            sut.Should().Contain("ZZW");
        }
    }
}
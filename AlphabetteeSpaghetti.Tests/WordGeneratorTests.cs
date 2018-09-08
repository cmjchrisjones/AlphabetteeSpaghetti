using AlphabetteeSpaghetti.Core;
using FluentAssertions;
using System;
using System.Diagnostics;
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
            var times = 1;
            var sut = WordGenerator.GeneratePermutations(times);

            // Assert
            sut.Should().Contain("A");
            sut.Should().Contain("G");
            sut.Should().Contain("M");
            sut.Should().Contain("Z");
            sut.Should().NotContain("AA");
            sut.Should().NotContain("ZZ");
            var expectedPermutations = (int)Math.Pow(26, times);
            Trace.Write(expectedPermutations);

            sut.Count().Should().Be(expectedPermutations);
        }

        [Fact]
        public void When2DigitWordIsCreatedIsContainsExpectedResults()
        {
            // Arrange & Act
            var times = 2;
            var sut = WordGenerator.GeneratePermutations(times);

            // Assert
            sut.Should().Contain("AA");
            sut.Should().Contain("AD");
            sut.Should().Contain("LD");
            sut.Should().Contain("XF");
            sut.Should().Contain("ZX");
            sut.Should().Contain("ZZ");

            sut.Where(c => c == "ZZ").Count().Should().Be(1);

            //var expectedPermuatations = (times * (26 * 26) / times) + 26;
            var expectedPermutations = (int)Math.Pow(26, times);
            Trace.Write(expectedPermutations);

            sut.Count().Should().Be(expectedPermutations);
        }

        [Fact]
        public void When3DigitWordIsCreatedIsContainsExpectedResults()
        {
            // Arrange & Act
            var times = 3;
            var sut = WordGenerator.GeneratePermutations(times);

            // Assert
            sut.Should().Contain("AAA");
            sut.Should().Contain("ADS");
            sut.Should().Contain("LDE");
            sut.Should().Contain("XFS");
            sut.Should().Contain("ZXX");
            sut.Should().Contain("ZZW");

            sut.Should().NotContain("AA");
            sut.Should().NotContain("AD");
            sut.Should().NotContain("LD");
            sut.Should().NotContain("XF");
            sut.Should().NotContain("ZX");
            sut.Should().NotContain("ZZ");

            sut.Should().NotContain("A");
            sut.Should().NotContain("G");
            sut.Should().NotContain("M");
            sut.Should().NotContain("Z");
            sut.Should().NotContain("AA");
            sut.Should().NotContain("ZZ");

            var expectedPermutations = (int)Math.Pow(26, times);
            Trace.Write(expectedPermutations);
            sut.Count().Should().Be(expectedPermutations);
        }
    }
}
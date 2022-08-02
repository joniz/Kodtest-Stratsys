using Application.Common.Services;
using Application.Enums;
using Xunit;
using FluentAssertions;
using System;

namespace Application.Tests
{
    public class SkiEquipmentServiceTests
    {
        [Theory]
        [InlineData(20, 0, 20)]
        [InlineData(21, 1, 21)]
        [InlineData(22, 2, 22)]
        [InlineData(23, 3, 23)]
        [InlineData(24, 4, 24)]
        [InlineData(25, 5, 25 + 20)]
        [InlineData(26, 6, 26 + 20)]
        [InlineData(27, 7, 27 + 20)]
        [InlineData(28, 8, 28 + 20)]
        public void SkiLengthsForChildrenAreCorrect(int length, int age, int expectedSkiLength)
        {
            //Arrange
            var service = new SkiEquipmentService();

            //Act
            var skiLength = service.GetRecommendedSkiLength(length, age, SkiType.Classic);

            //Assert
            skiLength.Should().Be(expectedSkiLength);
        }

        [Theory]
        [InlineData(180, 9, SkiType.Classic, 200)]
        [InlineData(200, 25, SkiType.Classic, 207)]
        [InlineData(170, 9, SkiType.Freestyle, 185)]
        [InlineData(190, 25, SkiType.Freestyle, 192)]
        public void SkiLengthsForNonChildrenAreCorrect(int length, int age, SkiType skiType, int expectedSkiLength)
        {
            //Arrange
            var service = new SkiEquipmentService();

            //Act
            var skiLength = service.GetRecommendedSkiLength(length, age, skiType);

            //Assert
            skiLength.Should().Be(expectedSkiLength);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Given_LengthLessThanOrEqualToZero_When_CalculatingSkiLength_Then_ThrowArgumentException(int length)
        {
            //Arrange
            var service = new SkiEquipmentService();

            //Act
            Action act = () => service.GetRecommendedSkiLength(length, 10, SkiType.Classic);

            //Assert
            act.Should().Throw<ArgumentException>().WithMessage("length must be greater than 0");
        }

        [Fact]
        public void Given_AgeLessThanZero_When_CalculatingSkiLength_Then_ThrowArgumentException()
        {
            //Arrange
            var service = new SkiEquipmentService();

            //Act
            Action act = () => service.GetRecommendedSkiLength(10, -1, SkiType.Freestyle);

            //Assert
            act.Should().Throw<ArgumentException>().WithMessage("Age cannot me less than zero");
        }
    }
}
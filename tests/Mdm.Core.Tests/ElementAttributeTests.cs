using FluentAssertions;

namespace Mdm.Core.Tests;

public class ElementAttributeTests
{
    [Theory]
    [InlineData(ElementAttributeType.Number, "123", true)]
    [InlineData(ElementAttributeType.Number, "123.45", true)]
    [InlineData(ElementAttributeType.Number, "123.45.67", false)]
    [InlineData(ElementAttributeType.Number, "abc", false)]
    [InlineData(ElementAttributeType.Text, "abc", true)]
    [InlineData(ElementAttributeType.Text, "", false)]
    [InlineData(ElementAttributeType.Text, " ", true)]
    [InlineData(ElementAttributeType.Text, null, false)]
    public void Validate_NumberAttribute_ReturnsTrue(ElementAttributeType type, string value, bool expected)
    {
        // Arrange
        var attribute = new ElementAttribute
        {
            Type = type,
            Value = value
        };

        // Act
        var result = attribute.Validate();

        // Assert
        result.Should().Be(expected);
    }
    
}
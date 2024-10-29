using FluentAssertions;
using NetworkUtility.Ping;
using Xunit;
namespace NetworkUtility.Tests.PingTests;

public class NetworkServiceTests
{
    [Fact]
    public void NetworkService_SendPing_ReturnString()
    {
        // Arrange - Variables,Classes,Mocks
        var pingService = new NetworkService();
        // Act
        var result = pingService.SendPing();
        // Assert
        string expected = "pong";
        Assert.Equal(expected, result);
        result.Should().NotBeNull();
        // result.Should().Be("ping");

    }
}
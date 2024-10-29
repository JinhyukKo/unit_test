using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.DNS;
using NetworkUtility.Ping;
using NetworkUtility.Ping.Model;
using Xunit;
namespace NetworkUtility.Tests.PingTests;
   
public class NetworkServiceTests
{
    private readonly NetworkService _pingService;
    private readonly IDNS _dnsService;
    public NetworkServiceTests()
    { 
        //Dependencies
        // IDNS _dnsService = new DNSService();
        _dnsService = A.Fake<IDNS>();
        
        //SUT
        _pingService = new NetworkService(_dnsService);
    }
    [Fact]
    public void NetworkService_SendPing_ReturnString()
    {
        // Arrange - Variables,Classes,Mocks
        // A.CallTo(() => _dnsService.SendDNS()).Returns(true);
        // Act
        string result = _pingService.SendPing();
        // Assert
        string expected = "ping";
        Assert.Equal(expected, result);
        result.Should().Be("ping"); // 위와 같음 
        result.Should().NotBeNu l();
        

    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(1,4,5)]
    public void NetworkService_SendPing_ReturnInt(int a, int b, int expected)
    {
        //Arragne
        //Act

        int result =_pingService.Add(a,b);
        //Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void NetworkService_GetUser_ReturnUser()
    {
        // Arrange
        var expected = new User(){name="jin",age=25};
        // Act
        var result = _pingService.GetUser();
        
        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<User>();
        result.Should().BeEquivalentTo(expected);
        result.age.Should().Be(25);
    }
    
    
}
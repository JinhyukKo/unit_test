using NetworkUtility.DNS;
using NetworkUtility.Ping.Model;

namespace NetworkUtility.Ping;

public class NetworkService
{
    private readonly IDNS _DNSService;
    public NetworkService(IDNS dns)
    {
        _DNSService = dns;
    }
    public string SendPing()
    {
        bool success = _DNSService.SendDNS();
        if (success)
        {
            return "ping";
        }
        else
        {
            return "failed";
        }
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public User GetUser()
    {
        return new User()
        {
            name = "jin",
            age = 25
        };
    }
}
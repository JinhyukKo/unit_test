using NetworkUtility.Ping.Model;

namespace NetworkUtility.Ping;

public class NetworkService
{
    public string SendPing()
    {
        return "ping";
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
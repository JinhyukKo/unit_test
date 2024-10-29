// See https://aka.ms/new-console-template for more information

using NetworkUtility.DNS;
using NetworkUtility.Ping;

Console.WriteLine("Hello, World!");
var networkService = new NetworkService(new DNSService());
Console.WriteLine(networkService.SendPing());
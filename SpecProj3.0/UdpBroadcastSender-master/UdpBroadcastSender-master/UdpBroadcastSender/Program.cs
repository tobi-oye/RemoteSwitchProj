using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

// Using TcpClient
namespace UdpBroadcastSender
{
    class Program
    {
        public const int Port =4210;
        static void Main()
        {   
            UdpClient socket = new UdpClient();
            socket.EnableBroadcast = true; // IMPORTANT
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, Port);
            while (true)
            {
                string message = "1_OFF";
                byte[] sendBuffer = Encoding.ASCII.GetBytes(message);
                socket.Send(sendBuffer, sendBuffer.Length, endPoint);
                Console.WriteLine("Message {2} sent to broadcast address {0} port {1}", endPoint.Address, Port, message);
                Thread.Sleep(5000);
              
            }

            
        }
    }
}

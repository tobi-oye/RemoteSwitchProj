using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SpecProj3._0.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public const int Port = 4210;
        public string Index(string id, object sender, EventArgs e)
        {
            //return "Hello World";
            UdpClient socket = new UdpClient();
            socket.EnableBroadcast = true; // IMPORTANT
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, Port);
            while (true)
            {
                string message = id /*"The time is " + DateTime.Now*/;
                byte[] sendBuffer = Encoding.ASCII.GetBytes(message);
                socket.Send(sendBuffer, sendBuffer.Length, endPoint);
                //Console.WriteLine("Message sent to broadcast address {0} port {1}", endPoint.Address, Port);
                Thread.Sleep(5000);
                return string.Format("Message {2} sent to broadcast address {0} port {1}", endPoint.Address, Port,id);

                

            }



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace SpecProj3._0.Controllers
{
    public class Automations
    {
        // GET: remSwitch
        

        public const int Port = 4210;
        public string Index(string id /*,object sender, EventArgs e*/) 
           
            
        {
            //return "Hello World";
            UdpClient socket = new UdpClient();
            socket.EnableBroadcast = true; // IMPORTANT
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.1.179"), Port);
            while (true)
            {
                string message = id /*"The time is " + DateTime.Now*/;
                byte[] sendBuffer = Encoding.ASCII.GetBytes(message);
                socket.Send(sendBuffer, sendBuffer.Length, endPoint);
                //Console.WriteLine("Message sent to broadcast address {0} port {1}", endPoint.Address, Port);
                //return string.Format("Message {2} sent to broadcast address {0} port {1}", endPoint.Address, Port,id);

                Thread.Sleep(900000);

            }

        }

    }
}
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace ServerForma
{
    public class Server
    {
        Socket osluskujuciSocket;
        public Server()
        {
            osluskujuciSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            osluskujuciSocket.Bind(endPoint);
            osluskujuciSocket.Listen(5);
        }
        public void Listen()
        {
            try
            {
                Socket klijentskiSocket = osluskujuciSocket.Accept();
                ClientHandler handler = new ClientHandler(klijentskiSocket);
                handler.HandleRequest();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>>>>>>>>" + ex.Message);
            }
        }
    }
}

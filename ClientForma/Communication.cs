using Common.Communication;
using System.Net.Sockets;

namespace ClientForma
{
    public class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication() { }

        Socket socket;
        Sender sender;
        Receiver receiver;
        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }
        public void PosaljiPoruku(object arg)
        {
            sender.Send(arg);
        }
        public object PrimiPoruku()
        {
            return receiver.Receive();
        }

    }
}

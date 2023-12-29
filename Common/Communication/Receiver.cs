using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common.Communication
{
    public class Receiver
    {
        Socket socket;
        NetworkStream stream;
        BinaryFormatter formatter;
        public Receiver(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }
        public object Receive()
        {
            return formatter.Deserialize(stream);
        }
    }
}

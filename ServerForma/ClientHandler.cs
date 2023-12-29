using Common.Communication;
using System.Net.Sockets;

namespace ServerForma
{
    public class ClientHandler
    {
        private bool kraj = false;
        Socket socket;
        Sender sender;
        Receiver receiver;


        public ClientHandler(Socket klijentskiSocket)
        {
            socket = klijentskiSocket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void HandleRequest()
        {
            while (!kraj)
            {
                Request request = (Request)receiver.Receive();
                Response response = new Response();
                switch (request.Operacija)
                {
                    case Operation.ProveriPoziciju:
                        response.Vrednost = Controller.Instance.VratiVrednost(request.Pozicija);
                        sender.Send(response);
                        break;
                    case Operation.Kraj:
                        kraj = true;
                        break;
                    default: break;
                }
            }
        }
    }
}
using System.Text;
using System.Net.Sockets;

namespace LRTapp
{
    class Client
    {
        public int port = 24000;
        public string hostName = "192.168.1.1";

        private TcpClient client;
        private NetworkStream nwStream;
        
        public Client()
        {
        }
        public Client(string hostName, int port)
        {
            this.hostName = hostName;
            this.port = port;
        }

        public void Connect()
        {
            client = new TcpClient(hostName, port);
            nwStream = client.GetStream();
        }
        public void Disconnect()
        {
            if (nwStream != null)
            {
                nwStream.Close();
                nwStream.Dispose();
                client.Close();
                
            }
        }

        public void ClearStream()
        {
            while (nwStream.DataAvailable)
            {
                nwStream.ReadByte();
            }
            
        }
        public void SendMessage(string message)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(message);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
        }

        public bool DataAvailable()
        {
            return nwStream.DataAvailable;
        }

        public string ReadByte()
        {
            char rbyte = (char)nwStream.ReadByte();
            return rbyte.ToString();
        }

        public string ReadLine()
        {
            char byteToRead;
            string text = null;
            while (true)
            {
                if (!nwStream.DataAvailable)
                {
                    return text;
                }
                byteToRead = (char)nwStream.ReadByte();
                if (byteToRead == '\n' )
                {
                    return text;
                }
                text += byteToRead.ToString();
            }
        }
        public string ReadLines(uint lines, uint skiplines)
        {
            for (int j = 0; j < skiplines; j++)
            {
                ReadLine();
            }
            string text = "";
            string line = null;
            for (int i = 0 ; i< lines ; i++)
            {
                line = ReadLine();
                text += line;
                if (i < lines - 1 && line!=null)
                {
                    text += '\n';
                }
                 
            }
            return text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace ClassLibrary1
{

    public class Client
    {
        static Socket sck;
        public Boolean turnLeft(String r, String theta)
        {
            JSInterface jobj = new JSInterface();
            //jobj = jobj.getObj(r, theta);
      
            return sendToServer(jobj.getObj(r,theta));
        }
        public Boolean turnRight(String r, String theta) 
        {
            JSInterface jobj = new JSInterface();
            //jobj = jobj.getObj(r, theta);

            return sendToServer(jobj.getObj(r, theta));
        }

        private Boolean sendToServer(JSInterface obj1)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            //Attempt a connection
            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                //if connections fails 
                Console.Write("Unable to connect to remote end point!\r\n");
                return false;
            }
            Console.Write("Enter Text: ");
            //String text = r + theta;
            byte[] data = Encoding
            sck.Send(obj1);
            Console.Write("Data Sent. \r\n");
            Console.Read();
            sck.Close();
            return true;
        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using model;

namespace TCP_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 25558);
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for a connection.");

                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client accepted.");

                NetworkStream stream = client.GetStream();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                try
                {
                    byte[] buffer = new byte[1024];
                    //stream.Read(buffer, 0, buffer.Length);
                    int recv = 0;
                    foreach (byte b in buffer)
                    {
                        if (b != 0)
                        {
                            recv++;
                        }
                    }

                    //string request = Encoding.UTF8.GetString(buffer, 0, recv);
                    string request = sr.ReadLine();
                    Console.WriteLine("request received: " + request);
                    
                    if (request == "HentAlle")
                    {
                        sw.WriteLine("Successfully executed HentAlle!");
                        for (int i = 0; i < DataSet.fanData.Count; i++)
                        {
                            sw.WriteLine(DataSet.fanData[i].fanData());
                            //Console.WriteLine(DataSet.getData());
                            sw.Flush();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong.");
                    sw.WriteLine(e.ToString());
                }
            }
        }
    }
}

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static TcpListener server;
    static List<TcpClient> clients = new List<TcpClient>();
    static Dictionary<TcpClient, string> clientChoices = new Dictionary<TcpClient, string>();
    static object lockObj = new object();

    static void Main()
    {
        server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("Server started on port 5000...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected!");
            lock (lockObj) clients.Add(client);

        }
    }
}

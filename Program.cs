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
        Console.WriteLine("✅ Server started on port 5000...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("🔗 Client connected!");
            lock (lockObj) clients.Add(client);

            Thread t = new Thread(() => HandleClient(client));
            t.Start();
        }
    }

    static void HandleClient(TcpClient client)
    {
        try
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (true)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"💬 Client says: {msg}");

                lock (lockObj)
                {
                    clientChoices[client] = msg;

                    // Nếu có đủ 2 client đã chọn
                    if (clientChoices.Count == 2)
                    {
                        var players = new List<TcpClient>(clientChoices.Keys);
                        string choice1 = clientChoices[players[0]];
                        string choice2 = clientChoices[players[1]];

                        string result1 = Compare(choice1, choice2);
                        string result2 = Compare(choice2, choice1);

                        Send(players[0], $"{result1}|{choice2}");
                        Send(players[1], $"{result2}|{choice1}");

                        clientChoices.Clear(); // reset round
                    }
                }
            }
        }
        catch { }
        finally
        {
            Console.WriteLine("❌ Client disconnected.");
            lock (lockObj)
            {
                clients.Remove(client);
                if (clientChoices.ContainsKey(client))
                    clientChoices.Remove(client);
            }
            client.Close();
        }
    }

    static void Send(TcpClient client, string msg)
    {
        try
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            client.GetStream().Write(data, 0, data.Length);
        }
        catch { }
    }

    static string Compare(string c1, string c2)
    {
        if (c1 == c2) return "Draw";
        if ((c1 == "Rock" && c2 == "Scissors") ||
                (c1 == "Paper" && c2 == "Rock") ||
                (c1 == "Scissors" && c2 == "Paper"))
            return "Win";
        return "Lose";
    }
}
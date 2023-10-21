using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

class VoiceChatServer
{
    private TcpListener server;
    private List<ClientHandler> clients;

    

    public VoiceChatServer()
    {
        clients = new List<ClientHandler>();
        server = new TcpListener(IPAddress.Any, 8000);
        server.Start();

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            ClientHandler handler = new ClientHandler(client);

            clients.Add(handler);
            handler.Run();
        }
    }

    
}

class ClientHandler
{
    public ClientHandler(TcpClient client)
    {
        this.client = client;
    }

    private TcpClient client;
    // rest of handling code

    public void Run()
    {
        while (true)
        {
            // 1. Receive audio
            // 2. Relay audio to other clients
        }
    }
}
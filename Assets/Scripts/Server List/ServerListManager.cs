using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using WebSocketSharp;

[Serializable]
public class Server
{
    public string ip;
    public string name;

    public Server(string ip, string name)
    {
        this.ip = ip;
        this.name = name;
    }
}

public class ServerListManager : Singleton
{
    WebSocket ws;

    private void Start()
    {
        ws = new WebSocket("ws://localhost:1234");
        ws.Connect();
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message from websocket: " + e.Data);
        };
    }

    private void Update()
    {
        if (ws == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var server = new Server("198.50.201.118", "Nome Do Servidor");
            var json = JsonUtility.ToJson(server);
            Debug.Log(json);
            ws.Send(json);
        }
    }

    public void FetchServerList()
    {
            
    }
}
    
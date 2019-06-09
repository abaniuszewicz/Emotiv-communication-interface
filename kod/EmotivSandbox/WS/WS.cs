using System;
using WebSocketSharp;

namespace WS
{
    public class WS
    {
        public WS()
        {
            var ws = new WebSocket("aa");

            ws.OnOpen += (s, e) => Console.WriteLine("Connected");
            ws.OnClose += (s, e) => Console.WriteLine("Disconnected");
            ws.OnMessage += (s, e) => Console.WriteLine("Received message:" + e?.Data);
        }
    }
}

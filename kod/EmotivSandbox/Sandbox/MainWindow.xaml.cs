using System;
using System.Threading;
using System.Windows;
using WebSocketSharp;

namespace Sandbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebSocket ws = new WebSocket("wss://localhost:6868");
        public MainWindow()
        {
            InitializeComponent();
            ws.OnOpen += Ws_OnOpen;
            ws.OnClose += Ws_OnClose;
            ws.OnError += Ws_OnError;
            ws.OnMessage += Ws_OnMessage;

            ws.Connect();
            ws.Send("a");
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            AppendText("Message: " + e?.Data);
        }

        private void Ws_OnError(object sender, ErrorEventArgs e)
        {
            AppendText("Error: " + e?.Message);
        }

        private void Ws_OnClose(object sender, CloseEventArgs e)
        {
            AppendText("Disconnected: " + e?.Reason);
        }

        private void Ws_OnOpen(object sender, EventArgs e)
        {
            AppendText("Connected");
        }

        private void AppendText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            tb.Dispatcher.Invoke(() => tb.Text += text + Environment.NewLine);
        }
    }
}

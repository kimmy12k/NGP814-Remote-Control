using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NGP814
{
    public class NGPTCP
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private StreamReader _reader;
        private StreamWriter _writer;
        public bool IsConnected
        {
            get
            {
                if (_client == null) return false;
                return _client.Connected;
            }
        }
        public void Connect(string ip, int port = 5025, int timeoutMs= 3000)// manual 8.2.1 -> fixed at port 5025
        {
            _client = new TcpClient();

            Task connectTask = _client.ConnectAsync(ip, port);
            if (!connectTask.Wait(timeoutMs))
            {
                _client.Close();
                throw new Exception("연결 시간 초과 (" + timeoutMs / 1000 + "초)");
            }

            if (connectTask.IsFaulted)
            {
                _client.Close();
                throw connectTask.Exception.InnerException;
            }

            _stream = _client.GetStream();
            _stream.ReadTimeout = 3000;   // 읽기 타임아웃 3초
            _stream.WriteTimeout = 3000;  // 쓰기 타임아웃 3초
            _reader = new StreamReader(_stream);
            _writer = new StreamWriter(_stream)
            {
                NewLine = "\n",
                AutoFlush = true
            };
        }
        public void Disconnect()
        {
            _reader?.Close();
            _writer?.Close();
            _stream?.Close();
            _client?.Close();
        }
        public void Write(string str)
        {
            _writer.WriteLine(str);
        }
        public string Query(string str) //  Manual 9.1 ->  명령어 CLS,ESE,IDN 등
        {
            _writer.WriteLine(str);
            return _reader.ReadLine();
        }

}
}

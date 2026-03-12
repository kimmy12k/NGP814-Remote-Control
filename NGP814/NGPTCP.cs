using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

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

            Task connectTask = _client.ConnectAsync(ip, port);// 비동기 처리
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

            _stream = _client.GetStream();//TCP 연결된 소켓의 바이트 스트림에 직접 접근
            _stream.ReadTimeout = 3000;   // 읽기 타임아웃 3초
            _stream.WriteTimeout = 3000;  // 쓰기 타임아웃 3초
            _reader = new StreamReader(_stream);
            _writer = new StreamWriter(_stream)
            {
                NewLine = "\n",
                AutoFlush = true// 즉시 전송
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
        public void SelectChannel(int channel) // 명령어 INIST OUT 채널 숫자   <->  지금 채널 물어보는 명령어 INIST? page 181
        {
            Write($"INST OUT{channel}");
        }
        public void SetVolt(int ch)
        {
            Write($"VOLT {ch}");
        }
        public void SetCurr(int ch)
        {
            Write($"Curr {ch}");
        }
        public string ReadQ(int num)// NGP814_ 개발항목_정리V2 -> SPCI 명령어 정리 -> QUERY 번호
        {
            string str;
            switch (num)
            {
                case 3:  str = Query("VOLT?");break;
                case 5:  str =Query("CURR?"); break;
                case 7:  str = Query("ALIM?");break;
                case 9:  str = Query("VOLT:ALIM?");break;
                case 11: str = Query("VOLT:ALIM:LOW?"); break;
                case 13: str = Query("CURR:ALIM?"); break;
                case 15: str = Query("CURR:ALIM:LOW?"); break;
                case 16: str = Query("MEAS:VOLT?");break;
                case 17: str = Query("MEAS:CURR?"); break;
                case 18: str = Query("MEAS:POW?"); break;
                default: MessageBox.Show("지원하지 않는 번호입니다.");return ""; break;
            }
            return str;
        }

        private string CheckMode(int ch)
        {
            return Query($"STAT:QUES:INST:ISUM{ch}:COND?"); 
        }
   

    }
}

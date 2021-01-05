using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace SpeedTest
{
    class TestPing
    {
        private readonly int timeout = 1000;
        private static readonly string data_send = "Hello";
        private readonly byte[] buffer = Encoding.ASCII.GetBytes(data_send);

        public List<int> listValue = new List<int>(); // tableau de reponse du ping

        public int p_maxValue, p_minValue, p_averageValue, p_currentValue;

        public int count = 0;

        private int packetLoss = 0;
        public int percentage_packetLoss;

        private bool packetIsLost = false;
        public TestPing()
        {
            p_maxValue = 0;
            p_minValue = 99999;
            p_averageValue = 0;
        }

        public bool Ping()
        {
            Ping echo = new Ping();
            PingOptions options = new PingOptions(64, true);
            PingReply reply = echo.Send("8.8.4.4", timeout, buffer, options);
            int data = (int)reply.RoundtripTime;
            if (reply.Status == IPStatus.Success)
            {
                listValue.Add((int)(data));
                packetIsLost = false;
                SetStats();
                count++;
                return true;
            }
            else
            {
                packetIsLost = true;
                packetLoss++;
                SetStats();
                count++;
                return false;
            }
        }

        private void SetStats()
        {

            if(packetIsLost)
            {
                percentage_packetLoss = (packetLoss * 100) / (listValue.Count + packetLoss);
                return;
            }
            p_currentValue = (int)(listValue[count-packetLoss]); // current value
            if (p_currentValue < p_minValue) // min value
            {
                p_minValue = p_currentValue;
            }

            else if (p_currentValue > p_maxValue) // max value
            {
                p_maxValue = p_currentValue;
            }

            int avg = 0;
            for (int i = 0; i < listValue.Count; i++)
            {
                avg += listValue[i];
            }
            avg /= (count + 1);
            p_averageValue = avg;
            percentage_packetLoss = (packetLoss * 100) / (listValue.Count + packetLoss);
        }
    }
}

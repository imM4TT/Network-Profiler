using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace SpeedTest
{

    class Bandwidth
    {
        private readonly string urlFile = "https://onedrive.live.com/download?resid=ECC5DE4582E5B558!346&authkey=!ANKQBD0TlRDsz5c&ithint=file%2ctxt&e=e4vFsD";

        private CancellationTokenSource cancelToken;

        private readonly string tempFile = Path.Combine(Path.GetTempPath(), "speedTest.txt");

        private long _lastBytesRecevied;
        private DateTime _lastReceivedMesurement;

        public int max, min, current;
        public double avrg;
        public List<int> listValue = new List<int>();
        public Task<string> task_currentDownload;
        public int index_bw = 0;
        public int waitTime = 550;

        public string unity;
        public int unity_factor;
        public Bandwidth()
        {
            cancelToken = new CancellationTokenSource();
            max = 0;
            min = 0;
            _lastReceivedMesurement = DateTime.UtcNow;
            _lastBytesRecevied = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesReceived;

            task_currentDownload = DownloadFileAsync(urlFile, tempFile, cancelToken.Token);
        }

        public void ResetStats()
        {
            listValue = new List<int>();
            max = 0;
            min = 0;
            avrg = 0;
            current = 0;
        }
        int x = 0;
        public void SetStats()
        {
            current = GetDownloadSpeed();
            if (index_bw < 9)
            {
                index_bw++;
                return;
            }
            listValue.Add(current);
            Console.WriteLine(index_bw);
            if (index_bw == 9)
            {
                waitTime = 1;
                min = current;
                max = current;

            }
            else if(current > max)
            {
                max = current;
            }
            else if(current < min)
            {
                min = current;
            }
            x = 0;
            for (int i = 0; i < listValue.Count; i++)
            {
                x += listValue[i];
                avrg += listValue[i];
            }
            avrg /= listValue.Count;
            index_bw++;
        }

        public void StopDownload()
        {
            cancelToken.Cancel();
        }

        public int GetDownloadSpeed()
        {
            double result = (NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesReceived - _lastBytesRecevied) / (DateTime.UtcNow - _lastReceivedMesurement).TotalSeconds;

            _lastReceivedMesurement = DateTime.UtcNow;
            _lastBytesRecevied = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesReceived;

            return (int)result;
        }
        
        public string ToXBytes(double b)
        {
            double xbytes = Math.Round((b / unity_factor), 1);
            return xbytes.ToString();
        }
        private async Task<string> DownloadFileAsync(string url, string outputFileName, CancellationToken cancellationToken)
        {
            using (var webClient = new WebClient())
            {
                cancellationToken.Register(webClient.CancelAsync);

                try
                {
                    var task = webClient.DownloadFileTaskAsync(url, outputFileName);

                    await task; // This line throws an exception when cancellationTokenSource.Cancel() is called.
                }
                catch (WebException ex) when (ex.Message == "The request was aborted: The request was canceled.")
                {
                    throw new OperationCanceledException();
                }
                catch (TaskCanceledException)
                {
                    throw new OperationCanceledException();
                }

                return outputFileName;
            }
        }
    }
}

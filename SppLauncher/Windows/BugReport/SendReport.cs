using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;

namespace SppLauncher.Windows.BugReport
{
    public class SendReport
    {
        
        public void SendError(string report, string bugtype, string email, string desc, string cpu, string cpucore, string ram, string os, string ver)
        {
            
            try
            {
                TcpClient client = new TcpClient();
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(BugReport.RemoteIp), 5459);
                client.Connect(serverEndPoint);
                NetworkStream clientStream = client.GetStream();
                UTF8Encoding encoder = new UTF8Encoding();
                byte[] buffer = encoder.GetBytes(report + ";" + bugtype + ";" + email + ";" + desc + ";" + cpu + ";" + cpucore + ";" + ram + ";" + os + ";" + ver);
                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not connect to the reporting server\nPlease try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SendLogs(string file)
        {
            IPAddress ipAddress = IPAddress.Parse(BugReport.RemoteIp);
            int port = 5460;
            int bufferSize = 1024;

            TcpClient client = new TcpClient();
            NetworkStream netStream;

            // Connect to server
            try
            {
                client.Connect(new IPEndPoint(ipAddress, port));
            }
            catch (Exception ex)
            {
            }
            netStream = client.GetStream();

            // Read bytes from image
            byte[] data = File.ReadAllBytes(file);

            // Build the package
            byte[] dataLength = BitConverter.GetBytes(data.Length);
            byte[] package = new byte[4 + data.Length];
            dataLength.CopyTo(package, 0);
            data.CopyTo(package, 4);

            // Send to server
            int bytesSent = 0;
            int bytesLeft = package.Length;

            while (bytesLeft > 0)
            {
                int nextPacketSize = (bytesLeft > bufferSize) ? bufferSize : bytesLeft;
                netStream.Write(package, bytesSent, nextPacketSize);
                bytesSent += nextPacketSize;
                bytesLeft -= nextPacketSize;
            }
            // Clean up
            netStream.Close();
            client.Close();
        }
        
        public void zipLogs()
        {
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddDirectory("Logs");
                    zip.Save("logs.zip");

                }
                SendLogs("logs.zip");
                File.Delete("logs.zip");
            }
        }
    }

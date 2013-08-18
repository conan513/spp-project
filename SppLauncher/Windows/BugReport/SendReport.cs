using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SppLauncher.Windows.BugReport
{
    class SendReport
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
                MessageBox.Show("Thank you for the report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Can not connect to the reporting server\nPlease try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

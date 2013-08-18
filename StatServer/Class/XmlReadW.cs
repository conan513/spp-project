using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace StatServer.Class
{
    class XmlReadW
    {
        public void SaveXml()
        {
            try
            {
                var writer = new XmlTextWriter(Statistics.savepath + "counter.xml", Encoding.UTF8)
                {
                    Formatting = Formatting.Indented
                };

                writer.WriteStartDocument();
                writer.WriteComment(DateTime.Now.ToString(CultureInfo.InvariantCulture));
                writer.WriteStartElement("Save");
                writer.WriteElementString("Report", Statistics._report.ToString(CultureInfo.InvariantCulture));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nWrited error to ErrorMsg.txt", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                WriteError(ex.Message);
            }
        }

        public void ReadXml()
        {
            if (File.Exists("counter.xml")) //not exist? run SaveXML and create it.
            {
                try
                {
                    var doc = new XmlDocument();
                    doc.Load("counter.xml");
                    XmlElement root = doc.DocumentElement;
                    XmlNodeList nodes = root.SelectNodes("/Save");

                    foreach (XmlNode node in nodes)
                    {
                        Statistics._report = Convert.ToInt32(node["Report"].InnerText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nWrited error to ErrorMsg.txt", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    WriteError(ex.Message);
                }
            }
            else
            {
                SaveXml();
            }
        }

        private void WriteError(string errMsg)
        {
            File.WriteAllText(@"ErrorMsg.txt", errMsg, Encoding.UTF8);
        }
    }
}

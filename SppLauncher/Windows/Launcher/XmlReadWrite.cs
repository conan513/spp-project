using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SppLauncher.Windows.Launcher;

namespace SppLauncher.Class
{
    public class XmlReadWrite
    {

        public void saveMethod()
        {
            try
            {
                var writer = new XmlTextWriter("Settings\\SppPathConfig.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Config");
                writer.WriteElementString("GamePath", Launcher.WowExePath);
                writer.WriteElementString("RealmWTF", Launcher.RealmListPath);
                writer.WriteElementString("ResetBots", Launcher.resetBots);
                writer.WriteElementString("RandomizeBots", Launcher.RandomizeBots);
                writer.WriteElementString("Autostart", Launcher.AutoS);
                writer.WriteElementString("Lang", Launcher.Lang);
                writer.WriteElementString("Sysprotect", Launcher.SysProt);
                writer.WriteEndElement();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some exception: ReadXML \n{0}", ex.Message);
            }
        }

        public bool ReadXML()
        {
            try
            {
                var doc = new XmlDocument();
                doc.Load("Settings\\SppPathConfig.xml");
                XmlElement root   = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/Config");

                foreach (XmlNode node in nodes)
                {
                    Launcher.WowExePath    = node["GamePath"].InnerText;
                    Launcher.RealmListPath = node["RealmWTF"].InnerText;
                    Launcher.AutoS     = node["Autostart"].InnerText;
                    Launcher.Lang          = node["Lang"].InnerText;
                    Launcher.SysProt = node["Sysprotect"].InnerText;
                }
               return true;
            }
            catch (Exception)
            {
                saveMethod();
                //MessageBox.Show("Some exception: ReadXML \n{0}", ex.Message);
                return false;
            }
        }
    }
}

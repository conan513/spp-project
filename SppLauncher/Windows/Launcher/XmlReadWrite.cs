using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SppLauncher.Class
{
    public class XmlReadWrite
    {

        public void saveMethod()
        {
            try
            {
                var writer = new XmlTextWriter("config\\SppPathConfig.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Config");
                writer.WriteElementString("GamePath", Launcher.wowExePath);
                writer.WriteElementString("RealmWTF", Launcher.realmListPath);
                writer.WriteElementString("ResetBots", Launcher.resetBots);
                writer.WriteElementString("RandomizeBots", Launcher.randomizeBots);
                writer.WriteElementString("Autostart", Launcher.Autostart);
                writer.WriteElementString("Lang", Launcher.lang);

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
                doc.Load("config\\SppPathConfig.xml");
                XmlElement root   = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/Config");

                foreach (XmlNode node in nodes)
                {
                    Launcher.wowExePath    = node["GamePath"].InnerText;
                    Launcher.realmListPath = node["RealmWTF"].InnerText;
                    Launcher.Autostart     = node["Autostart"].InnerText;
                    Launcher.lang          = node["Lang"].InnerText;
                }
               return true;
            }
            catch (Exception ex)
            {
                saveMethod();
                MessageBox.Show("Some exception: ReadXML \n{0}", ex.Message);
                return false;
            }
        }
    }
}

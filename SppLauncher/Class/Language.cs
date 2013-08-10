using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SppLauncher.Class
{
    class Language
    {
        public static void ReadXML(string lang)
        {
            try
            {
                var doc = new XmlDocument();
                doc.Load("config\\" + lang + ".xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/" + lang);

                foreach (XmlNode node in nodes)
                {
                    Launcher.button[0]  = node["text01"].InnerText;
                    Launcher.button[1]  = node["text02"].InnerText;
                    Launcher.button[2]  = node["text03"].InnerText;
                    Launcher.button[3]  = node["text04"].InnerText;
                    Launcher.button[4]  = node["text05"].InnerText;
                    Launcher.button[5]  = node["text06"].InnerText;
                    Launcher.button[6]  = node["text07"].InnerText;
                    Launcher.button[7]  = node["text08"].InnerText;
                    Launcher.button[8]  = node["text09"].InnerText;
                    Launcher.button[9]  = node["text10"].InnerText;
                    Launcher.button[10] = node["text11"].InnerText;
                    Launcher.button[11] = node["text12"].InnerText;
                    Launcher.button[12] = node["text13"].InnerText;
                    Launcher.button[13] = node["text14"].InnerText;
                    Launcher.button[14] = node["text15"].InnerText;
                    Launcher.button[15] = node["text16"].InnerText;
                    Launcher.button[16] = node["text17"].InnerText;
                    Launcher.button[17] = node["text18"].InnerText;
                    Launcher.button[18] = node["text19"].InnerText;
                    Launcher.button[19] = node["text20"].InnerText;
                    Launcher.button[20] = node["text21"].InnerText;
                    Launcher.button[21] = node["text22"].InnerText;
                    Launcher.button[22] = node["text23"].InnerText;
                    Launcher.button[23] = node["text24"].InnerText;
                    Launcher.button[24] = node["text25"].InnerText;
                    Launcher.button[25] = node["text26"].InnerText;
                    Launcher.button[26] = node["text27"].InnerText;
                    Launcher.button[27] = node["text28"].InnerText;
                    Launcher.button[28] = node["text29"].InnerText;
                    Launcher.button[29] = node["text30"].InnerText;
                    Launcher.button[30] = node["text31"].InnerText;
                    Launcher.button[31] = node["text32"].InnerText;
                    Launcher.button[32] = node["text33"].InnerText;
                    Launcher.button[33] = node["text34"].InnerText;
                    Launcher.button[34] = node["text35"].InnerText;
                    Launcher.button[35] = node["text36"].InnerText;
                    Launcher.button[36] = node["text37"].InnerText;
                    Launcher.button[37] = node["text38"].InnerText;
                    Launcher.button[38] = node["text39"].InnerText;
                    Launcher.button[39] = node["text40"].InnerText;
                    Launcher.button[40] = node["text41"].InnerText;
                    Launcher.button[41] = node["text42"].InnerText;
                    Launcher.button[42] = node["text43"].InnerText;
                    Launcher.button[43] = node["text44"].InnerText;
                    Launcher.button[44] = node["text45"].InnerText;
                    Launcher.button[45] = node["text46"].InnerText;
                    Launcher.button[46] = node["text47"].InnerText;
                    Launcher.button[47] = node["text48"].InnerText;
                    Launcher.button[48] = node["text49"].InnerText;
                    Launcher.button[49] = node["text50"].InnerText;
                    Launcher.button[50] = node["text51"].InnerText;
                    Launcher.button[51] = node["text52"].InnerText;
                    Launcher.button[52] = node["text53"].InnerText;
                    Launcher.button[53] = node["text54"].InnerText;
                    Launcher.button[54] = node["text55"].InnerText;
                    Launcher.button[55] = node["text56"].InnerText;
                    Launcher.button[56] = node["text57"].InnerText;
                    Launcher.button[57] = node["text58"].InnerText;
                    Launcher.button[58] = node["text59"].InnerText;
                    Launcher.button[59] = node["text60"].InnerText;
                    Launcher.button[60] = node["text61"].InnerText;
                    Launcher.button[61] = node["text62"].InnerText;
                    Launcher.button[62] = node["text63"].InnerText;
                    Launcher.button[63] = node["text64"].InnerText;
                    Launcher.button[64] = node["text65"].InnerText;
                    Launcher.button[65] = node["text66"].InnerText;
                    Launcher.button[66] = node["text67"].InnerText;
                    Launcher.button[67] = node["text68"].InnerText;
                    Launcher.button[68] = node["text69"].InnerText;
                    Launcher.button[69] = node["text70"].InnerText;
                }
            }
            catch
            {
            }
        }

        public static void saveMethod()
        {
            var writer        = new XmlTextWriter("config\\French.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("French");
            writer.WriteElementString("text01", Launcher.button[0]);
            writer.WriteElementString("text02", Launcher.button[1]);
            writer.WriteElementString("text03", Launcher.button[2]);
            writer.WriteElementString("text04", Launcher.button[3]);
            writer.WriteElementString("text05", Launcher.button[4]);
            writer.WriteElementString("text06", Launcher.button[5]);
            writer.WriteElementString("text07", Launcher.button[6]);
            writer.WriteElementString("text08", Launcher.button[7]);
            writer.WriteElementString("text09", Launcher.button[8]);
            writer.WriteElementString("text10", Launcher.button[9]);
            writer.WriteElementString("text11", Launcher.button[10]);
            writer.WriteElementString("text12", Launcher.button[11]);
            writer.WriteElementString("text13", Launcher.button[12]);
            writer.WriteElementString("text14", Launcher.button[13]);
            writer.WriteElementString("text15", Launcher.button[14]);
            writer.WriteElementString("text16", Launcher.button[15]);
            writer.WriteElementString("text17", Launcher.button[16]);
            writer.WriteElementString("text18", Launcher.button[17]);
            writer.WriteElementString("text19", Launcher.button[18]);
            writer.WriteElementString("text20", Launcher.button[19]);
            writer.WriteElementString("text21", Launcher.button[20]);
            writer.WriteElementString("text22", Launcher.button[21]);
            writer.WriteElementString("text23", Launcher.button[22]);
            writer.WriteElementString("text24", Launcher.button[23]);
            writer.WriteElementString("text25", Launcher.button[24]);
            writer.WriteElementString("text26", Launcher.button[25]);
            writer.WriteElementString("text27", Launcher.button[26]);
            writer.WriteElementString("text28", Launcher.button[27]);
            writer.WriteElementString("text29", Launcher.button[28]);
            writer.WriteElementString("text30", Launcher.button[29]);
            writer.WriteElementString("text31", Launcher.button[30]);
            writer.WriteElementString("text32", Launcher.button[31]);
            writer.WriteElementString("text33", Launcher.button[32]);
            writer.WriteElementString("text34", Launcher.button[33]);
            writer.WriteElementString("text35", Launcher.button[34]);
            writer.WriteElementString("text36", Launcher.button[35]);
            writer.WriteElementString("text37", Launcher.button[36]);
            writer.WriteElementString("text38", Launcher.button[37]);
            writer.WriteElementString("text39", Launcher.button[38]);
            writer.WriteElementString("text40", Launcher.button[39]);
            writer.WriteElementString("text41", Launcher.button[40]);
            writer.WriteElementString("text42", Launcher.button[41]);
            writer.WriteElementString("text43", Launcher.button[42]);
            writer.WriteElementString("text44", Launcher.button[43]);
            writer.WriteElementString("text45", Launcher.button[44]);
            writer.WriteElementString("text46", Launcher.button[45]);
            writer.WriteElementString("text47", Launcher.button[46]);
            writer.WriteElementString("text48", Launcher.button[47]);
            writer.WriteElementString("text49", Launcher.button[48]);
            writer.WriteElementString("text50", Launcher.button[49]);
            writer.WriteElementString("text51", Launcher.button[50]);
            writer.WriteElementString("text52", Launcher.button[51]);
            writer.WriteElementString("text53", Launcher.button[52]);
            writer.WriteElementString("text54", Launcher.button[53]);
            writer.WriteElementString("text55", Launcher.button[54]);
            writer.WriteElementString("text56", Launcher.button[55]);
            writer.WriteElementString("text57", Launcher.button[56]);
            writer.WriteElementString("text58", Launcher.button[57]);
            writer.WriteElementString("text59", Launcher.button[58]);
            writer.WriteElementString("text60", Launcher.button[59]);
            writer.WriteElementString("text61", Launcher.button[60]);
            writer.WriteElementString("text62", Launcher.button[61]);
            writer.WriteElementString("text63", Launcher.button[62]);
            writer.WriteElementString("text64", Launcher.button[63]);
            writer.WriteElementString("text65", Launcher.button[64]);
            writer.WriteElementString("text66", Launcher.button[65]);
            writer.WriteElementString("text67", Launcher.button[66]);
            writer.WriteElementString("text68", Launcher.button[67]);
            writer.WriteElementString("text69", Launcher.button[68]);
            writer.WriteElementString("text70", Launcher.button[69]);
            writer.WriteEndElement();
            writer.Close();
        }
    }
}

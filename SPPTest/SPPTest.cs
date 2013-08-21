using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SppLauncher;
using SppLauncher.Class;
using SppLauncher.Windows;
using SppLauncher.Windows.WowAccountCreator;
using WowAccountCreator;
using MySQLClass;

namespace SPPTest
{
    [TestClass]
    public class SPPTest
    {

        private Random _random = new Random(Environment.TickCount);

        public string RandomString(int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);

            return builder.ToString();
        }

        [TestMethod]
        public void CreateAccount()
        {
           WowaccountCreator obj = new WowaccountCreator();
            obj.txbUser.Text = RandomString(8);
            obj.txbPass.Text = RandomString(8);
            Assert.AreEqual(true, obj.InsertSqlTrinity());
        }

        [TestMethod]
        public void Checklang()
        {
            Launcher obj     = new Launcher();
            XmlReadWrite xml = new XmlReadWrite();
            if(xml.ReadXML()){obj.checklang(false);}
            obj.checklang(true);
        }

        [TestMethod]
        public void CopyUpdates()
        {
            FileCopyOverWrite obj = new FileCopyOverWrite();
            if (Directory.Exists(@"update\server")) { Assert.AreEqual(true,obj.Copy(@"update\server", "", true)); }
        }

        [TestMethod]
        public void GetUpdate()
        {
            Launcher obj = new Launcher();
            Assert.AreEqual(true, obj.GetUpdate());
        }

        [TestMethod]
        public void GetLocalVer()
        {
            Launcher obj = new Launcher();
            Assert.AreEqual(true, obj.GetLocalSrvVer());
        }

        [TestMethod]
        public void LanSwitcher()
        {
            LanSwitcher obj = new LanSwitcher();
            obj.txbLanip.Text = "0";
            obj.UpdateSql();
            Assert.AreEqual("0", obj.CheckLan());

            obj.txbLanip.Text = "127.0.0.1";
            obj.UpdateSql();

        }
    }
}

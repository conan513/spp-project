using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SppLauncher;
using SppLauncher.Class;
using SppLauncher.Windows.WowAccountCreator;
using WowAccountCreator;

namespace SPPTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateAccountTest()
        {
           WowaccountCreator obj = new WowaccountCreator();
            Random rnd = new Random();
            string user = rnd.Next(50000,60000).ToString();
            string pass = rnd.Next(50000,60000).ToString();

            obj.txbUser.Text = user;
            obj.txbPass.Text = pass;
            Assert.AreEqual(true, obj.InsertSqlTrinity());
        }

        [TestMethod]
        public void ChecklangTest()
        {
            Launcher obj = new Launcher();
            XmlReadWrite xml = new XmlReadWrite();
            if(xml.ReadXML()){obj.checklang(false);}
            obj.checklang(true);
        }

        [TestMethod]
        public void CopyUpdatesTest()
        {
            FileCopyOverWrite obj = new FileCopyOverWrite();
            if (Directory.Exists(@"update\server")) { Assert.AreEqual(true,obj.Copy(@"update\server", "", true)); }
        }

        [TestMethod]
        public void GetUpdateTest()
        {
            Launcher obj = new Launcher();
            Assert.AreEqual(true, obj.GetUpdate());
        }
    }
}

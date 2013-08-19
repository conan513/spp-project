using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SppLauncher;
using SppLauncher.Class;
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
            obj.txbUser.Text = rnd.Next(50000,60000).ToString();
            obj.txbPass.Text = rnd.Next(50000,60000).ToString();
            obj.InsertSqlTrinity();
        }

        [TestMethod]
        public void ChecklangTest()
        {
            Launcher obj = new Launcher();
            XmlReadWrite xml = new XmlReadWrite();
            if(xml.ReadXML()){obj.checklang(false);}
            obj.checklang(true);
        }
    }
}

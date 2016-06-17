using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HtmlAgilityPack.Tests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestHtmlNodeMethod()
        {
            HtmlDocument doc = new HtmlDocument();
            var v = "demo";
            doc.LoadHtml($"<p>{v}</p>");
            var node = doc.DocumentNode.SelectSingleNode("/p");
            Assert.AreEqual(v, node.InnerText);
        }

        [TestMethod]
        public void TestHtmlWebMethod()
        {
            HtmlWeb web = new HtmlWeb();
            var doc = web.LoadFromWebAsync("http://www.cnblogs.com/linezero/").Result;
            var v = "LineZero's Blog";
            var node = doc.DocumentNode.SelectSingleNode("//*[@id=\"Header1_HeaderTitle\"]");
            Assert.AreEqual(v, node.InnerText);
        }
    }
}

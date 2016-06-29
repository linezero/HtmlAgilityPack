using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text;

namespace NETCoreHtml
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            HtmlWeb web = new HtmlWeb();
            var doc = web.LoadFromWebAsync("http://news.cnblogs.com/").Result;
            var nodes = doc.DocumentNode.SelectNodes("//div[@id='news_list']/div/div[2]/h2/a");
            foreach (var item in nodes)
            {
                Console.WriteLine($"标题：{item.InnerText} 地址：{item.Attributes["href"].Value}" );
            }
            Console.ReadKey();
        }
    }
}

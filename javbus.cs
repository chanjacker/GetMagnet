using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetMagnet
{
    public  class Javbus
    {
        public static  List<string> Gethtml(string html)
        {
            List<string> list = new List<string>();
          HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//a[@class='movie-box']");
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    string magnet = node.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(magnet))
                    {
                       list.Add(magnet);
                    }
                }
                return list;
            }
            return list;
        }
       public static  string[] arr= { "thread-2128911-1-1.html", "thread-2113799-1-1.html", "thread-2069475-1-1.html", "thread-532349-1-1.html", "thread-494308-1-1.html" };
        public static List<string> Gethtml(string html,Account acc)
        {
            List<string> list = new List<string>();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes(acc.Zhengzhe);
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    string magnet = node.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(magnet)&&!arr.Contains(magnet))
                    {
                        if (!magnet.Contains("http"))
                        {
                            magnet = acc.URL +magnet;
                        }
                        if (!list.Contains(magnet))
                        {
                            list.Add(magnet);
                        }
                     
                    }
                }
                return list;
            }
            return list;
        }
        public static string GetMagnet(string html)
        {
            var matches = Regex.Match(html, MagnetPattern, RegexOptions.IgnoreCase);
            if (matches.Success)
            {
                return matches.Value;
            }
            return "";
        }

        // 正则表达式模式
        private static readonly string MagnetPattern =
            @"magnet:\?xt=urn:btih:([a-zA-Z0-9]{32,40})(?:&[a-zA-Z0-9]+=[^&""']*)*";

        /// <summary>
        /// 从文本中提取所有磁力链接
        /// </summary>
        /// <param name="input">输入文本</param>
        /// <returns>找到的磁力链接列表</returns>
        public static List<string> ExtractMagnetLinks(string input)
        {
            var matches = Regex.Matches(input, MagnetPattern, RegexOptions.IgnoreCase);
            var result = new List<string>();

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    result.Add(match.Value);
                }
            }

            return result;
        }
    }
}

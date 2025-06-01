using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetMagnet
{
    public  class Tools
    {
        public static string GetPageNum(string url)
        {
            // 尝试多种可能的分页格式
            var patterns = new (string pattern, string replacement)[]
            {
            (@"page/(\d+)", "page/{0}"),
            (@"page=(\d+)", "page={0}"),
            (@"page-(\d+)", "page-{0}"),
            (@"-(\d+).html","-{0}.html"),
            (@"/(\d+)$", "/{0}")  // 小心使用：避免替换非页码数字
            };

            foreach (var (pattern, replacement) in patterns)
            {
                if (Regex.IsMatch(url, pattern))
                {
                    return Regex.Replace(url, pattern, replacement);
                }
            }

            // 如果没有匹配到分页数字，返回原始 URL
            return url;
        }

    }
}

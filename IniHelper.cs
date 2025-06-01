using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CefSharp.DevTools.FedCm;

namespace GetMagnet
{
    public class IniAccountManager
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileSectionNames(byte[] retVal, int size, string filePath);
        [DllImport("kernel32")]

        private static extern int GetPrivateProfileSection(string section, byte[] retVal, int size, string filePath);
        /// <summary>
        /// 写入或更新完整账号信息
        /// </summary>
        /// <param name="filePath">INI文件路径</param>
        /// <param name="account">账号对象</param>
        /// <returns>操作类型（Create/Update）</returns>
        public static string WriteAccount(string filePath, Account account)
        {
            bool exists = SectionExists(filePath, account.Section);

            // 写入三个必要字段
            WriteKey(filePath, account.Section, "Username", account.Username);
            WriteKey(filePath, account.Section, "URL", account.URL);
            WriteKey(filePath, account.Section, "Server", account.Zhengzhe);

            return exists ? "Update" : "Create";
        }

        /// <summary>
        /// 更新指定字段（部分更新）
        /// </summary>
        public static void UpdateAccountField(string filePath, string section,
                                            string fieldName, string newValue)
        {
            if (!IsValidField(fieldName))
                throw new ArgumentException("无效的字段名称");

            WriteKey(filePath, section, fieldName, newValue);
        }

        /// <summary>
        /// 检查Section是否存在
        /// </summary>
        public static bool SectionExists(string filePath, string section)
        {
            byte[] buffer = new byte[256];
            return GetPrivateProfileSection(section, buffer, 256, filePath) > 0;
        }

        /// <summary>
        /// 获取所有账号列表
        /// </summary>
        public static List<Account> GetAllAccounts(string filePath)
        {
            var accounts = new List<Account>();
            foreach (var section in GetAllSections(filePath))
            {
                var account = ReadAccount(filePath, section);
                if (account != null) accounts.Add(account);
            }
            return accounts;
        }

        #region 私有方法
        private static void WriteKey(string filePath, string section,
                                   string key, string value)
        {
            if (string.IsNullOrEmpty(value)) value = ""; // 允许清空值
            WritePrivateProfileString(section, key, value, filePath);
        }

        private static Account ReadAccount(string filePath, string section)
        {
            var account = new Account
            {
                Section = section,
                Username = ReadKey(filePath, section, "Username"),
                URL = ReadKey(filePath, section, "URL"),
                Zhengzhe = ReadKey(filePath, section, "Server")
            };
            return IsValidAccount(account) ? account : null;
        }

        private static string ReadKey(string filePath, string section,
                                    string key, int bufferSize = 255)
        {
            StringBuilder sb = new StringBuilder(bufferSize);
            GetPrivateProfileString(section, key, "", sb, bufferSize, filePath);
            return sb.ToString();
        }

        private static string[] GetAllSections(string filePath)
        {
            byte[] buffer = new byte[4096];
            int len = GetPrivateProfileSectionNames(buffer, 4096, filePath);
            return Encoding.Default.GetString(buffer, 0, len)
                .Split(new[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static bool IsValidAccount(Account account)
        {
            return !(string.IsNullOrEmpty(account.Username) &&
                   string.IsNullOrEmpty(account.URL) &&
                   string.IsNullOrEmpty(account.Zhengzhe));
        }

        private static bool IsValidField(string fieldName)
        {
            return new[] { "Username", "URL", "Zhengzhe" }.Contains(fieldName);
        }
        #endregion
    }


    public class Account
    {
        public string Section { get; set; }
        public string Username { get; set; }
        public string URL { get; set; }
        public string Zhengzhe { get; set; }
    }
}
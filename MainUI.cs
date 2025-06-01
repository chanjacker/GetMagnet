using System;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using static System.Net.Mime.MediaTypeNames;

namespace GetMagnet
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            browser = new CefSharp.WinForms.ChromiumWebBrowser();
            browser.Dock = DockStyle.Fill;
            pbrower.Controls.Add(browser);
            //browser.LoadUrl("https://www.google.com");
            browser.AddressChanged += Browser_AddressChanged;

        }

        private void Browser_AddressChanged(object? sender, AddressChangedEventArgs e)
        {
            GetURL(e.Address);
        }

        public ChromiumWebBrowser browser;
        private void Log(string text)
        {
            if (rblog.InvokeRequired)
            {
                rblog.Invoke(new Action(() =>
                {
                    rblog.AppendText(text + Environment.NewLine);
                    rblog.ScrollToCaret();
                    label1.Text = urls.Count.ToString();
                    this.Text = rblog.Lines.Count().ToString();
                }));
            }
            else
            {
                rblog.AppendText(text + Environment.NewLine);
                rblog.ScrollToCaret();
                label1.Text = urls.Count.ToString();
                this.Text = rblog.Lines.Count().ToString();
            }
        }
        private void GetURL(string text)
        {
            if (tbURL2.InvokeRequired)
            {
                tbURL2.Invoke(new Action(() =>
                {
                    tbURL2.Text = text;
                }));
            }
            else
            {
                tbURL2.Text = text;
            }
        }
        private void GetCount(string text)
        {
            if (label2.InvokeRequired)
            {
                label2.Invoke(new Action(() =>
            {
                label2.Text = text;
            }));
            }
            else
            {
                label2.Text = text;
            }
        }
        List<string> urls = new List<string>();
        private void btnGo_Click(object sender, EventArgs e)
        {
            urls.Clear();
            //ThreadPool.QueueUserWorkItem(new WaitCallback(GetData), tbURL.Text);
            GetData(tbURL.Text.Trim());
        }

        private async void GetData(object? state)
        {
            for (int i = (int)numericUpDown1.Value; i <= numericUpDown2.Value; i++)
            {
                string url = tbURL.Text;
                string myurl = string.Format(url, i);
                browser.LoadUrl(myurl);

                Thread.Sleep(3000);
                string html = await browser.GetMainFrame().GetSourceAsync();
                if (!string.IsNullOrEmpty(html))
                {
                    Account? acc = cbData.SelectedItem as Account;
                    if (acc == null)
                    {
                        return;
                    }
                    List<string> list = Javbus.Gethtml(html, acc);
                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            urls.Add(item);
                        }
                    }
                }
            }
            ThreadPool.QueueUserWorkItem(new WaitCallback(Getmaget), null);
        }

        private async void Getmaget(object? state)
        {

            for (int i = 0; i < urls.Count; i++)
            {
                browser.LoadUrl(urls[i]);
                GetCount(i.ToString());
                Thread.Sleep(3000);
                string html = await browser.GetMainFrame().GetSourceAsync();
                string manget = Javbus.GetMagnet(html);
                if (!string.IsNullOrEmpty(manget))
                {
                    Log(manget);
                }
            }
            Log("完成");
        }

        private async void btntest_ClickAsync(object sender, EventArgs e)
        {
            string url = tbURL.Text;
            //string myurl = string.Format(url, i);
            browser.LoadUrl(url);

            Thread.Sleep(3000);
            string html = await browser.GetMainFrame().GetSourceAsync();
            string manget = Javbus.GetMagnet(html);
            if (!string.IsNullOrEmpty(manget))
            {
                Log(manget);
            }
        }

        private void 清ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rblog.Clear();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rblog.Copy();
        }

        private void btnsetini_Click(object sender, EventArgs e)
        {
            string iniFilePath = System.Windows.Forms.Application.StartupPath + "Accounts.ini";
            string data = tbURL3.Text.Trim();
            string[] parts = data.Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
            // 1. 添加新账号
            Account newAccount = new Account
            {
                Section = parts[0],
                Username = parts[0],
                URL = parts[1],
                Zhengzhe = parts[2]
            };
            IniAccountManager.WriteAccount(iniFilePath, newAccount);
            // 2. 读取账号
            //cbData.Items.Clear();
            cbData.DataSource = IniAccountManager.GetAllAccounts(iniFilePath);
            cbData.DisplayMember = "Section";
            cbData.SelectedIndex = cbData.Items.Count - 1;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            string iniFilePath = System.Windows.Forms.Application.StartupPath + "Accounts.ini";
            //cbData.Items.Clear();
            cbData.DataSource = IniAccountManager.GetAllAccounts(iniFilePath);
            cbData.DisplayMember = "Section";
            cbData.SelectedIndex = 0;
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account? account = cbData.SelectedItem as Account;
            if (account != null)
            {
                tbURL3.Text = string.Format("{0}#{1}#{2}", account.Username, account.URL, account.Zhengzhe);
            }
        }

        private void btnauto_Click(object sender, EventArgs e)
        {
            //string url = Tools.GetPageNum(tbURL.Text.Trim());

            try
            {
                string url = tbURL2.Text.Trim();
                string newurl = Tools.GetPageNum(url);
                tbURL.Text = newurl;
            }
            catch (Exception ex)
            {

                Log(ex.Message);
            }
        }

        private void btnmore_Click(object sender, EventArgs e)
        {
            urls.Clear();
            //ThreadPool.QueueUserWorkItem(new WaitCallback(GetData), tbURL.Text);
            GetData2(tbURL.Text.Trim());
        }
        private async void GetData2(object? state)
        {
            for (int i = (int)numericUpDown1.Value; i <= numericUpDown2.Value; i++)
            {
                string url = tbURL.Text;
                string myurl = string.Format(url, i);
                if (url.Contains("offset"))
                {
                    myurl = string.Format(url, i*50);
                }
              
                browser.LoadUrl(myurl);

                Thread.Sleep(3000);
                string html = await browser.GetMainFrame().GetSourceAsync();
                if (!string.IsNullOrEmpty(html))
                {

                    List<string> list = Javbus.ExtractMagnetLinks(html);

                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            Log(item);
                        }
                    }
                }
            }
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Getmaget), null);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text;
            //string myurl = string.Format(url, i);
            browser.LoadUrl(url);

        }

        private async void btnfh_Click(object sender, EventArgs e)
        {
            rblog.Clear();
            string url = tbURL.Text;
            //string myurl = string.Format(url, i);
            browser.LoadUrl(url);

            Thread.Sleep(3000);
            string html = await browser.GetMainFrame().GetSourceAsync();
            string pattern = @"\b[A-Z]{3,5}-\d{2,5}\b";
            MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                Log(match.Value);  // 输出番号
            }
        }

        private void btnfhorcl_Click(object sender, EventArgs e)
        {
            urls.Clear();
            foreach (var item in rblog.Lines)
            {
                string url = string.Format("https://javbus.com/{0}", item);
                urls.Add(url);
                //browser.LoadUrl(url);

                //Thread.Sleep(3000);
                //string html = await browser.GetMainFrame().GetSourceAsync();
                //Javbus.GetMagnet(html);
            }
            rblog.Clear();

            ThreadPool.QueueUserWorkItem(new WaitCallback(Getmaget), null);
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rblog.SelectAll();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rblog.Cut();
        }
    }
}

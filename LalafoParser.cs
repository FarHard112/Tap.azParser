using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TapazParser.Model;

namespace TapazParser
{
    public partial class LalafoParser : Form
    {
        private static List<LalafoModel> LalafoList = new List<LalafoModel>();
        private static int pageNumber = 1;
        private static int pageNumberLimiter = 70;
        private static List<string> listOfLinks = new List<string>();
        private IWebDriver driver;

        public LalafoParser()
        {
            InitializeComponent();
        }

        #region Clear

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        #endregion Clear

        private void btnParse_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Parse(txtSiteLink.Text);
            });
        }

        private void Parse(string url)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                var html = DownloadHtml(url + $"?page={pageNumber}");
                document.LoadHtml(html);
                if (document != null)
                {
                    var addElements = document.DocumentNode.SelectNodes("//div[@class='AdTileHorizontalImage']//a");
                    foreach (var item in addElements)
                    {
                        var Linkvalue = item.Attributes["href"].Value;
                        listOfLinks.Add(Linkvalue);
                        foreach (var link in listOfLinks)
                        {
                            txtAuthor.AppendText(Environment.NewLine + link);
                            txtAuthor.Text = string.Join(Environment.NewLine,
                                txtAuthor.Lines.Distinct());
                        }

                        pageNumber++;
                        driver.Close();
                        Parse(url);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unknown error Please restart program");
            }
        }

        public string DownloadHtml(string url)
        {
            try
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                var options = new ChromeOptions();
                // options.AddArgument("headless");
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService, options);
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(800);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(driver => driver.FindElements(By.ClassName("subcategory-list")).Last());
                IJavaScriptExecutor jsExecutor = driver as IJavaScriptExecutor;
                jsExecutor.ExecuteScript("window.scrollBy(0,2050)");
                Thread.Sleep(2000);
                var html = driver.PageSource;
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
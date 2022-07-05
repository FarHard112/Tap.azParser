using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;
using TapazParser.Model;

namespace TapazParser
{
    public partial class Form1 : Form
    {
        private static List<string> AddLinks = new List<string>();
        private static List<Author> Authors = new List<Author>();
        private static int InProcess = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var linktoParse = txtSiteLink.Text;

            ParseWithSelenium(linktoParse);
            lblNeedToParse.Text = AddLinks.Count.ToString();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            Task.Run(() =>
            {
                foreach (var item in AddLinks)
                {
                    ParseNumberAndName(item);
                }
            });
        }

        private void ParseNumberAndName(string url)
        {
            try
            {
                using (HttpClientHandler handler = new HttpClientHandler { AllowAutoRedirect = false, AutomaticDecompression = DecompressionMethods.All })
                {
                    using (var client = new HttpClient(handler))
                    {
                        using (HttpResponseMessage response = client.GetAsync(url).Result)
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var html = response.Content.ReadAsStringAsync().Result;
                                if (!string.IsNullOrEmpty(html))
                                {
                                    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                                    document.LoadHtml(html);

                                    #region Shop

                                    if (document.DocumentNode.SelectSingleNode(
                                            ".//div[@class='shop-contact']//a[@class='shop-phones--number']") !=
                                        null)
                                    {
                                        var shopNumber = document.DocumentNode.SelectSingleNode(".//div[@class='shop-contact']//a[@class='shop-phones--number']");
                                        var shopNumberString = shopNumber.Attributes["href"].Value;
                                        //shop-contact--shop-name
                                        var shopName = document.DocumentNode.SelectSingleNode(
                                            ".//div[@class='shop-contact']//a[@class='shop-contact--shop-name']");
                                        var shopNameString = shopName.Attributes["href"].Value;
                                        Author author = new Author();
                                        author.Name = shopNameString.Split('/').Last().ToUpper();
                                        author.Number = ExtensionMethods.ReplaceAt(shopNumberString.Split(':').Last(), 0, ' ').Trim();
                                        Authors.Add(author);
                                        Authors.Distinct();
                                        foreach (var item in Authors)
                                        {
                                            txtAuthor.AppendText(Environment.NewLine + item.Name + "," + "994" + item.Number);
                                            txtAuthor.Text = string.Join(Environment.NewLine,
                                                txtAuthor.Lines.Distinct());
                                        }

                                        InProcess++;
                                        lblInProcess.Text = InProcess.ToString();

                                        #endregion Shop
                                    }
                                    else
                                    {
                                        #region Author

                                        var authorNumber = document.DocumentNode.SelectSingleNode(".//div[@class='author']//a[@class='phone']");
                                        var authorNumberString = authorNumber.InnerText;
                                        authorNumberString = authorNumberString.Replace('(', ' ');
                                    authorNumberString = authorNumberString.Replace(')', ' ');
                                    authorNumberString = authorNumberString.Replace('-', ' ');
                                    authorNumberString=authorNumberString.Replace(" ", "");
                                        var authorName =
                                            document.DocumentNode.SelectSingleNode(
                                                ".//div[@class='name']");
                                        var authorNameString = authorName.InnerText;
                                        Author author = new Author();
                                        author.Name = authorNameString.Split('/').Last().ToUpper();
                                        author.Number = ExtensionMethods.ReplaceAt(authorNumberString.Split(':').Last(), 0, ' ').Trim();
                                        Authors.Add(author);
                                        Authors.Distinct();
                                        foreach (var item in Authors)
                                        {
                                            txtAuthor.AppendText(Environment.NewLine + item.Name + "," + "994" + item.Number);
                                            txtAuthor.Text = string.Join(Environment.NewLine,
                                                txtAuthor.Lines.Distinct());
                                        }
                                        InProcess++;
                                        lblInProcess.Text = InProcess.ToString();

                                        #endregion Author
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #region ParsingWithSelenium

        private void ParseWithSelenium(string url)
        {
            try
            {
                IWebDriver driver;
                var driverService = ChromeDriverService.CreateDefaultService();
                var options = new ChromeOptions();
                options.AddArgument("headless");
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService, options);
                driver.Navigate().GoToUrl(url);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(driver => driver.FindElement(By.ClassName("logo")));
                var addNumberString = driver.FindElement(By.XPath(".//h1[@class='search-title']//span")).Text;
                int addNumber = Int32.Parse(string.Concat(addNumberString.Where(char.IsNumber)));
                var addElements = driver.FindElements(By.XPath(".//a[@class='products-link']"));
                IJavaScriptExecutor jsExecutor = driver as IJavaScriptExecutor;
                while (addElements.Count <= /*addNumber - 200*/100)
                {
                    jsExecutor.ExecuteScript("window.scrollBy(0,1050)");
                    addElements = driver.FindElements(By.XPath(".//a[@class='products-link']"));
                }

                foreach (var link in addElements)
                {
                    AddLinks.Add(link.GetAttribute("href").ToString()); ;
                }
                driver.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unknown error Please restart program");
            }
        }

        #endregion ParsingWithSelenium

        #region Clear

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        #endregion Clear

        #region SaveFile

        private void btnSaveNumbers_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtAuthor.Text);
                }
            }
        }

        #endregion SaveFile
    }
}
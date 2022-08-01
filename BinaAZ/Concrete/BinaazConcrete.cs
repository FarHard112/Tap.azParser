using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TapazParser.BinaAZ.Abstract;
using TapazParser.Model.BinaAZ;

namespace TapazParser.BinaAZ.Concrete;

public class BinaazConcrete : IBinaaz
{
    public IWebDriver driver;
    private static bool driverInit = false;

    public List<string> CollectAdds(int pageNumber)
    {
        List<string> CollectedLinks = new List<string>();

        try
        {
            using (HttpClientHandler handler = new HttpClientHandler())
            {
                using (HttpClient client = new HttpClient(handler))
                {
                    using (HttpResponseMessage responseMessage = client.GetAsync($"https://bina.az/items/all?page=" + pageNumber).Result)
                    {
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            var html = responseMessage.Content.ReadAsStringAsync().Result;
                            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                            document.LoadHtml(html);
                            var links = document.DocumentNode.SelectNodes(".//div[@class='items-i']//a");
                            foreach (var link in links)
                            {
                                string href = link.GetAttributeValue("href", String.Empty);
                                CollectedLinks.Add(href);
                            }
                            return CollectedLinks;
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
        }

        return null;
    }

    public void DriverInit()
    {
        var driverService = ChromeDriverService.CreateDefaultService();
        var options = new ChromeOptions();
        options.AddArgument("headless");
        driverService.HideCommandPromptWindow = true;
        driver = new ChromeDriver(driverService, options);
        driverInit = true;
    }

    public BinaAZModel CollectNumberAndName(string link)
    {
        try
        {
            if (!driverInit)
            {
                DriverInit();
            }
            driver.Navigate().GoToUrl($"https://bina.az{link}");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(By.ClassName("location")));
            var name = driver.FindElement(By.XPath(".//section[@class='contacts']//div[@class='name']"));
            var Name = name.Text.Split("\r").First();
            var hidedPhoneButton = driver.FindElement(By.Id("show-phones"));
            hidedPhoneButton.Click();
            Thread.Sleep(650);
            WebDriverWait waitPhone = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            waitPhone.Until(driver => driver.FindElement(By.XPath(".//div[@class='js-phones']")));
            var afterClickPhone = driver.FindElement(By.XPath(".//div[@class='js-phones']"));
            var showedPhoneText = afterClickPhone.Text;
            var showedPhoneTextFirst = showedPhoneText.Split(" ").First().Replace("(", "").Replace(")", "").Replace("0", "");
            var showedPhoneTextLast = showedPhoneText.Split(" ").Last().Replace("-", "");
            return new BinaAZModel() { Name = Name, Number = showedPhoneTextFirst + showedPhoneTextLast };
        }
        catch (Exception e)
        {
            return null;
        }
    }
}
using OpenQA.Selenium;
using TapazParser.Model.TurboAZ;
using TapazParser.Turbo.az.Abstract;

namespace TapazParser.Turbo.az.Concrete;

public class TurboConcrete : ITurboAz
{
    public IWebDriver driver;
    private int counter = 1;

    public List<string> CollectAdds(int pageNumber)
    {
        List<string> CollectedLinks = new List<string>();
        try
        {
            using (HttpClientHandler handler = new HttpClientHandler())
            {
                using (HttpClient client = new HttpClient(handler))
                {
                    while (counter < pageNumber)
                    {
                        using (HttpResponseMessage responseMessage = client.GetAsync($"https://turbo.az/autos?page=" + counter).Result)
                        {
                            if (responseMessage.IsSuccessStatusCode)
                            {
                                var html = responseMessage.Content.ReadAsStringAsync().Result;
                                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                                document.LoadHtml(html);
                                var links = document.DocumentNode.SelectNodes(".//div[@class='tz-container']/div[@class='products']/div[@class='products-i']/a[@class='products-i__link']");
                                foreach (var link in links)
                                {
                                    string href = link.GetAttributeValue("href", String.Empty);
                                    CollectedLinks.Add(href);
                                   
                                }
                                counter++;
                            }
                        }
                    }
                }
            }
            return CollectedLinks;
        }
        catch (Exception e)
        {
        }

        return null;
    }

    public TurboModel CollectNameAndNumber(string link)
    {
        try
        {
            using (HttpClientHandler handler = new HttpClientHandler())
            {
                using (HttpClient client = new HttpClient(handler))
                {
                    using (HttpResponseMessage responseMessage = client.GetAsync($"https://turbo.az/{link}").Result)

                    {
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            var html = responseMessage.Content.ReadAsStringAsync().Result;
                            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                            document.LoadHtml(html);
                            var sellerPhone = document.DocumentNode.SelectSingleNode(".//div[@class='product-header']/div[@class='seller-info']/div[@class='seller-contacts']/div[@class='seller-phone']//a");
                            string phoneHref = sellerPhone.GetAttributeValue("href", string.Empty);
                            string firstPart = phoneHref.Split(" ").First().Split(":").Last().Replace("(", "").Replace(")", "").Remove(0, 1);
                            string secongPart = phoneHref.Split(" ").Last().Replace("-", "");
                            var sellerName = document.DocumentNode.SelectSingleNode(".//div[@class='product-header']/div[@class='seller-info']/div[@class='seller-contacts']/div[@class='seller-name']//p").InnerText;
                            TurboModel model = new TurboModel()
                            {
                                Name = sellerName,
                                Number = firstPart + secongPart,
                            };
                            return model;
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
}
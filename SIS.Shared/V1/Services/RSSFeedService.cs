using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using HtmlAgilityPack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SIS.Shared.DTOs;
using SIS.Shared.Extensions;
using SIS.Shared.Helpers;
using SIS.Shared.Settings;

namespace SIS.Shared.V1.Services
{
    public interface IRSSFeedService
    {
        List<NewsFeedGetDTO> GetNewsList();
    }
    public class RSSFeedService : IRSSFeedService
    {
        private readonly AppSettings _appSettings;

        public RSSFeedService(IOptionsMonitor<AppSettings> optionsMonitor)
        {
            _appSettings = optionsMonitor.CurrentValue;
        }

        public List<NewsFeedGetDTO> GetNewsList()
        {
            var address = _appSettings.NewsRSSFeedUrl;

            XDocument xml = XDocument.Load(address);
            var root = xml.Elements().Where(a => a.Name.LocalName == "rss").First();
            var channel = root.Elements().Where(a => a.Name.LocalName == "channel").First();

            var NewsItems = channel.Elements().Where(a => a.Name.LocalName == "item").ToList();
            var newsFeedList = new List<NewsFeedGetDTO>();
            foreach (var element in NewsItems)
            {
                string title = element.Elements().Where(a => a.Name.LocalName == "title").First().Value;
                var link = element.Elements().Where(a => a.Name.LocalName == "link").First().Value;
             

                var descriptionRaw = element.Elements().Where(a => a.Name.LocalName == "description").First().Value;
                var pubDate = element.Elements().Where(a => a.Name.LocalName == "pubDate").First().Value;
                DateTime publicationDate = DateTime.Parse(pubDate);
                string description = string.Empty;
                string imageUrl = string.Empty;

                try
                {
                    if (descriptionRaw.Contains("<p>"))
                    {
                        int startIndex = descriptionRaw.IndexOf("<p>", StringComparison.CurrentCultureIgnoreCase) + 3;
                        int endIndex = descriptionRaw.LastIndexOf("</p>", StringComparison.CurrentCultureIgnoreCase);
                        int length = endIndex - startIndex;
                        description = HtmlToText.ConvertHtml(descriptionRaw.Substring(startIndex, length));
                    }

                    if (descriptionRaw.Contains("<img"))
                    {
                        int startIndex = descriptionRaw.LastIndexOf("src=", StringComparison.CurrentCultureIgnoreCase) + 5;
                        int endIndex = descriptionRaw.LastIndexOf(".jpg", StringComparison.CurrentCultureIgnoreCase) + 4;
                        int length = endIndex - startIndex;
                        imageUrl = descriptionRaw.Substring(startIndex, length);
                    }


                    imageUrl = AppendBaseUrl(imageUrl);


                   
                }
                catch (Exception ex)
                {
                    string n = ex.Message;
                }


                char[] s = descriptionRaw.ToCharArray();
                if (!string.IsNullOrEmpty(link))
                {
                    var newsFeed = new NewsFeedGetDTO()
                    {
                        Title = title,
                        Link = link,
                        Description = description,
                        ImageUrl = imageUrl,
                        Article = descriptionRaw.Replace("\"", "").Replace("\n", ""),
                        PublicationDate = publicationDate.ToMilliseconds()
                    };


                    HtmlDocument doc = new HtmlDocument();
                    doc.OptionAutoCloseOnEnd = true;
                    doc.OptionCheckSyntax = false;
                    doc.OptionFixNestedTags = true;
                    // etc, just set them before calling Load or LoadHtml
                    string textToExtractSrcFrom = newsFeed.Article;

                    doc.LoadHtml(textToExtractSrcFrom);

                    var nodes = doc.DocumentNode.SelectNodes("//img[@src]");
                    foreach (var node in nodes)
                    {
                        string src = node.Attributes["src"].Value;
                        string newSrc = AppendBaseUrl(src);
                        newsFeed.Article = newsFeed.Article.Replace(src, newSrc);
                    }
                   

                    newsFeedList.Add(newsFeed);
                }
            }

            return newsFeedList;
        }

        private string AppendBaseUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                string baseUrl = "https://www.knust.edu.gh";
                if (!url.Contains(baseUrl))
                {
                    url = $"{baseUrl}{url}";
                }
            }
            return url;
        }
    }
}

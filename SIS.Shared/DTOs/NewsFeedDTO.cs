using System;
namespace SIS.Shared.DTOs
{
    public class NewsFeedGetDTO
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Article { get; set; }
        public long PublicationDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Utils.Sitemap
{
    // Items in the shopping list
    public class SitemapLocation
    {
        [XmlElement("loc")]
        public string Url { get; set; }

        [XmlElement("changefreq")]
        public ChangeFrequency? ChangeFrequency { get; set; }
        public bool ShouldSerializeChangeFrequency() { return ChangeFrequency.HasValue; }

        [XmlElement("lastmod")]
        public DateTime? LastModified { get; set; }
        public bool ShouldSerializeLastModified() { return LastModified.HasValue; }

        [XmlElement("priority")]
        public decimal? Priority { get; set; }
        public bool ShouldSerializePriority() { return Priority.HasValue; }

        [XmlElement("image", Namespace = "http://www.google.com/schemas/sitemap-image/1.1")]
        public List<SitemapImage> Images { get; set; }
        public bool ShouldSerializeImages() { return Images != null && Images.Count > 0; }
        
        [XmlElement("video", Namespace = "http://www.google.com/schemas/sitemap-video/1.1")]
        public List<SitemapVideo> Videos { get; set; }
        public bool ShouldSerializeVideos() { return Videos != null && Videos.Count > 0; }
    }
    public enum ChangeFrequency
    {
        always,
        hourly,
        daily,
        weekly,
        monthly,
        yearly,
        never
    }
}

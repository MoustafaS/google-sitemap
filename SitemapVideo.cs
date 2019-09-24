using System;
using System.Xml.Serialization;

namespace Utils.Sitemap
{
    [XmlType(Namespace = "http://www.google.com/schemas/sitemap-video/1.1")]
    public class SitemapVideo
    {
        [XmlElement("thumbnail_loc")]
        public string ThumpLocation { get; set; }
        public bool ShouldSerializeThumpLocation() { return !string.IsNullOrEmpty(ThumpLocation); }

        [XmlElement("title")]
        public string Title { get; set; }
        public bool ShouldSerializeTitle() { return !string.IsNullOrEmpty(Title); }

        [XmlElement("content_loc")]
        public string ContentLocation { get; set; }
        public bool ShouldSerializeContentLocation() { return !string.IsNullOrEmpty(ContentLocation); }

        [XmlElement("description")]
        public string Description { get; set; }
        public bool ShouldSerializeDescription() { return !string.IsNullOrEmpty(Description); }

        [XmlElement("duration")]
        public int Duration { get; set; }
        public bool ShouldSerializeDuration() { return Duration != 0; }

        [XmlElement("expiration_date")]
        public DateTime? ExpirationDate { get; set; }
        public bool ShouldSerializeExpirationDate() { return ExpirationDate.HasValue; }

        [XmlElement("rating")]
        public decimal? Rating { get; set; }
        public bool ShouldSerializeRating() { return Rating.HasValue; }

        [XmlElement("view_count")]
        public int ViewCount { get; set; }
        public bool ShouldSerializeViewCount() { return ViewCount != 0; }

        [XmlElement("publication_date")]
        public DateTime? PublicationDate { get; set; }
        public bool ShouldSerializePublicationDate() { return PublicationDate.HasValue; }

        [XmlElement("family_friendly")]
        public bool? FamilyFriendly { get; set; }
        public bool ShouldSerializeFamilyFriendly() { return FamilyFriendly.HasValue; }


        [XmlElement("platform")]
        public string Platform { get; set; }
        public bool ShouldSerializePlatform() { return !string.IsNullOrWhiteSpace(Platform); }

        [XmlElement("price")]
        public decimal? Price { get; set; }
        public bool ShouldSerializePrice() { return Price.HasValue; }

        [XmlElement("requires_subscription")]
        public bool? RequiresSubscription { get; set; }
        public bool ShouldSerializeRequiresSubscription() { return RequiresSubscription.HasValue; }

        [XmlElement("uploader")]
        public string Uploader { get; set; }
        public bool ShouldSerializeUploader() { return !string.IsNullOrEmpty(Uploader); }


        [XmlElement("live")]
        public bool? Live { get; set; }
        public bool ShouldSerializeLive() { return Live.HasValue; }

        [XmlElement("tag")]
        public string Tag { get; set; }
        public bool ShouldSerializeTag() { return !string.IsNullOrEmpty(Tag); }

        [XmlElement("category")]
        public string Category { get; set; }
        public bool ShouldSerializeCategory() { return !string.IsNullOrEmpty(Category); }

    }
}

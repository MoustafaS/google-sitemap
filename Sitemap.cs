﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static google_sitemap.Extensions;

namespace Utils.Sitemap
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class Sitemap
    {
        private ArrayList map;

        public Sitemap()
        {
            map = new ArrayList();
        }

        [XmlElement("url")]
        public SitemapLocation[] Locations
        {
            get
            {
                SitemapLocation[] items = new SitemapLocation[map.Count];
                map.CopyTo(items);
                return items;
            }
            set
            {
                if (value == null)
                    return;
                SitemapLocation[] items = (SitemapLocation[])value;
                map.Clear();
                foreach (SitemapLocation item in items)
                    map.Add(item);
            }
        }

        public string GetSitemapXml()
        {
            return string.Empty;
        }

        public int Add(SitemapLocation item)
        {
            return map.Add(item);
        }

        public void AddRange(IEnumerable<SitemapLocation> locs)
        {
            foreach (var i in locs)
            {
                map.Add(i);
            }
        }

        public void WriteSitemapToFile(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("image", "http://www.google.com/schemas/sitemap-image/1.1");

                XmlSerializer xs = new XmlSerializer(typeof(Sitemap));
                xs.Serialize(fs, this, ns);
            }
        }

        public string WriteSitemapToString()
        {
            using (StringWriter sw = new Utf8StringWriter())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("image", "http://www.google.com/schemas/sitemap-image/1.1");
                ns.Add("video", "http://www.google.com/schemas/sitemap-video/1.1");

                XmlSerializer xs = new XmlSerializer(typeof(Sitemap));
                xs.Serialize(sw, this, ns);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
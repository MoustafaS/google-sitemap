using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Sitemap
{
    class Program
    {
        static void Main(string[] args)
        {
            Sitemap sitemap = new Sitemap();
            sitemap.AddRange(new List<SitemapLocation>{
                new SitemapLocation
                {
                    ChangeFrequency = ChangeFrequency.monthly,
                    Url = "https://www.google.com?1",
                    Images = new List<SitemapImage>{
                        new SitemapImage{
                            Caption="image1",
                            GeoLocation="USA",
                            Location = "https://site.com/logo.png",
                            Title= "this is first image"
                        },
                        new SitemapImage{
                            Caption="image2",
                            GeoLocation="USA",
                            Location = "https://site.com/logo1.png",
                            Title= "this is second image"
                        }
                    }, //optional
                    LastModified = DateTime.Today,
                    Priority=1.0m,
                    Videos = new List<SitemapVideo>{
                        new SitemapVideo{
                            Category = "news",
                            ContentLocation = "https://site.com/path-to-vidoe.mp4",
                            Description = "this is some video",
                            Title = "Video1",
                            Duration=120,
                            FamilyFriendly=true,
                            Platform= "web",
                            Live = false,
                            Rating = 3.2m,
                            ThumpLocation = "https://site.com/path-to-vidoe-thump.png"
                        }
                    }
                },
                new SitemapLocation
                {
                    ChangeFrequency = ChangeFrequency.monthly,
                    Url = "https://www.google.com?2",
                },
                new SitemapLocation
                {
                    ChangeFrequency = ChangeFrequency.monthly,
                    Url = "https://www.google.com?3",
                },
                new SitemapLocation
                {
                    ChangeFrequency = ChangeFrequency.monthly,
                    Url = "https://www.google.com?4",
                },

            });
            var output = sitemap.WriteSitemapToString();
            Console.Write(output);
        }
    }
}

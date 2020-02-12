using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace DependencyInversion_API
{
    class API : IAPI
    {
        static HttpClient client = new HttpClient();
        string title = "Eragon";
       static string APIkey = "jxKT59udjbMukpGrbKEg";
        //secret is for Write operations.
       static string APIsecret = "krgZjZYozkvQIzuLqO3zxqASkXQMlcgtc2kmD4JypI";

        string url = $"https://www.goodreads.com/title.json?key={APIkey}";

        public API()
        {
        }

        //API should work like so: /title.TYPE?key=KEY?title=TITLE
        //alternatively: /show.TYPE?key=KEY?id=INT
        //Reviews: URL: /book/ID.FORMAT?key=KEY or with title string:/book/title.FORMAT?key=KEY?title=TITLE


        public async Task<IBook> FindReviews(string title) {
            //url for the API call.
            //Response is currently returning null, indicating that the URL is wrong or something else.
            string response;
            try
            {
                var uri = new Uri($"https://www.goodreads.com/title.XML?key{APIkey}?title={title}");

                response = await client.GetStringAsync(uri);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            IBook book = Factory.CreateBook();
            //XML to Linq
            var xml = XDocument.Load(response);
            IEnumerable<string> reviews = from item in xml.Descendants("work") select (string)item.Attribute("text_reviews_count");
            book.Reviews = reviews.ToList();
            return book;
        }
    }
}

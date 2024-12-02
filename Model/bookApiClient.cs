using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookShelf.Model
{
    class bookApiClient
    {
        public async Task getBookData(string searchWord)
        {
            try
            {
                string searchUrl = "https://ndlsearch.ndl.go.jp/api/opensearch?title=" + searchWord;
                HttpClient client = new HttpClient();
                var response = client.GetAsync(searchUrl).Result;
                response.EnsureSuccessStatusCode();
                var xml = await response.Content.ReadAsStringAsync();
                var doc = XDocument.Parse(xml);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}

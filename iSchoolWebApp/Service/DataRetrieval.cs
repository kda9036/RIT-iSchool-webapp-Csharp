using System.Net.Http.Headers;

namespace iSchoolWebApp.Service
{
    public class DataRetrieval
    {
        public async Task<string> GetData(string d) 
        { 
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = await client.GetAsync(d, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode(); 
                    // I now have a pointer...
                    var data = await response.Content.ReadAsStringAsync();
                    // just a string
                    return data;
                }
                catch (HttpRequestException hre)
                {
                    return "HttpReq: " + hre.Message;
                }
                catch (Exception e) 
                { 
                    return "Ex: " + e.Message;
                }
            }
        }
    }
}

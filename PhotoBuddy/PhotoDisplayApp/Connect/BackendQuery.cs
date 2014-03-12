using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using PhotoDisplayApp.ViewModels;
using Newtonsoft.Json;

namespace PhotoDisplayApp.Connect
{
    public static class BackendQuery
    {
        public static async Task<PhotoData> GetPhotosAsync()
        {
            HttpClient client = new HttpClient();

            string apikey = "e1c31b591427f8d7bc448a36b2ba093a"; // permenant key, i think
            string userId = "35480912%40N07";

            string url = "http://api.flickr.com/services/rest/?" + "method=flickr.photos.search" + "&api_key={0}"
                + "&user_id={1}" 
                + "&format=json" 
                + "&nojsoncallback=1";

            string baseUrl = string.Format(url, apikey, userId);

            string flickrResult = await client.GetStringAsync(baseUrl);

            PhotoData data = JsonConvert.DeserializeObject<PhotoData>(flickrResult);

            return data;
        }
    }


}

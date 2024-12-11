using Newtonsoft.Json;

namespace courseProject {
    public class IpInfoService {
        private const string ApiUrl = "http://ipwho.is/";

        public static async Task<IpInfo?> GetIpInfo(string ip) {
            using HttpClient client = new();
            string url = $"{ApiUrl}{ip}";
            var response = await client.GetStringAsync(url);
            dynamic data = JsonConvert.DeserializeObject(response);

            if (data?.success == true) {
                return new IpInfo {
                    Ip = data.ip,
                    Country = data.country,
                    Latitude = data.latitude,
                    Longitude = data.longitude,
                };
            }

            return null;
        }
    }
}
using Newtonsoft.Json;

namespace Esercizio27Aprile.Models
{
    public static class JsonModel
    {
        private static readonly string filePath = "https://gist.githubusercontent.com/hanse/4458506/raw/a702c19d07bd7693ee75efef18502c421b565949/phones.json";

        public static List<Phone> JSonReader()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                List<Phone> result = JsonConvert.DeserializeObject<List<Phone>>(json);
                return result;
            }
        }
    }

    public class Phone
    {
        public string Vendor { get; set; }
        public string Model { get; set; }

        public Phone(string vendor, string model)
        {
            Vendor = vendor;
            Model = model;
        }
    }
}

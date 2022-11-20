using Newtonsoft.Json;
using System.Collections.Generic;

namespace SampleExcelAddIn
{
    public class UniversityData
    {
        public string country { get; set; }
        public List<string> domains { get; set; }
        public List<string> web_pages { get; set; }
        public string alpha_two_code { get; set; }
        public string name { get; set; }

        [JsonProperty("state-province")]
       public string stateprovince { get; set; }

    }
}

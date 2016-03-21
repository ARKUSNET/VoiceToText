using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Voice_to_Text
{
    class JSon
    {
        public class SpeechAlternative
        {
            public string Transcript { get; set; }
            public double Confidence { get; set; }
        }

        public class SpeechResult
        {
            public SpeechAlternative[] Alternative { get; set; }
            public bool Final { get; set; }
        }

        public class SpeechResponse
        {
            public SpeechResult[] Result { get; set; }
            public int Result_Index { get; set; }
        }


        public static string Parse(String toParse)
        {
            var jsons = toParse.Split('\n');
            string textFromGoogle = "";
            foreach (var j in jsons)
            {
                var jsonObject = JsonConvert.DeserializeObject<SpeechResponse>(j);
                if (jsonObject == null || jsonObject.Result.Length <= 0) continue;
                var text = jsonObject.Result[0].Alternative[0].Transcript;
                textFromGoogle += text;
            }
            string result = textFromGoogle;
            return result;
        }
    }
}
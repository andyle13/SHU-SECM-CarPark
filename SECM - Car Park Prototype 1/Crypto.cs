using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    public class Crypto
    {
        [JsonProperty(PropertyName = "received")]
        public string Value { get; set; }
    }
}

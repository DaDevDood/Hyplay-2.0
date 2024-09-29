using System;
using Newtonsoft.Json;

namespace HYPLAY.Core.Runtime
{
    [Serializable]
    public class HyplayApp
    {
        public string id;
        public string secretKey;
        public string name;
        public string description;
        public string[] redirectUris;
        public string url;
        public HyplayImageAsset iconImageAsset;
        public HyplayImageAsset backgroundImageAsset;
    }

    [Serializable]
    public class HyplayUser
    {
        
        #if NEWTONSOFT_JSON
        [JsonProperty("id")]
        #endif
        public string Id;

        
        #if NEWTONSOFT_JSON
        [JsonProperty("username")]
        #endif
        public string Username;
    }
}
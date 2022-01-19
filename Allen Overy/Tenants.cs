using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Allen_Overy
{
    class Tenants
    {
        static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string jsonpath = @"tenants.json";
        static string absolutePath = Path.Combine(currentDirectory, jsonpath);
        string json = File.ReadAllText(absolutePath);
        string deserialize = JsonConvert.DeserializeObject<name>(json);
    }
}

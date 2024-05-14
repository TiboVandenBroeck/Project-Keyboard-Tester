using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Collections.Generic;
using System.Windows.Shapes;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.IO;

namespace Project_Keyboard_Tester
{
    public class Keychecker
    {
        public List<string> WorkingKeys { get; set; }

        public Keychecker()
        {
            WorkingKeys = new List<string>();
        }

        public void AddWorkingKey(string keyName)
        {
            if (!WorkingKeys.Contains(keyName))
            {
                WorkingKeys.Add(keyName);
            }
        }

        public void SaveToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(WorkingKeys, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }

}

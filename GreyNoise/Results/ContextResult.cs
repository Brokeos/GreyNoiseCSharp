using System;
using System.Collections.Generic;
using System.Text;

namespace GreyNoise.Results
{
    public class ContextResult
    {

        public string Ip { get; set; }
        public bool Seen { get; set; }
        public string First_Seen { get; set; }
        public string Last_Seen { get; set; }
        public List<string> Tags { get; set; }
        public string Actor { get; set; }
        public bool Spoofable { get; set; }
        public string Classification { get; set; }
        public List<string> Cve { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public object Raw_Data { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GreyNoise.Results
{
    public class QuickCheckResult
    {

        public string Ip { get; set; }
        public bool Noise { get; set; }
        public string Code { get; set; }

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

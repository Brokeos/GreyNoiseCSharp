using System;
using System.Collections.Generic;
using System.Text;

namespace GreyNoise.Results
{
    public class HttpResult
    {

        private int status;
        private string data;

        public HttpResult(int _status, string _data)
        {
            this.status = _status;
            this.data = _data;
        }

        public int Status { get => status; }
        public string Data { get => data; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RykonServer
{
    public class RykonProcessHeader
    {
        private string HeaderName = "";
        private string HeaderValue = "";

        public string Header_Name
        {
            get { return HeaderName; }
            set { HeaderName = value; }
        }
        public string Header_Value
        {
            get { return HeaderValue; }
            set { HeaderValue = value; }
        }

        public RykonProcessHeader(string n,string v)
        {
            this.HeaderName = n;
            this.HeaderValue = v;
            

        }
    
    }
}

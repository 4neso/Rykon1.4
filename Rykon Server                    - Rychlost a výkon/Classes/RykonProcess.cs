using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RykonServer
{
 public    class RykonProcess
    {
        public bool   Requesting_Binary_data = false;
        public byte[] OutPutData = new byte[] { };
        public string Output_document = "";
        public int    Output_code = 200;

        public  string Client_UserAgent = "";
        public  string Client_IpAddress = "";
        public bool    Client_error = false;


        public  bool Success = false;
        public  bool InternalError = false;
        public  ExceptionType exception = ExceptionType.none_;
        public  List<RykonProcessHeader> OutPut_Headers = new List<RykonProcessHeader>();


        public string LocalPath = "";//   { get; set; }
        public string RequestPage = "";// { get; set; }

        public string Request_extn = "";// { get; set; }

        public string Requesting_Host ="";//{ get; set; }

        public bool Canceled =false;//{ get; set; }

        public ProcessingResult Processing_Type = ProcessingResult.TextHtml;//{ get; set; }
        
        internal void AddRequestHeader(HttpHeader hp)
        {
            int i = 0;
            foreach (HttpHeader h in this.RequestHeaders)
            {
                if (h.name == hp.name)
                {
                    this.RequestHeaders[i].UpdateVals(hp);
                    return;
                } i++;

            }
            this.RequestHeaders.Add(hp);

        }

        public List<HttpHeader> RequestHeaders = new List<HttpHeader>();
      
     internal void SaveRequestHeaders(System.Collections.Specialized.NameValueCollection nameValueCollection)
        {
            HttpHeader h = new HttpHeader();
            // Get each header and display each value.
            foreach (string key in nameValueCollection.AllKeys)
            {
                h.name = key.Trim();
                string[] values = nameValueCollection.GetValues(key);
                
                if (values.Length > 0)
                {
                    foreach (string value in values)
                        h.inservalue(value);
                }   
                
              }
            this.AddRequestHeader(h);
        }



        internal void IsComingCookieSetTo(string p1, string p2)
        {
            foreach (HttpHeader h in this.RequestHeaders)
            {
                if (h.name.ToLower().Trim() == "cookie")
                {
                    foreach(string v in h.Vals)
                        if(v == p2 )
                    return;
                }
            }
        }

        internal bool IsHeaderHas(string hname, string val1,string val2)
        {
            List<bool> lst = new List<bool>();
            foreach (HttpHeader h in this.RequestHeaders)
            {
                if (h.ISCookieHeader())
                {
                    return h.Vals.Contains(val1) && h.Vals.Contains(val2);
                }
            }
            return false;
        }

        public string UrlOriginalString =""; 
        internal static bool IsREquestingTool(string p)
        {

            if (p.StartsWith("/Stream/") || p == "/Stream")
                return true;
            if (p.StartsWith("/Video/") || p == "/Video")
                return true;
            if (p.StartsWith("/Listen/") || p == "/Listen")
                return true;
            if (p.StartsWith("/Control/") || p == "/Control")
                return true;

            return false;
        }

        public bool RequestBuiltInTool =false;
        public bool CanConnect =true;
        public string RequestorAddress ="";

        internal void SetData_ReadBinFile(string p)
        {
            try
            {
                this.OutPutData = AppHelper.ReadFileBts(p);

            }
            catch { }
        }

        internal void SetData_ReadTextFile(string p)
        {
            try
            {
                this.OutPutData = ASCIIEncoding.UTF8.GetBytes(AppHelper.ReadFileText(p));

            }
            catch { }
        }

        public string ContentType = "text/html";//{ get; set; }

        public string ErrorMessage { get; set; }
 
        internal int getLenght()
        {
            int i = this.Output_document.Length;
            if (this.Processing_Type == ProcessingResult.Binary)
                i = this.OutPutData.Length;
            return i;
        }

        public Uri Url { get; set; }


        public string RequestPostData ="";

        public bool ServerErroroccured = false;

        public string Requestor_Host { get; set; }
    }
 public enum ProcessingResult{ NotFound, TextHtml, Binary, ServerError, unAuthorized, AuthRequired }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RykonServer
{
   public  class HttpHeader
    {
       public  string name = "";
       public  List<string> Vals = new List<string>();
       public HttpHeader()
       {

       }
       public void inservalue(string v)
       {
           if (Vals.Contains(v))
               return;
           Vals.Add(v);
       }

   
       public 
           void UpdateVals(HttpHeader hp)
       {

           this.Vals.Clear();
           foreach (string s in hp.Vals)
               this.inservalue(s);
       }

       internal bool ISCookieHeader()
       {
           string x = this.name.ToLower().Trim();
           return x == "cookie";
       }
    }
}

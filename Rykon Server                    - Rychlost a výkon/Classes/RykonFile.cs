using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RykonServer.Classes
{
   public class RykonFile
    {
       public string Name = "";
       public string Fullpath = "";
       public string Webpath = "";
       public bool IsDir = false;
       //public RykonFile(string x , bool isdirectory )
       //{
       //    this.IsDir = isdirectory;
       //    this.Fullpath = x;
       //    this.Name = AppHelper.LastPeice(x, x.Contains("\\") ? "\\" : "/");
       //}

       public RykonFile()
       { 
       }

       internal bool hasVals()
       {
           throw new NotImplementedException();
       }
    }
}

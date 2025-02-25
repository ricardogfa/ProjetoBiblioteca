using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLibrary.Comunication.Response
{
    public class ResponseRegisteredUserJson
    {
        public string Name { get; set; } = string.Empty;
        public string AccesssToken {  get; set; } = string.Empty;
    }
}

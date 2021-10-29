using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    [Serializable]
    public class HttpListenerConfig
    {
        public List<string> urlBases;

        public HttpListenerConfig()
        {
            
        }
    }
}
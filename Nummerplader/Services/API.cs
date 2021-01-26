using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Nummerplader.Models;
namespace Nummerplader.Services
{
    public class API
    {
        private HttpClient client;

        public API()
        {
            client = new HttpClient();
        }

        public NummerPladerModel GetNummerPladerByRegistreingsNummer()
        {

        }
    }
}

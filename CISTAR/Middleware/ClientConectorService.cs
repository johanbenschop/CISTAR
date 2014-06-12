using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Middleware
{
    public class ClientConectorService
    {
        private static readonly Lazy<ClientConectorService> Lazy = new Lazy<ClientConectorService>(() => new ClientConectorService());
        public static ClientConectorService Instance { get { return Lazy.Value; } }



    }
}
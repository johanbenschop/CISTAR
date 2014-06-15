using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public class Alliance
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public IList<Corporation> Corporations { get; set; }
    }
}
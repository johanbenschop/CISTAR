using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public class Corporation
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public Alliance Alliance { get; set; }
        public IList<Pilot> Pilots { get; set; }
    }
}
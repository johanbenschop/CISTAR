using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public struct Region
    {
        public long Id { get; internal set; }
        public string Name { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public struct Ship
    {
        public long Id { get; internal set; }
        public string Name { get; internal set; }
        public int TypeId { get; internal set; }
        public string TypeName { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, TypeName);
        }
    }
}
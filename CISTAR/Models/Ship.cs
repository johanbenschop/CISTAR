using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public class Ship
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int TypeId { get; internal set; }
        public string TypeName { get; internal set; }
    }
}
using System;
using System.Collections.Concurrent;
using CISTAR.Models;

namespace CISTAR.Middleware
{
    /// <summary>
    /// Description of Singleton
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private ConcurrentDictionary<int, Pilot> _pilots;

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        private Singleton()
        {
            _pilots = new ConcurrentDictionary<int, Pilot>();
        }

        public void GetPilot()
        {

        }
    }
}

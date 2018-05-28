using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeeIdentified.Data.Entities
{
    public class HistoryDisplay
    {
        public string location;
        public string beeName;
        public int NumSeenBees;

        public HistoryDisplay(string l, string b, int n)
        {
            location = l;
            beeName = b;
            NumSeenBees = n;
        }
    }
}
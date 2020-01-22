using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace exercisedatabase.Data
{
    public partial class Details
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Classification { get; set; }
        public string Utility { get; set; }
        public string Mechanics { get; set; }
        public string Force { get; set; }
        public string Bearing { get; set; }
        public string Impact { get; set; }
        public string Instructions { get; set; }
        public string Preparation { get; set; }
        public string Execution { get; set; }
        public string Comments { get; set; }
        public string[] Muscles { get; set; }
        public string[] Equipment { get; set; }
        public string[] Target { get; set; }
        public string[] Synergists { get; set; }
        public string[] DynamicStabilizers { get; set; }
        public string[] Stabilizers { get; set; }
        public string[] AntogonistStabilizers { get; set; }
        public string GifUrl { get; set; }
    }
}
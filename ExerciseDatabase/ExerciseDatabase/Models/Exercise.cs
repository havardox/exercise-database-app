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

namespace ExerciseDatabase.Models
{
    public class Exercise
    {
        public string pageUrl { get; set; }
        public string name { get; set; }
        public Classification classification { get; set; }
        public Instructions instructions { get; set; }
        public string comments { get; set; }
        public Muscles muscles { get; set; }
        public string gifUrl { get; set; }
    }
    
    public class Classification
    {
        public string utility { get; set; }
        public string mechanics { get; set; }
        public string force { get; set; }
        public string bearing { get; set; }
        public string impact { get; set; }
    }

    public class Instructions
    {
        public string preparation { get; set; }
        public string execution { get; set; }
    }

    public class Muscles
    {
        public string target { get; set; }
        public string synergists { get; set; }
        public string dynamicStabilizers { get; set; }
        public string stabilizers { get; set; }
        public string antogonistStabilizers { get; set; }
    }

    


}
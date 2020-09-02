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
        public object bearing { get; set; }
        public object impact { get; set; }
    }

    public class Instructions
    {
        public string preparation { get; set; }
        public string execution { get; set; }
    }

    public class Muscles
    {
        public object target { get; set; }
        public object synergists { get; set; }
        public object dynamicStabilizers { get; set; }
        public object stabilizers { get; set; }
        public object antogonistStabilizers { get; set; }
    }

    


}
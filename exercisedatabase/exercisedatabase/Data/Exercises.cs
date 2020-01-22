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
using Newtonsoft.Json;

namespace exercisedatabase.Data
{
    
    public partial class Exercises
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<ExercisesDetails> Results { get;set; }


    }
    public partial class ExercisesDetails
    {
        
        public string Name { get; set; }
        
        public string Category { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace exercisedatabase.Data
{
    
    public partial class ExercisesList
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<ExercisesDetails> Results { get; set; }
        
       

    }
    public partial class Muscles
    {

        public List<string> target { get; set; }
        public List<string> synergists { get; set; }
        public List<string> dynamicStabilizers { get; set; }
        public List<string> stabilizers { get; set; }
        public List<string> antogonistStabilizers { get; set; }
    }
    public partial class Classification
    {
        public string utility { get; set; }
        public string mechanics { get; set; }
        public string force { get; set; }
        public string bearing { get; set; }
        public string impact { get; set; }
    }
    public partial class Instructions
    {
        public string preparation { get; set; }
        public string execution { get; set; }
    }

    public partial class ExercisesDetails
    {

        public string pageUrl { get; set; }
        public string Name { get; set; }
        public Classification classification { get; set; }
        public Instructions instructions { get; set; }
        public string comments { get; set; }
        public Muscles muscles { get; set; }
        public string gifUrl { get; set; }


    }
}
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
    public partial class Muscles
    {
        [JsonProperty("target")]
        public object Target { get; set; }

        [JsonProperty("synergists")]
        public object Synergists { get; set; }

        [JsonProperty("dynamicStabilizers")]
        public object DynamicStabilizers { get; set; }

        [JsonProperty("stabilizers")]
        public object Stabilizers { get; set; }

        [JsonProperty("antogonistStabilizers")]
        public object AntogonistStabilizers { get; set; }
    }
    public partial class Classification
    {
        [JsonProperty("utility")]
        public string Utility { get; set; }

        [JsonProperty("mechanics")]
        public string Mechanics { get; set; }

        [JsonProperty("force")]
        public string Force { get; set; }

        [JsonProperty("bearing")]
        public object Bearing { get; set; }

        [JsonProperty("impact")]
        public object Impact { get; set; }
    }
    public partial class Instructions
    {
        [JsonProperty("preparation")]
        public string Preparation { get; set; }

        [JsonProperty("execution")]
        public string Execution { get; set; }
    }

    public partial class ExercisesDetails
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classification")]
        public Classification Classification { get; set; }

        [JsonProperty("instructions")]
        public Instructions Instructions { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("muscles")]
        public Muscles Muscles { get; set; }

        [JsonProperty("gifUrl")]
        public Uri GifUrl { get; set; }


    }
}
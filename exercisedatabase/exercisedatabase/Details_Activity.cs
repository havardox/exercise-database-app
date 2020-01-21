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

namespace exercisedatabase
{
    [Activity(Label = "Details_Activity")]
    public class Details_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.exerciselayout);

            var exerciseTitle = FindViewById<TextView>(Resource.Id.textView1);
            var exerciseDesc = FindViewById<TextView>(Resource.Id.descriptionTextView);

            var exercises = JsonConvert.DeserializeObject<Data.Exercises>(Intent.GetStringExtra("exercises"));

            exerciseTitle.Text = exercises.title;
            exerciseDesc.Text = exercises.description;
           
        }
    }
}
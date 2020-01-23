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

           // SetContentView(Resource.Layout.exerciselayout);
           // var name = FindViewById<TextView>(Resource.Id.name);
           // var description = FindViewById<TextView>(Resource.Id.descriptionTextView);
           // var category = FindViewById<TextView>(Resource.Id.categorytextView);
           // var muscles = FindViewById<TextView>(Resource.Id.musclestextView);
           // var equipment = FindViewById<TextView>(Resource.Id.equipmenttextView);
           

            var exercises = JsonConvert.DeserializeObject<Data.Details>(Intent.GetStringExtra("exercises"));

            //name.Text = "Name: " + exercises.Name;
            //description.Text = "Description: " + exercises.Description;
            //category.Text = "Category: " + exercises.Category;
            //muscles.Text = "Muscles: " + exercises.Muscles;
            //equipment.Text = "Equipment: " + exercises.Equipment;
            
           
        }
    }
}
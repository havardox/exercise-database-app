using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using ExerciseDatabase.Interface;
using Refit;
using EDMTDialog;
using System.Collections.Generic;
using ExerciseDatabase.Models;
using System;
using static Android.Widget.AdapterView;
using Android.Content;

namespace ExerciseDatabase
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        ListView listView;
        ApiInterface apiInterface;


        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            
            listView = FindViewById<ListView>(Resource.Id.exerciselist);

            
            apiInterface = RestService.For<ApiInterface>("https://erikyy.github.io");

            List<Exercise> exercises = await apiInterface.GetExercises();
            List<string> name = new List<string>();

            
             try
             {
                    
             foreach(var exercise in exercises)
                   {
                       name.Add(exercise.name);
                   }
              var adapter = new ArrayAdapter<string>(this,
              Android.Resource.Layout.SimpleListItem1, name);
              listView.Adapter = adapter;
                listView.ItemClick += (object sender, ItemClickEventArgs e) =>
                {
                    var exercisedetail = exercises[e.Position];

                    var intent = new Intent(this, typeof(DetailsActivity));
                    intent.PutExtra("name", exercisedetail.name);
                    intent.PutExtra("execution", exercisedetail.instructions.execution);
                    intent.PutExtra("preparation", exercisedetail.instructions.preparation);
                    intent.PutExtra("url", exercisedetail.gifUrl);
                    intent.PutExtra("utility", exercisedetail.classification.utility);
                    intent.PutExtra("force", exercisedetail.classification.force);
                    intent.PutExtra("mechanics", exercisedetail.classification.mechanics);
                    
                    intent.PutExtra("comments", exercisedetail.comments);
                    intent.PutExtra("pageurl", exercisedetail.pageUrl);
                    StartActivity(intent);
                };

            }
             catch(Exception e)
             {
                     Toast.MakeText(this, "" + e.Message, ToastLength.Long).Show();
             }
            

            

            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
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

namespace ExerciseDatabase
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btn_get_data;
        ListView listView;
        ApiInterface apiInterface;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            btn_get_data = FindViewById<Button>(Resource.Id.get_data);
            listView = FindViewById<ListView>(Resource.Id.get_data);


            apiInterface = RestService.For<ApiInterface>("https://erikyy.github.io");

            btn_get_data.Click += async delegate
             {
                 try
                 {
                     Android.Support.V7.App.AlertDialog dialog = new EDMTDialogBuilder()
                     .SetContext(this)
                     .SetMessage("Please wait...")
                     .Build();

                     if (!dialog.IsShowing)
                         dialog.Show();

                     List<Exercise> exercises = await apiInterface.GetExercises();
                     List<string> name = new List<string>();

                     foreach(var exercise in exercises)
                     {
                         name.Add(exercise.name);
                     }
                     var adapter = new ArrayAdapter<string>(this,
                         Android.Resource.Layout.SimpleListItem1, name);
                     listView.Adapter = adapter;

                     if (dialog.IsShowing)
                         dialog.Dismiss();


                 }
                 catch(Exception e)
                 {
                     Toast.MakeText(this, "" + e.Message, ToastLength.Long).Show();
                 }
             };

            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
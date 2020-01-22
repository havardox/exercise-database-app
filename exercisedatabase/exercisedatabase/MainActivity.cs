using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.IO;
using Newtonsoft.Json;
using exercisedatabase.Data;
using System.Collections.ObjectModel;
using static Android.Widget.AdapterView;
using Android.Content;

namespace exercisedatabase
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var searchText = FindViewById<EditText>(Resource.Id.searchText);
            var searchBtn = FindViewById<Button>(Resource.Id.searchButton);
            var exerciseListView = FindViewById<ListView>(Resource.Id.exerciseListView);

            string queryString = "https://wger.de/api/v2/exercise/";
            var data = await ExerciseDataService.GetExercises(queryString);
            exerciseListView.Adapter = new ExerciseAdapter(this, data.Results);
                
            searchBtn.Click += async delegate
            {
                string searchWord = searchText.Text;
                //to be implemented as current api does not contain search function
            };
            exerciseListView.ItemClick += (object sender, ItemClickEventArgs e) =>
            {
                var exerciseDetails = data.Results[e.Position];
                var intent = new Intent(this, typeof(Details_Activity));
                intent.PutExtra("exerciseDetails", JsonConvert.SerializeObject(exerciseDetails));
                StartActivity(intent);

            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
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

namespace ExerciseDatabase
{
    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_details);

            string name = Intent.GetStringExtra("name");
            string url = Intent.GetStringExtra("url");
            string strpreparation = Intent.GetStringExtra("preparation");
            string strexecution = Intent.GetStringExtra("execution");
            string utility = Intent.GetStringExtra("utility");
            string force = Intent.GetStringExtra("force");
            string mechanics = Intent.GetStringExtra("mechanics");
            string comments = Intent.GetStringExtra("comments");
            string pageurl = Intent.GetStringExtra("pageurl");

            var detailname = FindViewById<TextView>(Resource.Id.detailname);
            var img = FindViewById<ImageView>(Resource.Id.eimg);
            var preparation = FindViewById<TextView>(Resource.Id.preparation);
            var execution = FindViewById<TextView>(Resource.Id.execution);
            var _utility = FindViewById<TextView>(Resource.Id.utility);
            var _force = FindViewById<TextView>(Resource.Id.force);
            var _mechanics = FindViewById<TextView>(Resource.Id.mechanics);
            var _comments = FindViewById<TextView>(Resource.Id.comments);
            var _pageurl = FindViewById<TextView>(Resource.Id.pageurl);


            Android.Net.Uri imgurl = Android.Net.Uri.Parse(url);
            detailname.Text = name;
            img.SetImageURI(imgurl);
            preparation.Text = strpreparation;
            execution.Text = strexecution;
            _utility.Text = utility;
            _force.Text = force;
            _mechanics.Text = mechanics;
            _comments.Text = comments;
            _pageurl.Text = pageurl;

            // Create your application here
        }
    }
}
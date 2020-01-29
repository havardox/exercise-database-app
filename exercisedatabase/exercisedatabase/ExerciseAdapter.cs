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
using exercisedatabase.Data;

namespace exercisedatabase
{
    class ExerciseAdapter : BaseAdapter<ExercisesDetails>
    {
        private List<ExercisesDetails> items;
        private Activity context;

        public ExerciseAdapter(Activity context, List<ExercisesDetails> items) : base()
        {
            this.context = context;
            this.items = items;
        }
        public override ExercisesDetails this[int position]
        {
            get { return items[position]; }
        }



        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.exercise_row_layout, parent, false);

            view.FindViewById<TextView>(Resource.Id.name).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.utility).Text = item.classification.utility;


            return view;
        }

        
        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        
    }

    
}
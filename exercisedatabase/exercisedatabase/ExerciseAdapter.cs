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
        List<ExercisesDetails> _items;
        Activity _context;

        public ExerciseAdapter(Activity context, List<ExercisesDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }
        public override ExercisesDetails this[int position]
        {
            get { return _items[position]; }
        }



        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];
            var view = convertView;

            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.exercise_row_layout, null);

            view.FindViewById<TextView>(Resource.Id.name).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.utility).Text = item.Classification.Utility;


            return view;
        }

        
        public override int Count
        {
            get
            {
                return _items.Count;
            }
        }

    }

    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using exercisedatabase.Data;
using Newtonsoft.Json;

namespace exercisedatabase
{
    public class ExerciseDataService
    {
        public static async Task<Exercises>GetExercises(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Exercises data = null;
            if(response != null)
            {
                data = JsonConvert.DeserializeObject<Exercises>(response);
                return data;
            }
            return null;
        }
    }
}
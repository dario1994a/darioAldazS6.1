using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using darioAldazS6.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly:Xamarin.Forms.Dependency(typeof(mensajeAndroid))]
namespace darioAldazS6.Droid
{
    public class mensajeAndroid : Mensaje
    {
        public void LongAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();

        }

        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();

        }
    }
}
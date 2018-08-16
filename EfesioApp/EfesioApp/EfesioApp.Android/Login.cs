using System;
using System.Net;
using System.Net.Http;
using Android.App;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;

namespace EfesioApp.Droid
{
    [Activity(Label = "@string/app_name", Icon = "@drawable/ic_launcher")]
    public class Login : Activity
    {
        ProgressDialog progress;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login_auth);

            Button login = FindViewById<Button>(Resource.Id.btn_login);

            //Login button click action
            /*login.Click += (object sender, EventArgs e) => {
               Toast.MakeText(this, "Login Button Clicked!", 
               ToastLength.Short).Show();
            };
            */
            login.Click += Button_Click;
        }
        private async void Button_Click(object sender, EventArgs e)
        {
            EditText login_user = FindViewById<EditText>(Resource.Id.login_user);
            EditText password_user = FindViewById<EditText>(Resource.Id.password_user);

            try
            {
                progress.Indeterminate = true;
                progress.SetProgressStyle(ProgressDialogStyle.Spinner);
                progress.SetMessage("Contacting server. Please wait...");
                progress.SetCancelable(false);
                progress.Show();
                
                if (!String.IsNullOrEmpty(login_user.Text))
                {
                    LoginClass login = await Core.GetLoginClass(login_user.Text, password_user.Text);

                    Toast.MakeText(this, "Login Sucess" + login, ToastLength.Short).Show();
                    //FindViewById<TextView>(Resource.Id.login_user).Text = login.Usuario;
                    //FindViewById<TextView>(Resource.Id.password_user).Text = login.Senha;
                }
            }
            catch (HttpRequestException)
            {
                progress.Dismiss();
                Toast.MakeText(this, "Login Fail", ToastLength.Short).Show();
            }
        }
    }
}
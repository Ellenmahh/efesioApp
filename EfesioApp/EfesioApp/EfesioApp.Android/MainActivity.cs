
using System;
using Android.Content;
using Android.Content.Res;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using DrawerLayout = Android.Support.V4.Widget.DrawerLayout;
using ActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using AppCompatActivity = Android.Support.V7.App.AppCompatActivity;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Fragment = Android.App.Fragment;
using Android.App;

namespace EfesioApp.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/ic_launcher")]
    public class MainActivity : AppCompatActivity, PlanetAdapter.IOnItemClickListener
    {
        private DrawerLayout mDrawerLayout;
        private RecyclerView mDrawerList;
        private Toolbar mToolbar;
        private ActionBarDrawerToggle mDrawerToggle;
        private string mDrawerTitle;
        private String[] mPlanetTitles;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            mToolbar = FindViewById<Toolbar>(Resource.Id.mToolbar);
            SetSupportActionBar(mToolbar);
            this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            this.SupportActionBar.SetHomeButtonEnabled(true);

            mDrawerTitle = this.Title;
            mPlanetTitles = this.Resources.GetStringArray(Resource.Array.planets_array);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mDrawerList = FindViewById<RecyclerView>(Resource.Id.left_drawer);

            mDrawerLayout.SetDrawerShadow(Resource.Drawable.drawer_shadow, GravityCompat.Start);
            mDrawerList.HasFixedSize = true;
            mDrawerList.SetLayoutManager(new LinearLayoutManager(this));

            mDrawerList.SetAdapter(new PlanetAdapter(mPlanetTitles, this));
          

            mDrawerToggle = new ActionBarDrawerToggle(
              this, mDrawerLayout, mToolbar, Resource.String.drawer_open, Resource.String.drawer_close);

            mDrawerLayout.AddDrawerListener(mDrawerToggle);

            var fragment = AgendaFragment.NewInstance();
            var fragmentManager = this.SupportFragmentManager;
            var ft = fragmentManager.BeginTransaction();
            ft.Replace(Resource.Id.content_frame, fragment);
            ft.Commit();

        }

    public override bool OnCreateOptionsMenu(IMenu menu)
    {
        MenuInflater.Inflate(Resource.Menu.navigation_drawer, menu);
        return true;
    }

    public override bool OnPrepareOptionsMenu(IMenu menu)
    {
        // If the nav drawer is open, hide action items related to the content view
        bool drawerOpen = mDrawerLayout.IsDrawerOpen(mDrawerList);
        menu.FindItem(Resource.Id.action_websearch).SetVisible(!drawerOpen);
        return base.OnPrepareOptionsMenu(menu);
    }

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
        // The action bar home/up action should open or close the drawer.
        // ActionBarDrawerToggle will take care of this.
        if (mDrawerToggle.OnOptionsItemSelected(item))
        {
            return true;
        }
        // Handle action buttons
        switch (item.ItemId)
        {
            case Resource.Id.action_websearch:
                Intent intent = new Intent(Intent.ActionWebSearch);
                intent.PutExtra(SearchManager.Query, this.SupportActionBar.Title);
                if (intent.ResolveActivity(this.PackageManager) != null)
                {
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, Resource.String.app_not_available, ToastLength.Long).Show();
                }
                return true;
               
                case Resource.Id.menu_login:
                Intent intentLogin = new Intent(this, typeof(Login));
                // intentLogin.PutExtra(SearchManager.Query, this.SupportActionBar.Title);
                StartActivity(intentLogin);
                    if (intentLogin.ResolveActivity(PackageManager) == null)
                    {
                        Toast.MakeText(this, "Não abriu", ToastLength.Long).Show();
                    }
                
                return true;

                default:
                return base.OnOptionsItemSelected(item);
        }
    }

    public void OnClick(View view, int position)
    {
  
    }

    protected override void OnTitleChanged(Java.Lang.ICharSequence title, Android.Graphics.Color color)
    {
        this.SupportActionBar.Title = title.ToString();
    }

  
    protected override void OnPostCreate(Bundle savedInstanceState)
    {
        base.OnPostCreate(savedInstanceState);
        mDrawerToggle.SyncState();
    }

    public override void OnConfigurationChanged(Configuration newConfig)
    {
        base.OnConfigurationChanged(newConfig);
        mDrawerToggle.OnConfigurationChanged(newConfig);
    }

   }
}


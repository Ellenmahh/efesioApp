using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;    
using System.Collections.Generic;
using Fragment = Android.Support.V4.App.Fragment;
using Android.Views;

namespace EfesioApp.Droid
{
    public class AgendaFragment : Fragment
    {

        public static Fragment NewInstance()
        {
            Fragment fragment = new AgendaFragment();
            Bundle args = new Bundle();
            fragment.Arguments = args;
            return fragment;
        }

        RecyclerView mRecycleView;
        RecyclerView.LayoutManager mLayoutManager;
        PhotoAlbum mPhotoAlbum;
        AgendaAdapter mAdapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View v =  inflater.Inflate(Resource.Layout.fragment_agenda, container, false);

            mPhotoAlbum = new PhotoAlbum();
            mRecycleView = v.FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mLayoutManager = new LinearLayoutManager(this.Context);
            mRecycleView.SetLayoutManager(mLayoutManager);
            mAdapter = new AgendaAdapter(mPhotoAlbum);
            mAdapter.ItemClick += MAdapter_ItemClick;
            mRecycleView.SetAdapter(mAdapter);

            return v;
        }

       
        private void MAdapter_ItemClick(object sender, int e)
        {
            int photoNum = e + 1;
            Toast.MakeText(this.Context, "This is photo number " + photoNum, ToastLength.Short).Show();
        }
    }
}

